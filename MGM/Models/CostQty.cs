using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class CostQty
    {
        [Key]
        public Guid CostQtyId { get; set; }
        public float Cost { get; set; }
        public float Qty { get; set; }
    }
}
