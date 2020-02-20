using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementOnline.Entity
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public string WorkType { get; set; }
        public string EmployeeId { get; set; }
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
