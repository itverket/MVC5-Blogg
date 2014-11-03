using System.Web.Mvc;

namespace BlogApplication.Controllers
{
    public class TaskController : Controller
    {
        public ActionResult Tasks()
        {
            return View();
        }
    }
}