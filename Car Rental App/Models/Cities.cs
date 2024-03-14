using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class Cities
    {
        [Key]
        public int CitiesNo { get; set; }

        public string CityName { get; set; }

        [ForeignKey("States")]
        public int StateNo { get;set; }
         public virtual States states { get; set; }
    }
}
