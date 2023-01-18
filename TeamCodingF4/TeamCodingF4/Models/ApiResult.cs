namespace TeamCodingF4.Models
{
    public class ApiResult
    {
        public ApiResult(bool status,string msg)
        {
            this.Status = status;
            this.Message = msg;
        }
        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
