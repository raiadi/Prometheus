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

        public IRestResponse<T> Get<T>(string apiEndpoint, string apiHeader)
        {
            //var request = CreateRequest(apiEndpoint, apiHeader);
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("api/users/2", Method.GET);

            request.AddHeader("x-rapidapi-proxy-secret", "a755b180-f5a9-11e9-9f69-7bf51e845926");
            request.AddHeader("X-RapidAPI-Key", "121aa41317msh185b3ed2a2abf01p183d0fjsn20e9ed1e51af");
            request.AddHeader("x-rapidapi-host", "stock-and-options-trading-data-provider.p.rapidapi.com");
            var queryResult = client.Execute<T>(request);

            return queryResult;
        }

        private object CreateRequest(string apiEndpoint, object apiHeader)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}
