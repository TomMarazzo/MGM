using Microsoft.CodeAnalysis;

namespace MGM.Models
{
    public class Inventory
    {
        public Guid InventoryId { get; set; }
        public string Name { get; set; }

        //public virtual List<Product>? Products { get; set; } //List of Products in the Inventory
    }
}
