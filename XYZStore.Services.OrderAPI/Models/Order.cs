using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace XYZStore.Services.OrderAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int MerchantID { get; set; }
        [AllowNull]
        public DateTime OrderDate { get; set; }
        [AllowNull]
        public ICollection<OrderProduct> Products { get; set; }
    }
}
