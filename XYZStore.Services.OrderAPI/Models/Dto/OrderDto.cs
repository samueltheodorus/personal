namespace XYZStore.Services.OrderAPI.Models.Dto
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int MerchantID { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
