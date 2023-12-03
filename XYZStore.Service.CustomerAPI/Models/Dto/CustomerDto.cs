using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace XYZStore.Service.CustomerAPI.Models.Dto
{
    public class CustomerDto
    {
        public int CustomerID { get; set; }
        [AllowNull]
        public string CustomerName { get; set; }
        [AllowNull]
        public double CustomerBalance { get; set; }
    }
}
