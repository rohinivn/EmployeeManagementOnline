using System.Collections.Generic;
using EmployeeManagementOnline.Repository;
using EmployeeManagementOnline.Entity;
using System.Web.Mvc;
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
            IEnumerable<Employee> employee = employeeRepository.GetAllEmployees();
            return View(employee);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            //Employee employee = new Employee();
            //UpdateModel<Employee>(employee);
            ////TryUpdateModel(productData);
            if (ModelState.IsValid)
            {
                employeeRepository.AddEmployee(employee);
                TempData["Message"] = "Employee Added Successfully!";
                return RedirectToAction("Employee");
            }
            return View();
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
            Employee employee = employeeRepository.GetEmployee(id);
            return View(employee);
        }
        [HttpPost]
        public ActionResult Update([Bind(Include  = "EmployeeName,WorkType,Experience,Salary")] Employee employee)
        {
            //Employee employee = new Employee();
            //employee.EmployeeId = formCollection["EmployeeId"];
            //employee.EmployeeName = formCollection["EmployeeName"];
            //employee.WorkType = formCollection["WorkType"];
            //employee.Experience = Convert.ToByte(formCollection["Experience"]);
            //employee.Salary = Convert.ToDouble(formCollection["Salary"]);
            employee.EmployeeId = EmployeeRepository.employees.Find(name => name.EmployeeName == employee.EmployeeName).EmployeeId;
            if (ModelState.IsValid)
            {
                employeeRepository.UpdateEmployee(employee);
                TempData["Message"] = "Employee Details Updated Successfully";
                return RedirectToAction("Employee");
            }
            return View(employee);
        }
    }
}