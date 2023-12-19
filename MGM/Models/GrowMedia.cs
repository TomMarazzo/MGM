using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class GrowMedia
    {
        [Key]
        public Guid GrowMediaId { get; set; }
        [Display(Name = "Date Y-M-D")]
        public DateOnly Date { get; set; }
        public string Type { get; set; }
        [Display(Name = "No Of Bags")]
        public int NoOfBags { get; set; }
        public float Volume { get; set; }
        public float Qty { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [Required]
        [Range(0.01, 999999)]
        public double Price { get; set; }
        public string Description { get; set; }

        public float Subtotal { get; set; }
        [Display(Name = "Current Total")]
        public float CurrentTotal { get; set; }
        [Display(Name = "Remaining Total")]
        public float RemainingTotal { get; set; }
        public virtual List<Supplier>? Suppliers { get; set; } //List of Suppliers


        //public virtual List<CostQty>? CostQties { get; set; } //List of CostQty

    }
}
