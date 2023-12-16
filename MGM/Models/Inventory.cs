using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class Inventory
    {
        [Key]
        public Guid InventoryId { get; set; }
        [Display(Name = "Inventory Type")]
        public string InventoryType { get; set; }

        public virtual List<Crop>? Crops { get; set; } //List of Crops in the Inventory
    }
}
