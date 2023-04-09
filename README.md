# AllInOneApp
[![Hack Together: Microsoft Graph and .NET](https://img.shields.io/badge/Microsoft%20-Hack--Together-orange?style=for-the-badge&logo=microsoft)](https://github.com/microsoft/hack-together)

## Screenshots
![Shot 1](Images/shot1.png)
![Shot 2](Images/shot2.png)
![Shot 3](Images/shot3.png)

## My 2 cents
- I'm explored the code; Microsoft Graph 5.0 cannot be downgraded, so... no W10M / no net standard 1.4
- I tested and re-designed this project a veeeeeryyyy little. ;))  


## Project Description

### Summary:
The motivation behind creating this app was to have just one app that enables all Microsoft apps. Due to limited time available, this app combines three Microsoft apps with limited functionality: To do, Mail, and Calendar.

### Current implementation:

ToDo : 
- Toggle between pending and completed task
- Add new task with due date
- Set task priority
- Update task status to done


Email :
- Shows only important emails

Calendar :
- Shows upcoming events
- Add new event
- Note: This application runs on client ID MainPage.xaml.cs so we need to change ID on line 38

### Repo URL
https://github.com/Dikshabhura/AllInOneApp/tree/Main

### Team members
- [Dikshabhura](https://github.com/Dikshabhura/)

## Bugs (?)
- Strange task list getting (locale-dependency). If I not localized "Tasks" string, getlist returns null.
- If no active tasks (all tasks completed), after "show completed tasks" switching on I got strange task list behavior (infinite repeats of task items)


## My Ideas
- Cell Surface Duo 1, install Project WOA/Duo, and build AllInOneApp for WindowsOnArm :)


## ..
AS IS. RnD only. DIY :)

## .
- me 2023

