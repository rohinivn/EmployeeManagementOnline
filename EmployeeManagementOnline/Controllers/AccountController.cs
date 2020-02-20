using System.Web.Mvc;

namespace EmployeeManagementOnline.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult SignUp()
        {
            ViewBag.Qualification = new SelectList("Qualification");
            ViewBag.City = new SelectList("City");
            ViewBag.State = new SelectList("State");
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}