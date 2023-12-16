using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class Shelving
    {
        [Key]
        public Guid ShelvingId { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        [Display(Name = "Total Grow Spaces")]
        public int TotalGrowSpaces { get; set; }
        public virtual List<Supplier>? Suppliers { get; set; } //List of Suppliers
    }
}
