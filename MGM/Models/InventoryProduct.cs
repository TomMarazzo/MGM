using static MGM.Models.InventoryCategory;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class InventoryProduct
    {
            [Key]
            public Guid InventoryProductId { get; set; }//PK
            public Guid CategoryId { get; set; } //FK
            public string Name { get; set; }
            public string Description { get; set; }
            public float Price { get; set; }
            [ForeignKey(nameof(CategoryId))]
            public virtual InventoryCategory InventoryCategory { get; set; }
        
    }
}
