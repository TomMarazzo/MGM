using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class CostQty
    {
        [Key]
        public Guid CostQtyId { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0.01, 999999)]
        public double Price { get; set; }
        public float Qty { get; set; }
    }
}
