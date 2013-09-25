using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using mp.Models;


namespace mp.Test
{
    public class BitstampConnector
    {
        private string _apiURL;
        private string _rawResponseContent;

        public BitstampConnector(string apiURL)
        {
            _apiURL = apiURL;
        }

        public   BitstampTicker GetTicker()
        {
            try
            {
                PerformRequest("/ticker/");
            }
            catch (Exception)
            {
               _rawResponseContent = "";
            }

   
            return ParseResponse(); ;
        }

        private BitstampTicker ParseResponse()
        {

            var deob = JsonConvert.DeserializeObject <BitstampTicker>(_rawResponseContent);
            deob.Timestamp();
            return deob;

        }

        private void PerformRequest(string apiCall)
        {
            //see http://msdn.microsoft.com/en-us/library/windows/apps/xaml/hh781241.aspx

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(_apiURL + apiCall );
                if (response.Result.IsSuccessStatusCode)
                {
                    // by calling .Result you are performing a synchronous call
                    var responseContent = response.Result.Content;

                    // by calling .Result you are synchronously reading the result
                    _rawResponseContent = responseContent.ReadAsStringAsync().Result;
                }
            }
        }
    }
}