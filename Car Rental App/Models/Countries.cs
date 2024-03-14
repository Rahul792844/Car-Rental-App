using System.ComponentModel.DataAnnotations;

namespace Car_Rental_App.Models
{
    public class Countries
    {
        [Key]

        public int CountryNo { get; set; }

        public string CountryName { get; set; }

    }
}
