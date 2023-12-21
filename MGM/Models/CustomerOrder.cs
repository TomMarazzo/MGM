using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGM.Models
{
    public class CustomerOrder //Many
    {
        [Key]
        public Guid CustomerOrderId { get; set; }
        public Guid CustomerId { get; set; }    //FK

        public int Qty { get; set; }

        [Display(Name = "Order Date Y-M-D")]
        public DateTime OrderDate { get; set; }
        public float Total { get; set; }        

        [ForeignKey(nameof(CustomerId))]
        [ValidateNever]

        public virtual Customer Customer { get; set; }
    }
}
