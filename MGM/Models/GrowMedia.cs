using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class GrowMedia
    {
        [Key]
        public int GrowMediaId { get; set; }
        public float Qty { get; set; }
        public string Type { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public virtual List<Supplier>? Suppliers { get; set; } //List of Suppliers

    }
}
