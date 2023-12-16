using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class CustomerOrder
    {
        [Key]
        public Guid CustomerOrderId { get; set; }
        public virtual List<Customer>? Customers { get; set; } //List of Customers
        public int Qty { get; set; }
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }
        public float Total { get; set; }
        public string Comments { get; set; }
        [Display(Name = "Order Status")]
        public int OrderStatus { get; set; } //Days from Harvest

        public virtual List<CustomerOrderDetail>? CustomerOrderDetails { get; set; }
        public virtual List<Crop>? Crops { get; set; } //List of Crops


    }
}
