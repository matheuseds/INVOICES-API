namespace INVOICES_API.Models
{
    public class ErrorResponse
    {
        public ErrorDetail error { get; set; }
    }

    public class ErrorDetail
    {
        public ErrorMessage message { get; set; }
    }

    public class ErrorMessage
    {
        public string value { get; set; }
    }

}
