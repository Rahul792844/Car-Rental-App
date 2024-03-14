using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class States
    {
        [Key]   
        public int StateNo { get; set; }

        public string StateName { get; set; }

        [ForeignKey("Countries")]
        public int CountryNo { get; set; }

        public virtual Countries Countries { get; set; }

    }
}
