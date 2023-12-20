using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGM.Models
{
    public class Package
    {
        [Key]
        public Guid PackageId { get; set; } //PK
        public Guid SupplierId { get; set; } //FK
        [Display(Name = "Date Y-M-D")]
        public DateOnly Date { get; set; }
        public string Type { get; set; }
        [Display(Name = "Qty of Packages")]
        public int QtyofPackages { get; set; }
        public string Size { get; set; }
        [Display(Name = "Total Packages")]
        public float TotalQty { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        
        [Range(0.01, 999999)]
        public decimal Price { get; set; }        

        public float Subtotal { get; set; }
        [Display(Name = "Current Total")]
        public float CurrentTotal { get; set; }
        [Display(Name = "Remaining Total")]
        public float RemainingTotal { get; set; }

        [ForeignKey(nameof(SupplierId))]
        [ValidateNever]
        
        public virtual Supplier? Supplier { get; set; }
        //public virtual List<Supplier>? Suppliers { get; set; } //List of Suppliers

        //public virtual List<SelectListItem>? PackageList { get; set; }
    }
}
