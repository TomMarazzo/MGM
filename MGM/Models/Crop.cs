using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace MGM.Models
{
    public class Crop
    {
        [Key]
        public Guid CropId { get; set; }
        public string Name { get; set; }
        public int SeedDensity { get; set; }
        public int SoakHours { get; set; } //Scroll bar/wheel
        public int GerminationDays { get; set; } //Scroll bar/wheel
        public int StackDays { get; }//Scroll bar/wheel
        public int BlackOutDays { get; }//Scroll bar/wheel
        public int WeightedDays { get; set; }//Scroll bar/wheel
        public int TotalGrowthDays { get; set; }
        public int ExpectedYield { get; set; }
        public virtual List<Tray>? Trays { get; set; } //List of Tray Types
        public virtual List<Supplier>? Suppliers { get; set; } //List of Suppliers
    }
}
