
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MGM.Models
{
    public class InventoryProduct
    {

        [Key]
        public Guid InventoryProductId { get; set; }//PK
        public Guid SupplierId { get; set; } //FK
        public string Name { get; set; }
        public int Qty { get; set; }
        public float Price { get; set; }

        [Display(Name = "Date Y-M-D")]
        public DateOnly Date { get; set; }

        [ForeignKey(nameof(SupplierId))]
        [ValidateNever]
        public virtual Supplier? Supplier { get; set; }

    }
}
