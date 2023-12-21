using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGM.Models
{
    public class Customer //One
    {
        [Key]
        public Guid CustomerId { get; set; }        

        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public virtual List<CustomerOrder>? CustomerOrder { get; set; } //List of CustomerOrders in Customer
    }
}
