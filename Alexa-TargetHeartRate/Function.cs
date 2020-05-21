using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Newtonsoft.Json;
using Alexa.NET.Request;
using Alexa.NET.Response;
using Alexa.NET.Request.Type;
using Amazon.Lambda.Serialization;
using System.Runtime.Serialization;
using Amazon.Lambda.Serialization.Json;
using Alexa.NET;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Alexa_TargetHeartRate
{
    public class Function
    {
        /// <summary>
        /// A simple function that takes in skill input and JSON context
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        {
            SkillResponse response = new SkillResponse();
            response.Response = new ResponseBody();
            response.Response.ShouldEndSession = false;
            IOutputSpeech innerResponse = null;
            var log = context.Logger;
            log.LogLine($"Skill Request Object:");
            log.LogLine(JsonConvert.SerializeObject(input));

           //ar allResources = GetResources();
           //ar resource = allResources.FirstOrDefault();

            // launches request
            if (input.GetRequestType() == typeof(LaunchRequest))
            {
                log.LogLine($"Default LaunchRequest made: 'Alexa, open Target Heart Rate");
                innerResponse = new PlainTextOutputSpeech();
                (innerResponse as PlainTextOutputSpeech).Text = "Welcome to Target Heart Rate. Would you like me to calculate your target heart rate?";
                response.Response.ShouldEndSession = false;
            }
            else if (input.GetRequestType() == typeof(IntentRequest))
            {
                IntentRequest intentRequest = (IntentRequest)input.Request;

                switch (intentRequest.Intent.Name)
                {
                    case "AMAZON.CancelIntent":
                        log.LogLine($"AMAZON.CancelIntent: send StopMessage");
                        innerResponse = new PlainTextOutputSpeech();
                        (innerResponse as PlainTextOutputSpeech).Text = "StopMessage";
                        response.Response.ShouldEndSession = true;
                        break;
                    case "AMAZON.StopIntent":
                        log.LogLine($"AMAZON.StopIntent: send StopMessage");
                        innerResponse = new PlainTextOutputSpeech();
                        (innerResponse as PlainTextOutputSpeech).Text = "StopMessage";
                        response.Response.ShouldEndSession = true;
                        break;
                    case "AMAZON.HelpIntent":
                        log.LogLine($"AMAZON.HelpIntent: send HelpMessage");
                        innerResponse = new PlainTextOutputSpeech();
                        (innerResponse as PlainTextOutputSpeech).Text = "HelpMessage";
                        break;
                    case "GetMyTargetHeartRate":
                        log.LogLine($"GetMyTargetHeartRate sent: send age to calculate method");
                        innerResponse = new PlainTextOutputSpeech();
                        (innerResponse as PlainTextOutputSpeech).Text = HandleIntent(intentRequest);
                        break;
                    default:
                        log.LogLine($"Unknown intent: " + intentRequest.Intent.Name);
                        innerResponse = new PlainTextOutputSpeech();
                        (innerResponse as PlainTextOutputSpeech).Text = "HelpReprompt";
                        break;
                }
            }

            log.LogLine($"user inputted: {innerResponse}");
            response.Response.OutputSpeech = innerResponse;
            response.Version = "1.0";
            log.LogLine($"Skill Response Object...");
            log.LogLine(JsonConvert.SerializeObject(response));
            return response;
        }

        //public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        //{
        //    var logger = context.Logger;
        //    logger.LogLine($"input request: { input.Request.ToString()}");


        //    if(input.Request is LaunchRequest)
        //    {
        //        logger.LogLine($"You win.");
        //        return HandleLaunch((LaunchRequest)input.Request, logger);



        //    }
        //    else
        //    {
        //        logger.LogLine($"You lose!");
        //        return null;

        //    }
            //switch (input.Request)
            //{
            //    case Alexa.NET.Request.Type.LaunchRequest:
            //        return "Wow! You look amazing for your age!";
            //    case LaunchRequest launchRequest: return HandleLaunch(launchRequest, logger);


            //    case IntentRequest intentRequest: return HandleIntent(intentRequest, logger);
            //}

           // throw new NotImplementedException("I don't know what you want dude!");
        
    
        private SkillResponse HandleLaunch(LaunchRequest launchRequest, ILambdaLogger logger)
        {
            logger.LogLine($"LaunchRequest made");

            var response = ResponseBuilder.Tell(new PlainTextOutputSpeech()
            {
                Text = "Welcome to Target Heart Rate. What is your age?"
            });

            return response;
        }


        /// <summary>
        /// Returns text speech of age to heart rate calculation after user gives age
        /// </summary>
        /// <param name="intentRequest">object</param>
        /// <param name="logger">interface</param>
        /// <returns>object</returns>
        private string HandleIntent(IntentRequest intentRequest)
        {
            //, ILambdaLogger logger
            //logger.LogLine($"IntentRequest {intentRequest.Intent.Name} made");

            var responseSpeech = "Ok, let me calculate that ";

            if (intentRequest.Intent.Slots.TryGetValue("age", out var ageSlot))
            {
                if (!string.IsNullOrEmpty(ageSlot.Value))
                {

                    responseSpeech += CalculateHeartRate(Convert.ToInt32(ageSlot.Value));
                    //responseSpeech += $" from {ageSlot.Value}";
                }
            }

            responseSpeech += "!";

            var response = ResponseBuilder.Tell(new PlainTextOutputSpeech()
            {
                Text = responseSpeech
            });

            return responseSpeech;
        }

        /// <summary>
        /// Calculates user's heart rate according to age
        /// </summary>
        /// <param name="age">int</param>
        /// <returns>string</returns>
        private string CalculateHeartRate(int age)
        {
            //Karvonen method   
            int maxHeartRate = 220 - age;
            string cardio = Math.Floor(maxHeartRate * 0.8).ToString();
            string fatBurn = Math.Floor(maxHeartRate * 0.6).ToString();

            return $"Based on your age, your target heart rate for cardio is: {cardio} and your target heart rate for fat burn is: {fatBurn}";
        }

        /// <summary>
        /// A simple function that takes in skill input and JSON context
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        //public SkillResponse FunctionHandler(SkillRequest input, ILambdaContext context)
        //{
        //    SkillResponse response = new SkillResponse();
        //    response.Response = new ResponseBody();
        //    response.Response.ShouldEndSession = false;
        //    IOutputSpeech innerResponse = null;
        //    var log = context.Logger;
        //    log.LogLine($"Skill Request Object:");
        //    log.LogLine(JsonConvert.SerializeObject(input));

        //    var allResources = GetResources();
        //    var resource = allResources.FirstOrDefault();

        //    // launches request
        //    if (input.GetRequestType() == typeof(LaunchRequest))
        //    {
        //        log.LogLine($"Default LaunchRequest made: 'Alexa, calculate target heart rate");
        //        innerResponse = new PlainTextOutputSpeech();
        //       // (innerResponse as PlainTextOutputSpeech).Text = CalculateHeartRate(resource, age);

        //    }
        //    else if (input.GetRequestType() == typeof(IntentRequest))
        //    {

        //        var intentRequest = (IntentRequest)input.Request;

        //        switch (intentRequest.Intent.Name)
        //        {
        //            case "AMAZON.CancelIntent":
        //                log.LogLine($"AMAZON.CancelIntent: send StopMessage");
        //                innerResponse = new PlainTextOutputSpeech();
        //                (innerResponse as PlainTextOutputSpeech).Text = resource.StopMessage;
        //                response.Response.ShouldEndSession = true;
        //                break;
        //            case "AMAZON.StopIntent":
        //                log.LogLine($"AMAZON.StopIntent: send StopMessage");
        //                innerResponse = new PlainTextOutputSpeech();
        //                (innerResponse as PlainTextOutputSpeech).Text = resource.StopMessage;
        //                response.Response.ShouldEndSession = true;
        //                break;
        //            case "AMAZON.HelpIntent":
        //                log.LogLine($"AMAZON.HelpIntent: send HelpMessage");
        //                innerResponse = new PlainTextOutputSpeech();
        //                (innerResponse as PlainTextOutputSpeech).Text = resource.HelpMessage;
        //                break;
        //            case "GetMyTargetHeartRate":
        //                log.LogLine($"GetMyTargetHeartRateIntent sent: send target heart rate");
        //                // intent request, process the intent
        //                log.LogLine($"Intent Requested {intentRequest.Intent.Name}");
        //                // get the slots
        //                double age = Convert.ToDouble(intentRequest.Intent.Slots["Age"].Value);
        //                innerResponse = new PlainTextOutputSpeech();
        //                (innerResponse as PlainTextOutputSpeech).Text = CalculateHeartRate(resource, age);
        //                break;
        //            //case "GetNewFactIntent":
        //            //    log.LogLine($"GetFactIntent sent: send new fact");
        //            //    innerResponse = new PlainTextOutputSpeech();
        //            //    (innerResponse as PlainTextOutputSpeech).Text = emitNewFact(resource, false);
        //            //    break;
        //            default:
        //                log.LogLine($"Unknown intent: " + intentRequest.Intent.Name);
        //                innerResponse = new PlainTextOutputSpeech();
        //                (innerResponse as PlainTextOutputSpeech).Text = resource.HelpReprompt;
        //                break;
        //        }
        //    }

        //    response.Response.OutputSpeech = innerResponse;
        //    response.Version = "1.0";
        //    log.LogLine($"Skill Response Object...");
        //    log.LogLine(JsonConvert.SerializeObject(response));
        //    return response;
        //}

        /// <summary>
        /// Calculate target heart rates then concatenates output statement and calls output  
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="withPreface"></param>
        /// <returns></returns>
        //    public string CalculateHeartRate(HeartRateResource resource, double age)
        //    {
        //        //Karvonen method   
        //        int maxHeartRate = 220 - Convert.ToInt32(age);
        //        string cardio = Math.Floor(maxHeartRate * 0.8).ToString();
        //        string fatBurn = Math.Floor(maxHeartRate * 0.6).ToString();

        //       // if (withPreface)
        //            return resource.PrefaceMessage + cardio + resource.MiddleMessage + fatBurn; 
        //         //  return resource.Facts[r.Next(resource.Facts.Count)];
        //    }
        //    public List<HeartRateResource> GetResources()
        //    {
        //        List<HeartRateResource> resources = new List<HeartRateResource>();
        //        HeartRateResource enUSResource = new HeartRateResource("en-US");
        //        enUSResource.SkillName = "Target Heart Rate";
        //        enUSResource.PrefaceMessage = "Based on your age, your target heart rate for cardio is: ";
        //        enUSResource.MiddleMessage = "and your target heart rate for fat burn is: ";
        //        enUSResource.HelpMessage = "You can say tell me a science fact, or, you can say exit... What can I help you with?";
        //        enUSResource.HelpReprompt = "You can say tell me a science fact to start";
        //        enUSResource.StopMessage = "Goodbye!";

        //        resources.Add(enUSResource);
        //        return resources;
        //    }


        //}


        //public class HeartRateResource
        //{
        //    public HeartRateResource(string language)
        //    {
        //        this.Language = language;


        //    }

        //    public string Language { get; set; }
        //    public string SkillName { get; set; }
        //    public int Age { get; set; }

        //    public string PrefaceMessage { get; set; }

        //    public string MiddleMessage { get; set; }
        //    public string HelpMessage { get; set; }
        //    public string HelpReprompt { get; set; }
        //    public string StopMessage { get; set; }
        //}

    }
}
