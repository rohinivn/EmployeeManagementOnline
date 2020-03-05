
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementOnline.Entity
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public string WorkType { get; set; }
        public int EmployeeId { get; set; }
        public byte Experience { get; set; }
        public Employee(string name, string workType, int id, byte experience, double salary)
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
