namespace ApiTests.Models
{
    public class FeeRequest
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Country { get; set; }
        public string CustomerType { get; set; }
    }
}
