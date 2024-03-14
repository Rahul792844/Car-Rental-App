using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Rental_App.Models
{
    public class EmployeeTypes
    {
        [Key]
        public int EmployeeTypeNo { get; set; }

        public string Type { get; set; }
         

    }
}
