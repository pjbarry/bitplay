using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Scratchpad
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            doit();
            Console.ReadLine();
        }

        private static async void doit()
        {
            try
            {
                HttpClient client = new HttpClient();

              //  HttpResponseMessage response = await client.GetAsync("https://www.bitstamp.net/api/ticker/");
             //   response.EnsureSuccessStatusCode();
             //   string responseBody = await response.Content.ReadAsStringAsync();
                string body = await client.GetStringAsync("https://www.bitstamp.net/api/ticker/");
                Console.WriteLine("stuff goes here:");
            //    Console.WriteLine(responseBody);
                Console.WriteLine(body);

            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
