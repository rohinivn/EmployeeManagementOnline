using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementOnline.Entity
{
    public class Employee
    {
        [Required(ErrorMessage="Name is required")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        [Range(0.01, 10000000.00, ErrorMessage = "Salary must be between 0.01 and 10000000.00")]
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        [Required(ErrorMessage = "Worktype is required")]
        [StringLength(9,ErrorMessage="Length should be 9")]
        public string WorkType { get; set; }
        [ScaffoldColumn(false)]
        public string EmployeeId { get; set; }
        [Required(ErrorMessage = "Experience is required")]
        [Range(0,10,ErrorMessage ="Experience must be between 0 and 10")]
        public byte Experience { get; set; }
        public Employee(string name, string workType, string id, byte experience, double salary)
        {
            this.EmployeeName = name;
            this.WorkType = workType;
            this.EmployeeId = id;
            this.Experience = experience;
            this.Salary = salary;
        }
        public Employee()
        {

        }
    }
}
