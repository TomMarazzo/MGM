using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class Lighting
    {
        [Key]
        public int LightingId { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        
        public virtual List<Supplier>? Suppliers { get; set; } //List of Suppliers

    }
}
