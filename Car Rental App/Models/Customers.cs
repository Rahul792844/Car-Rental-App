using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class Customers
    {
        [Key]
        public int CustomerNo { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [ForeignKey("Cities")]
        public int CitiesNo { get; set; }
        public virtual Cities cities { get; set; }

        [ForeignKey("States")]
        public int StateNo { get; set; }
        public virtual States states   {get;set;}

        public string PinCode { get; set; }

        [ForeignKey("Countries")]
        public string CountryNo { get; set; }

        public string PhoneNo { get; set; }

        public string MobileNo { get; set; }

      //  public dateandtime RegistractionDate { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        //public DateandTime LastLogin{get;set;}
        
        public string DeleteStatus { get; set; }


    }
}
