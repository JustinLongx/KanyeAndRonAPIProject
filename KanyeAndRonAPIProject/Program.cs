using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeAndRonAPIProject
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

            QuoteGenerator.KanyeQuote();

            QuoteGenerator.RonQuote();

            Console.ReadKey();

        }
    }
}
