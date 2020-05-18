## Project Alexa Target Heart Rate 

## THIS PROJECT IS IN PROGRESS AND WILL BE DEPLOYED ON OR BEFORE FRIDAY 5/22/2020 :) 
---
### We are deployed on AWS!

[project url here]

---
## Alexa Application

***[Explain your app, should be at least a paragraph. What does it do? Why should I use? Sell your product!]***

This Alexa application interacts with the user via voice and provides them their target heart rate or a cardio zone workout and a fat burn zone workout. The app responds to several utterances that open the app.

Alexa then queries the user for their age and takes that variable in as a "slot". From there, the Karvonen method is applied to calculate the user's target heart rates for a cardio zone workout and a fat burn zone workout. That information is then spoken back to the user by Alexa.

This app is a positive contribution to the Alexa library in that nothing like this exists yet.

The backend was written in C# using ASP.NET Core 3.1.1, Entity Framework Core, and the AWS-Lambda extension for Visual Studio. The utterances and slot were created using the Amazon Alexa developer tool on Amazon's developer website.

---

## Tools Used
Microsoft Visual Studio Community 2019 (Version 15.5.7)

- C#
- ASP.Net Core
- Entity Framework
- AWS - Lambda for Visual Studio
- xUnit
- Amazon Web Services
- Amazon Developer Tools


---

## Recent Updates

#### V 1.4
*Added OAuth for MySpace* - 23 Jan 2003

---

## Getting Started

Clone this repository to your local machine.

```
$ git clone https://github.com/YourRepo/YourProject.git
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2017 (or greater) to build the web application. The solution file is located in the AmandaFE subdirectory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. Before running the application, the provided code-first migration will need to be applied to the SQL server of your choice configured in the /AmandaFE/AmandaFE/appsettings.json file. This requires the Microsoft.EntityFrameworkCore.Tools NuGet package and can be run from the NuGet Package Manager Console:
```
Update-Database
```
Once the database has been created, the application can be run. Options for running and debugging the application using IIS Express or Kestrel are provided within Visual Studio. From the command line, the following will start an instance of the Kestrel server to host the application:
```
cd YourRepo/YourProject
dotnet run
```
Unit testing is included in the AmandaFE/FrontendTesting project using the xUnit test framework. Tests have been provided for models, view models, controllers, and utility classes for the application.

---

## Usage
***[Provide some images of your app with brief description as title]***

### Overview of Recent Posts
![Overview of Recent Posts](https://via.placeholder.com/500x250)

### Creating a Post
![Post Creation](https://via.placeholder.com/500x250)

### Enriching a Post
![Enriching Post](https://via.placeholder.com/500x250)

### Viewing Post Details
![Details of Post](https://via.placeholder.com/500x250)

---
## Data Flow (Frontend, Backend, REST API)
***[Add a clean and clear explanation of what the data flow is. Walk me through it.]***
![Data Flow Diagram](/assets/img/Flowchart.png)

---
## Data Model

### Overall Project Schema
***[Add a description of your DB schema. Explain the relationships to me.]***
![Database Schema](/assets/img/ERD.png)

---
## Model Properties and Requirements

### Blog

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Summary | string | YES |
| Content | string | YES |
| Tags | string(s) | NO |
| Picture | img jpeg/png | NO |
| Sentiment | float | NO |
| Keywords | string(s) | NO |
| Related Posts | links | NO |
| Date | date/time object | YES |


### User

| Parameter | Type | Required |
| --- | --- | --- |
| ID  | int | YES |
| Name/Author | string | YES |
| Posts | list | YES |

---

## Change Log
***[The change log will list any changes made to the code base. This includes any changes from TA/Instructor feedback]***  

---

## Authors
Rosalyn Johnson
Sue Tarazi
Joseph Hangarter
Brody Rebne
Harlen Lopez

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
