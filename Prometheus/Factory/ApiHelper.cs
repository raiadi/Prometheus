using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prometheus.Factory
{
    public class ApiHelper
    {
        #region Declarations

        private RestClient _restClient = new RestClient();

        #endregion Declarations

        #region Methods

        public void Get(string apiEndpoint, string apiHeader)
        {
            //var request = CreateRequest(apiEndpoint, apiHeader);
            var client = new RestClient("https://stock-and-options-trading-data-provider.p.rapidapi.com/");
            var request = new RestRequest("options/aapl", Method.GET);

            request.AddHeader("x-rapidapi-proxy-secret", "a755b180-f5a9-11e9-9f69-7bf51e845926");
            request.AddHeader("X-RapidAPI-Key", "121aa41317msh185b3ed2a2abf01p183d0fjsn20e9ed1e51af");
            request.AddHeader("x-rapidapi-host", "stock-and-options-trading-data-provider.p.rapidapi.com");
            var queryResult = client.Execute(request);

            System.IO.File.WriteAllText(@"C:\Users\thulu\Desktop\Projects\GitHub\Prometheus\Prometheus\RecievedData\", queryResult.ToString());

            //return queryResult;
        }

        private object CreateRequest(string apiEndpoint, object apiHeader)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}
