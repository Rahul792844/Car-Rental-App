using System.ComponentModel.DataAnnotations;

namespace Car_Rental_App.Models
{
    public class VahicleType
    {
        [Key]
        public int TypeNo { get; set; }
        public string Type { get; set; }
    }
}
