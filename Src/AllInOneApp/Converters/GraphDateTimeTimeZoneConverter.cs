﻿//using Microsoft.Graph.Models;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace AllInOneApp.Converters
{
    public class GraphDateTimeTimeZoneConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            DateTimeTimeZone date = value as DateTimeTimeZone;

            if (date != null)
            {
                // Resolve the time zone
                var timezone = TimeZoneInfo.FindSystemTimeZoneById(date.TimeZone);
                // Parse method assumes local time, which may not be the case
                var parsedDateAsLocal = DateTimeOffset.Parse(date.DateTime);
                // Determine the offset from UTC time for the specific date
                // Making this call adjusts for DST as appropriate
                var tzOffset = timezone.GetUtcOffset(parsedDateAsLocal.DateTime);
                // Create a new DateTimeOffset with the specific offset from UTC
                var correctedDate = new DateTimeOffset(parsedDateAsLocal.DateTime, tzOffset);

                string duedate = "Due "+correctedDate.DayOfWeek.ToString().Substring(0,3)+", "+correctedDate.ToString("MMMM")+" "+correctedDate.Day;
                // Return the local date time string
                return duedate;
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
