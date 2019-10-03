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
        
        public static string GetPay(decimal hoursWorked, decimal rateOfPay)
        {
            decimal totalPay;
            string pay;
            if (hoursWorked > 40)
            {
                totalPay = (((hoursWorked - 40) + rateOfPay / 2) + hoursWorked * rateOfPay);
            }
            else
            {
                totalPay = (hoursWorked * rateOfPay);
            }

            pay = totalPay.ToString("C");

            return pay;
        }

        public static string OverTime(decimal hoursWorked)
        {

            if (hoursWorked > 40)
            {
                return $"{hoursWorked - 40} hours.";
            }
            return null;
        }
    }
}
