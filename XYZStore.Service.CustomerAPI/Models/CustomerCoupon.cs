using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace XYZStore.Service.CustomerAPI.Models
{
    public class CustomerCoupon
    {
        public int CustomerID { get; set; }
        [AllowNull]
        public Customer Customer { get; set; }
        public int CouponID { get; set; }
    }
}
