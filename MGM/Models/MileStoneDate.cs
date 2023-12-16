using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class MileStoneDate
    {
        [Key]
        public Guid MileStoneDateId { get; set; }
        [Display(Name = "Sew Day")]
        public DateOnly SewDay { get; set; }
        [Display(Name = "Harvest Day")]
        public DateOnly HarvestDay { get; set; }
        [Display(Name = "Delivery Day")]
        public DateOnly DeliveryDay { get; set; }


    }
}
