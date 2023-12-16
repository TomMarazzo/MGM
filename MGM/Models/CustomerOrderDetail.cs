using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class CustomerOrderDetail
    {
        [Key]
        public int CustomerOrderDetailId { get; set; } //PK
        public int CropId { get; set; } //FK
        public int CustomerOrderId { get; set; } //FK
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0.01, 999999)]
        public double Price { get; set; }

        public CustomerOrder CustomerOrder { get; set; }

        public Crop Crop { get; set; }

    }
}
