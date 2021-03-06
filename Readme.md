## Project Alexa Target Heart Rate 

---

### We are deployed on AWS!

We submitted to deploy on AWS on 5/22/2020

---
## Alexa Application

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
- AWS 
- Lambda for Visual Studio
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

## Usage
***[Provide some images of your app with brief description as title]***

### Amazon Alexa Architecture
![Amazon Alexa Architecture](https://i.imgur.com/U5gzq8H.png)
referenced from: https://developer.amazon.com/en-US/alexa/alexa-skills-kit/start

### Utterances Alexa Will Recognize
![Sample Utterances](https://i.imgur.com/qTOe4sT.png)

### Slot
![Age](https://i.imgur.com/mWF5Ttg.png)

### Validation Rule for Age
![Validation Rule](https://i.imgur.com/etFbkNB.png)

### Endpoint
![Endpoint](https://i.imgur.com/CtuzYf2.png)

### AWS Lambda
![Endpoint](https://i.imgur.com/MTH1vw3.png)

### Interaction with Alexa
![App in use](https://i.imgur.com/1c3FtZA.png)

### Validation Rule with Alexa
![Age Validation](https://i.imgur.com/gVSzbtM.png)

![Age Validation](https://i.imgur.com/mb5jBg7.png)

### Error Messaging with Alexa
![Alexa Cancel](https://i.imgur.com/BxT1237.png)
![Alexa Stop](https://i.imgur.com/0VHkCnq.png)
![Alexa Help](https://i.imgur.com/hQjwzLM.png)

---

## Data Flow 
![Data Flow Diagram](https://i.imgur.com/QLQcI7N.png)

![Data Flow Diagram](https://i.imgur.com/Mp6pNPp.png)

---
## Model Properties and Requirements

| Parameter | Type | Required |
| --- | --- | --- |
| Age  | Amazon.Number | YES |

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
[About Us & Project Presentation](https://docs.google.com/presentation/d/1tS3eec274jsnpqQf_s9rr8RL5FLddIPlPPZriuv5nZU/edit#slide=id.g2accd1c413_3_31)

---

For more information on Markdown: https://www.markdownguide.org/cheat-sheet
