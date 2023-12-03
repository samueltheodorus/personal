using System.ComponentModel.DataAnnotations;

namespace XYZStore.Services.MerchantAPI.Models
{
    public class Merchant
    {
        [Key]
        public int MerchantID { get; set; }
        public string MerchantName { get; set; }
        public string MerchantAddress { get; set; }
    }
}
