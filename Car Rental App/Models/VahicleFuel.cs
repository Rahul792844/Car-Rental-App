using System.ComponentModel.DataAnnotations;

namespace Car_Rental_App.Models
{
    public class VahicleFuel
    {
        [Key]
        public int FuelNo { get; set; }

        public string Fuel { get; set; }
    }
}
