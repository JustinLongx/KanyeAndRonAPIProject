using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KanyeAndRonAPIProject
{
    class QuoteGenerator
    {
        public static void KanyeQuote()
        {
            var client = new HttpClient();// This will help make a request from the internet.
            //Make a request and get a response back in JSON form. 
            //Then ill parse it using Name Value pairs to get what I need. 

            var kanyeURL = "https://api.kanye.rest"; //Made a var to hold the URL I need for Kanye quotes.
            //The actual URL ill be using for the API.
            //Gives a name value pair

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result; //Send get request to read data and get back a response.
            //Using the URL to get a response.

            // Installed Newtonsoft.Json NuGet Package
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            //Needed to reference the name "quote" to get Kanye quote. 

            Console.WriteLine($"--------------------------");
            Console.WriteLine($"Kanye says: '{kanyeQuote}'");
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            //Used jArray this time instead of JObject because they are giving me an array.
            //Parse it into a string and replace every [] with nothing and trim off the rest. 

            Console.WriteLine($"-----------------");
            Console.WriteLine($"Ron Says: {ronQuote}");
            Console.WriteLine($"-----------------");
        }
    }
}
