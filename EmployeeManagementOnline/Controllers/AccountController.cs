﻿using System.Web.Mvc;
using EmployeeManagementOnline.Entity;
using EmployeeManagementOnline.Models;

namespace EmployeeManagementOnline.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(SignUpViewModel signUpViewModel)
        {
            if (ModelState.IsValid)
            {
                Account account = new Account();
                account.Name = signUpViewModel.Name;
                account.EmailId = signUpViewModel.EmailId;
                account.Gender = signUpViewModel.Gender;
                account.Password = signUpViewModel.Password;
                account.LanguagesKnown = signUpViewModel.LanguagesKnown;
                account.Qualification = signUpViewModel.Qualification;
                account.Address = signUpViewModel.Address;
                account.City = signUpViewModel.City;
                account.State = signUpViewModel.State;
                account.PhoneNumber = signUpViewModel.PhoneNumber;
                account.PinCode = signUpViewModel.PinCode;
                using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
                {
                    employeeDBContext.Accounts.Add(account);
                    employeeDBContext.SaveChanges();
                }
                ModelState.Clear();
               
            }
            return View("Login");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if(ModelState.IsValid)
            {
                Account account = new Account();
                account.EmailId = loginViewModel.EmailId;
                account.Password = loginViewModel.Password;
                using (EmployeeDBContext employeeDBContext = new EmployeeDBContext())
                {
                    
                }
                ModelState.Clear();
                TempData["Message"] = "Login Successfull!";
            }
            return View();
        }
    }
}