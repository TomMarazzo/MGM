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
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        public float Total { get; set; }
        

        [Display(Name = "Order Status")]
        public int OrderStatus { get; set; } //Days from Harvest

        [ForeignKey(nameof(CustomerId))]
        [ValidateNever]

        public virtual Customer? Customer { get; set; }









    }
}
