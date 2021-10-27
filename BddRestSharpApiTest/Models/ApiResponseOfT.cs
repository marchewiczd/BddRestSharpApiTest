namespace BddRestSharpApiTest.Models
{
    public class ApiResponse<T>
    {
        public T? Data { get; set; }

        public string? Status { get; set; }

        public string? Message { get; set; }
    }
}