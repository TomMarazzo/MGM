using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MGM.Models
{
    public class Tray
    {
        [Key]
        public Guid TrayId { get; set; }
        public string Name { get; set; }

       
    }
}
