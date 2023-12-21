using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGM.Models
{
    public class GrowMedia
    {
        [Key]
        public Guid GrowMediaId { get; set; } //PK
        public Guid SupplierId { get; set; } //FK
        [Display(Name = "Date Y-M-D")]
        public DateOnly Date { get; set; }
        public string Type { get; set; }
        public float Volume { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required]
        [Range(0.01, 999999)]
        public double Price { get; set; }    
        public float Tax { get; set; }
        public float Total { get; set; }

        [ForeignKey(nameof(SupplierId))]
        //[ValidateNever]
        public virtual Supplier? Supplier { get; set; }
    }
}
