using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PayRoll.Models
{
    public class Employee
    {
        public int employeeId { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string employeeName { get; set; }
        [Required]
        [Display(Name = "Pay")]
        public float rateOfPay { get; set; }
        [Required]
        [Display(Name = "Hours Worked")]
        public decimal hoursWorked { get; set; }
        [Required]
        [Display(Name = "Pay Week")]
        [DataType(DataType.Date)]
        public DateTime payWeek { get; set; }
    }
}
