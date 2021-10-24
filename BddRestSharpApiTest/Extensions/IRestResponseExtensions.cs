using System;
using Newtonsoft.Json;
using RestSharp;

namespace BddRestSharpApiTest.Extensions
{
    public static class IRestResponseExtensions
    {
        public static T TryGetObjectOfType<T>(this IRestResponse response)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(response.Content);
            }
            catch (JsonReaderException exception)
            {
                Console.WriteLine($"Encountered problem while parsing JSON to type {typeof(T).Name}.");
                Console.WriteLine(exception.Message);
            }

            return default;
        }
    }
}