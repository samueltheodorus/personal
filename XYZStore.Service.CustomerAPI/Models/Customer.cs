using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace XYZStore.Service.CustomerAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [AllowNull]
        public string CustomerName { get; set; }
        [AllowNull]
        public string CustomerAddress { get; set; }
        [AllowNull]
        public DateTime CreatedDate { get; set; }
        [AllowNull]
        public double CustomerBalance { get; set; }
        [AllowNull]
        public ICollection<CustomerCoupon> Coupons { get; set; }
    }
}
