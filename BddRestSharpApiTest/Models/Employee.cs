namespace BddRestSharpApiTest.Models
{
    #region Usings

    using Newtonsoft.Json;

    #endregion

    public class Employee
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "employee_name")]
        public string? Name { get; set; }

        [JsonProperty(PropertyName = "employee_salary")]
        public int Salary { get; set; }

        [JsonProperty(PropertyName = "employee_age")]
        public int Age { get; set; }

        [JsonProperty(PropertyName = "profile_image")]
        public string? ProfileImage { get; set; }
    }
}