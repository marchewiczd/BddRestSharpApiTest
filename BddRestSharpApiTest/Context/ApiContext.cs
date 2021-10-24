using RestSharp;

namespace BddRestSharpApiTest.Context
{
    public class ApiContext
    {
        public readonly RestClient Client = new RestClient("http://dummy.restapiexample.com/api/v1/");
        
        public RestRequest Request { get; set; }
        
        public IRestResponse Response { get; set; }
    }
}