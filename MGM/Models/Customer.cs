using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        public string Brand { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
    }
}
