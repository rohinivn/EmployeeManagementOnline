using System.Collections.Generic;
using EmployeeManagementOnline.Entity;
using System.Web.Mvc;
using EmployeeManagementOnline.Models;
using System.Linq;
using System;

namespace EmployeeManagementOnline.Controllers
{
    public class EmployeeController : Controller
    {
       
        // GET: Employee
        //public ActionResult Employee()
        //{
        //    using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
        //        return View(employeeDBContext.Employees.ToList());
        //}
        public ActionResult EmployeeDetails()
        {
            using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
            {
                List<Employee> data = employeeDBContext.Employees.ToList();
                return View(data);
            }
                
        }
        public ActionResult Details(int id)
        {
            using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
            {
                Employee employee = employeeDBContext.Employees.Find(id);
                return View(employee);
            }
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeViewModel employeeViewModel)
        {
            //UpdateModel<Employee>(employee);
            ////TryUpdateModel(productData);
            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                employee.EmployeeId = employeeViewModel.EmployeeId;
                employee.EmployeeName = employeeViewModel.EmployeeName;
                employee.Experience = employeeViewModel.Experience;
                employee.WorkType = employeeViewModel.WorkType;
                employee.Salary = employeeViewModel.Salary;
                using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
                {
                    employeeDBContext.Employees.Add(employee);
                    employeeDBContext.SaveChanges(); 
                    TempData["Message"] = "Employee Added Successfully!";
                    return RedirectToAction("EmployeeDetails");
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
            {
                Employee employee = employeeDBContext.Employees.Find(id);
                employeeDBContext.Employees.Remove(employee);
                employeeDBContext.SaveChanges();
                TempData["Message"] = "Employee Deleted Successfully!";
                return RedirectToAction("EmployeeDetails");
            }
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
            {
                Employee employee = employeeDBContext.Employees.Find(id);
                return View(employee);
            }
        }
        [ActionName("Edit")]
        [HttpPost]
        public ActionResult Update(EmployeeViewModel employeeViewModel)
        {
            Employee employee = new Employee();
            //employee.EmployeeId = formCollection["EmployeeId"];
            //employee.EmployeeName = formCollection["EmployeeName"];
            //employee.WorkType = formCollection["WorkType"];
            //employee.Experience = Convert.ToByte(formCollection["Experience"]);
            //employee.Salary = Convert.ToDouble(formCollection["Salary"]);
            if (ModelState.IsValid)
            {
                using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
                {
                    //employee.EmployeeId = employeeDBContext.Employees.Find(name => name.EmployeeName == employeeViewModel.EmployeeName).EmployeeId;
                    employee = employeeDBContext.Employees.Find(employeeViewModel.EmployeeId);
                    if (employee != null)
                    {
                        employee.EmployeeName = employeeViewModel.EmployeeName;
                        employee.WorkType = employeeViewModel.WorkType;
                        employee.Experience = employeeViewModel.Experience;
                        employee.Salary = employeeViewModel.Salary;
                        employee.EmployeeId = employeeViewModel.EmployeeId;
                        employeeDBContext.SaveChanges();
                        TempData["Message"] = "Employee Details Updated Successfully";
                        return RedirectToAction("EmployeeDetails");
                    }

                }
            }
                return View(employee);
        }
    }
}