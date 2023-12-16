using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class CustomerOrder
    {
        [Key]
        public Guid CustomerOrderId { get; set; }
        public virtual List<Customer>? Customers { get; set; } //List of Customers
        public int Qty { get; set; }
        public DateTime OrderDate { get; set; }
        public float Total { get; set; }
        public string Comments { get; set; }

        public int OrderStatus { get; set; } //Days from Harvest

        public virtual List<CustomerOrderDetail>? CustomerOrderDetails { get; set; }
        public virtual List<Crop>? Crops { get; set; } //List of Crops


    }
}
