using System.ComponentModel.DataAnnotations;

namespace Car_Rental_App.Models
{
    public class VahicleCapacity
    {
        [Key]
        public int CapacityNo { get; set; }

        public int Capacity { get; set; }


    }
}
