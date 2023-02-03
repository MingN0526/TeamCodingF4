namespace TeamCodingF4.Models.Common
{
    public class ResponseModel<T>
    {
        public bool IsOk { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
