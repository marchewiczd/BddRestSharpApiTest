using Newtonsoft.Json;

namespace BddRestSharpApiTest.Models
{
    public class EmployeeCreate
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        [JsonProperty(PropertyName = "salary")]
        public string Salary { get; set; }

        [JsonProperty(PropertyName = "age")]
        public string Age { get; set; }
    }
}