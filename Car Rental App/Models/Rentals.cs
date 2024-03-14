using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class Rentals
    {
        [Key]
        public int RentalNo { get; set; }

        [ForeignKey("Countries")]
        public int CustomerNo { get; set; }
        public  virtual Countries countries { get; set; }

        [ForeignKey("Vehecles")]
        public int VehecleNo { get; set; }
        
        public virtual vehicles vehicles { get; set; }

        [ForeignKey("Drivers")]
        public int DriverNo { get; set; }
        public virtual Drivers drivers { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeNo { get; set; }

        public virtual Employee employee { get; set; }

        public DateAndTime ReservationDate { get; set; }

        public int VehecleRete { get; set; }

        public int NoOfDays { get; set; }

        public DateAndTime StartDate { get; set; }

        public DateAndTime EndDate { get; set; }

        public int NoOfKMS { get; set; }

        public int StartKMS { get; set; }

        public int EndKMS { get; set; }

        public int SoursLoaction { get; set; }

        public int DestinationLoaction { get; set; }

        public string TravelPurpose { get; set; }

        public int Amount { get; set; }

        public string TransactionNo { get; set; }

        public string Status { get; set; }





    }
}
