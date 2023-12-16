using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class GrowMedia
    {
        [Key]
        public int GrowMediaId { get; set; }
        public string Type { get; set; }
        //public float Qty { get; set; }
        //[DisplayFormat(DataFormatString = "{0:c}")]
        //[Range(0.01, 999999)]
        //public double Price { get; set; }
        public string Description { get; set; }
        public virtual List<Supplier>? Suppliers { get; set; } //List of Suppliers
        public virtual List<CostQty>? CostQties { get; set; } //List of CostQty

    }
}
