using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class CustomerOrder
    {
        [Key]
        public int CustomerOrderId { get; set; }
        public virtual List<Customer>? Customers { get; set; } //List of Customers
        public int Qty { get; set; }
        public DateTime OrderDate { get; set; }
        public string Comments { get; set; }

        public virtual List<Crop>? Crops { get; set; } //List of Crops


    }
}
