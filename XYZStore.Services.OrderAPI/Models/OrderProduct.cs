using System.Diagnostics.CodeAnalysis;

namespace XYZStore.Services.OrderAPI.Models
{
    public class OrderProduct
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        [AllowNull]
        public Order Order { get; set; }
    }
}
