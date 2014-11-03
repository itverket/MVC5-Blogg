using System.Configuration;
using System.Web.Mvc;
using System.Web.Security;
using BlogApplication.Models;

namespace BlogApplication.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];

            if (model.UserName == username && model.Password == password)
            {
                FormsAuthentication.SetAuthCookie(username, model.RememberMe);

                if (!string.IsNullOrEmpty(returnUrl))
                    return Redirect(returnUrl);

                return RedirectToRoute("Home");
            }

            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();

            return RedirectToRoute("Home");
        }
    }
}