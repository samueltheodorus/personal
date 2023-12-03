using System.ComponentModel.DataAnnotations;

namespace XYZStore.Services.CouponAPI.Models
{
    public class Coupon
    {
        [Key]
        public int CouponID { get; set; }
        [Required]
        public string CouponCode { get; set; }
        public DateTime ExpiredDate { get; set; }
        public bool CouponStatus { get; set; }
        [Required]
        public double CouponValue { get; set; }
        public bool IsPercentage { get; set; }
    }
}
