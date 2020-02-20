using System.Collections.Generic;
using EmployeeManagementOnline.Repository;
using EmployeeManagementOnline.Entity;
using System.Web.Mvc;
using System;

namespace EmployeeManagementOnline.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepository employeeRepository;
        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository();
        }
        // GET: Employee
        public ActionResult Employee()
        {
            IEnumerable<Employee> employees = employeeRepository.GetAllEmployees();
            return View(employees);
        }
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            Employee employee = new Employee();
            UpdateModel<Employee>(employee);
            employeeRepository.AddEmployee(employee);
            TempData["Message"] = "Employee Added Successfully!";
            return RedirectToAction("Employee");
        }

        public ActionResult Delete(string id)
        {
            employeeRepository.DeleteEmployee(id);
            TempData["Message"] = "Employee Deleted Successfully!";
            return RedirectToAction("Employee");
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            Employee employees = employeeRepository.GetEmployee(id);
            return View(employees);
        }
        [HttpPost]
        public ActionResult Update(FormCollection formCollection)
        {
            Employee employee = new Employee();
            employee.EmployeeId = formCollection["EmployeeId"];
            employee.EmployeeName = formCollection["EmployeeName"];
            employee.WorkType = formCollection["WorkType"];
            employee.Experience = Convert.ToByte(formCollection["Experience"]);
            employee.Salary = Convert.ToDouble(formCollection["Salary"]);
            employeeRepository.UpdateEmployee(employee);
            TempData["Message"] = "Employee Details Updated Successfully";
            return RedirectToAction("Employee");
        }
    }
}