using System.ComponentModel.DataAnnotations;

namespace XYZStore.Services.CouponAPI.Models.Dto
{
    public class CouponDto
    {
        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public double CouponValue { get; set; }
        public bool IsPercentage { get; set; }
    }
}
