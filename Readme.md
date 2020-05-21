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



---

## Getting Started

Clone this repository to your local machine.

```
$ git clone https://github.com/suetarazi/Alexa-TargetHeartRate.git
```
Once downloaded, you can either use the dotnet CLI utilities or Visual Studio 2019 (or greater) to build the application. The solution file is located in the Alexa-TargetHeartRate directory at the root of the repository.
```
cd YourRepo/YourProject
dotnet build
```
The dotnet tools will automatically restore any NuGet dependencies. 

---

Unit testing is included in the Alexa-TargetHeartRate project using the xUnit test framework. Tests have been provided for each method in the application.

---

## Usage
***[Provide some images of your app with brief description as title]***

### Amazon Alexa Architecture
![Amazon Alexa Architecture](https://i.imgur.com/U5gzq8H.png)
referenced from: https://developer.amazon.com/en-US/alexa/alexa-skills-kit/start

### Utterances Alexa Will Recognize
![Sample Utterances](https://i.imgur.com/X98HOWn.png)

### Validation Rule for Age
![Validation Rule](https://i.imgur.com/o37mkBV.png)

### Endpoint
![Endpoint](https://i.imgur.com/GJ7msJ8.png)

### AWS Lambda
![Endpoint](https://i.imgur.com/zE2e0DW.png)

---
## Data Flow (Frontend, Backend, REST API)
***[Add a clean and clear explanation of what the data flow is. Walk me through it.]***
![Data Flow Diagram](/assets/img/Flowchart.png)

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

### About Us & Our Journey Building This App
[About Us & Project Presentation](https://docs.google.com/presentation/d/1vfLhkOYDcnnhweAwpU3HOC4k36HhsdMKPa9e0AZGz0M/edit#slide=id.g8703504b22_1_23)

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
