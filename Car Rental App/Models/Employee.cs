using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace Car_Rental_App.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeNo { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeType { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [ForeignKey("Cities")]
        public int CitiesNo { get; set; }

        public virtual Cities cities { get; set; }

        [ForeignKey("States")]
        public int StateNo { get; set; }

        public virtual States states { get; set; }

        public string Pincode { get; set; }

        [ForeignKey("Countries")]
        public int CountryNo { get; set; }

        public virtual Countries countries { get; set; }

        public string PhoneNo { get; set; }

        public string MobileNo { get; set; }

        public string EmailAddress { get; set; }

        public string BankName { get; set; }

        public string BankAccount { get; set; }

        public string PAN { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Vehicle { get; set; }

        public string VehicleMakes { get; set; }

        public string vehicleModel { get; set; }

        public string Employees { get; set; }

        public string Customers { get; set; }

        public string Owners { get; set; }

        public string Drivers { get; set; }

        public string Rentals { get; set; }

      //  public DateAndTime LastLogin { get; set; }

        public string Status { get; set; }

        public string DeleteStatus { get; set; }


    }
}
