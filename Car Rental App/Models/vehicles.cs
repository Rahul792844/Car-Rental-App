using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class vehicles
    {
        [Key]
        public int VehecleNo { get; set; }

        [ForeignKey("Owners")]
        public int OwnerNo { get; set; }
        public virtual Owners owners { get; set; }

        [ForeignKey("VehicleModel")]
        public int ModelNo { get; set; }
        public virtual VahicleModel VehicleModel { get; set; }

        public string Type { get; set; }

        public int Year { get; set; }

        public string Colour { get; set; }

        public string Fuel { get; set; }

        public int Capacity { get; set; }

        public int Mileage { get; set; }

        public byte[] Pic { get; set; }

        public string RegistractionNo { get; set; }

        public string RegistractionState { get; set; }

        public string ChaisisNo { get; set; }

        public int DailyRate { get; set; }

        public int HourlyRate { get; set; }

        public int AdditionalDailyRate { get; set; }

        public int AddtionalHourlyRate { get; set; }

        public string DeleteStatus { get; set; }




    }
}
