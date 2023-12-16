using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class Crop
    {
        [Key]
        public Guid CropId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Seed Density")]
        public int SeedDensity { get; set; }
        [Display(Name = "Soak Hours")]
        public int SoakHours { get; set; } //Scroll bar/wheel
        [Display(Name = "Germination Days")]
        public int GerminationDays { get; set; } //Scroll bar/wheel
        [Display(Name = "Stack Days")]
        public int StackDays { get; }//Scroll bar/wheel *********Missing****
        [Display(Name = "Black Out Days")]
        public int BlackOutDays { get; }//Scroll bar/wheel
        [Display(Name = "Weighted Days")]
        public int WeightedDays { get; set; }//Scroll bar/wheel
        [Display(Name = "Total Growth Days")]
        public int TotalGrowthDays { get; set; }
        [Display(Name = "Expected Yield")]
        public int ExpectedYield { get; set; }
        public virtual List<Tray>? Trays { get; set; } //List of Tray Types
        public virtual List<Supplier>? Suppliers { get; set; } //List of Suppliers
    }
}
