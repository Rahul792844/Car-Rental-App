using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class VahicleModel
    {
        [Key]
        public int ModelNo { get; set; }
        public string Name { get; set; }
        [ForeignKey("VahicleMakes")]
        public int MakeNo { get; set; }

        public virtual VahicleMakes Makes { get; set; }
    }
}
