using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class InventoryCategory
    {
        [Key]
        public Guid InventoryCategoryId { get; set; }
            public string Name { get; set; }

            public virtual List<InventoryProduct>? InventoryProducts { get; set; } //List of Products in the Category
        
    }
}
