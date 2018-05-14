using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NicoPortfolio.Models
{
    public class Message
    {
        public string To = "+14155950819";
        public string From = "+14155691885";
        public string Name { get; set; }
        public string Email { get; set; }
        public string Body { get; set; }
        public string Status { get; set; }

        public Message(string Body)
        {
            this.Body = Body;
        }

        public static List<Message> GetMessages()
        {
            var client = new RestClient("https://api.twilio.com/2010-04-01");
            var request = new RestRequest("Accounts/AC2c570ee852689bf0f0f8ee3a65e5585b/Messages.json", Method.GET);
            client.Authenticator = new HttpBasicAuthenticator("AC2c570ee852689bf0f0f8ee3a65e5585b", "a82adc59b15c9002efc9f287587750db");
            var response = new RestResponse();
            Task.Run(async () =>
            {
                response = await GetResponseContentAsync(client, request) as RestResponse;
            }).Wait();
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var messageList = JsonConvert.DeserializeObject<List<Message>>(jsonResponse["messages"].ToString());
            return messageList;
        }

        public void Send()
        {
            var client = new RestClient("https://api.twilio.com/2010-04-01");
            var request = new RestRequest("Accounts/AC2c570ee852689bf0f0f8ee3a65e5585b/Messages", Method.POST);
            request.AddParameter("To", To);
            request.AddParameter("From", From);
            request.AddParameter("Body", Body);
            request.AddParameter("Email", Email);
            request.AddParameter("Name", Name);

            client.Authenticator = new HttpBasicAuthenticator("AC2c570ee852689bf0f0f8ee3a65e5585b", "a82adc59b15c9002efc9f287587750db");
            client.ExecuteAsync(request, response => {
                Console.WriteLine(response.Content);
            });
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}