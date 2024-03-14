using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class Owners
    {
        [Key]
        public int OwnerNo { get; set; }

        public string OwnerName { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }

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

        public string BankAccount { get; set; }

        public string PAN { get; set; }

        public string DeleteStatus { get; set; }


    }
}
