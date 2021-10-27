namespace BddRestSharpApiTest.Context
{
    #region Usings

    using RestSharp;

    #endregion

    public class ApiContext
    {
        public readonly RestClient Client = new("http://dummy.restapiexample.com/api/v1/");

        public RestRequest? Request { get; set; }

        public IRestResponse? Response { get; set; }
    }
}