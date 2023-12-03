using System.ComponentModel.DataAnnotations;

namespace XYZStore.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public bool ProductStatus { get; set; }
        public int MerchantID { get; set; }
    }
}
