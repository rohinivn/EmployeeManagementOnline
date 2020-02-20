using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeManagementOnline.Entity;

namespace EmployeeManagementOnline.Repository
{
    public class EmployeeRepository
    {
        public static List<Employee> employees = new List<Employee>();
        static EmployeeRepository()
        {
            employees.Add(new Employee("Rohini", "fulltime", "E001", 2, 12000));
            employees.Add(new Employee("Megala", "fulltime", "E002", 3, 20000));
            employees.Add(new Employee("Adhav", "parttime", "E003", 1, 8000));
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee GetEmployee(string employeeId)
        {
            return employees.Find(id => id.EmployeeId == employeeId);
        }
        public void DeleteEmployee(string employeeId)
        {
            Employee employee = GetEmployee(employeeId);
            if (employee != null)
                employees.Remove(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            Employee employees = GetEmployee(employee.EmployeeId);
            employees.EmployeeName = employee.EmployeeName;
            employees.WorkType = employee.WorkType;
            employees.Experience = employee.Experience;
            employees.Salary = employee.Salary;

        }
    }
}
