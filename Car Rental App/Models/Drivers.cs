using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class Drivers
    {
        [Key]
        public int DriverNo { get; set; }

        public string DriverName { get; set; }

        public string LicenceNo { get; set; }

        public string AddressLine1 { get; set; }


        public string AddressLine2 { get; set;}

        [ForeignKey("Cities")]
        public int CitiesNo { get; set; }
        public virtual Cities cities { get; set; }

        [ForeignKey("States")]
        public int StateNo { get; set; }
        public virtual States states { get; set; }

        public string PinCode { get; set; }
        [ForeignKey("Countries")]
        public int CountryNo { get; set; }

        public virtual Countries countries { get; set; }

        public string PhoneNo { get; set; }

        public string MobileNo { get; set; }

        public string BankName { get; set; }

        public string BankAccount { get; set;}

        public string PAN { get; set; }

        public string DeleteStatus { get; set;}
    }
}
