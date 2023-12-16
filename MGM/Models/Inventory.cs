using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class Inventory
    {
        [Key]
        public Guid InventoryId { get; set; }
        public string InventoryType { get; set; }

        public virtual List<Crop>? Crops { get; set; } //List of Products in the Inventory
    }
}
