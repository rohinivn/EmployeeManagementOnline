using System.Web.Mvc;
using EmployeeManagementOnline.Entity;

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
        public ActionResult SignUp(Account account)
        {
            return RedirectToAction("SignUp");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email,string Account)
        {
            return Redirect("~/Controller/Employee/Employee");
        }
    }
}