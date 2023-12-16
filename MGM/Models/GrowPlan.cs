using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class GrowPlan
    {
        [Key]
        public Guid GrowPlanId { get; set; }

        public virtual List<Crop>? Crops { get; set; } //List of Crops
        public virtual List<MileStoneDate>? MileStoneDates { get; set; } //List of Milestones
    }
}
