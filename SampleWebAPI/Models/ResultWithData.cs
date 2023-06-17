namespace SampleWebAPI.Models
{
    public class ResultWithData<T> where T : class
    {
        public T? Data { get; set; }
        public List<T> List { get; set; } = new List<T>();
        public bool IsSuccess { get; set; }
        public string? SuccessMsg { get; set; }
        public string? ErrorMsg { get; set; }
    }
}
