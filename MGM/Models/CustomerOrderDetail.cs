using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGM.Models
{
    public class CustomerOrderDetail
    {
        [Key]
        public Guid CustomerOrderDetailId { get; set; } //PK
        public Guid CropId { get; set; } //FK
        public Guid CustomerOrderId { get; set; } //FK
        public int Quantity { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0.01, 999999)]
        public double Price { get; set; }

        public virtual CustomerOrder CustomerOrder { get; set; }

        [ForeignKey(nameof(CropId))]
        public virtual Crop Crop { get; set; }

    }
}
