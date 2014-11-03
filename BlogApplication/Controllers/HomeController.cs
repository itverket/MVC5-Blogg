using System;
using System.Web.Mvc;
using ApplicationModel;
using ApplicationModel.Repositories;
using BlogApplication.Models;

namespace BlogApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly AboutRepository _repository = new AboutRepository();

        public ActionResult About()
        {
            var repository = new AboutRepository();

            var aboutInformation = repository.GetAboutInformation();
            var model = new AboutInformationViewModel();
            if (aboutInformation != null)
            {
                model.AboutMe = aboutInformation.AboutMe;
                model.BirthDate = aboutInformation.BirthDate;
                model.FirstName = aboutInformation.FirstName;
                model.LastName = aboutInformation.LastName;
            }
           
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public ActionResult EditAbout()
        {
            var aboutInformation = _repository.GetAboutInformation();
            if (aboutInformation == null)
            {
                return View(new AboutInformationViewModel());
            }
            var model = new AboutInformationViewModel()
            {
                AboutMe = aboutInformation.AboutMe,
                FirstName = aboutInformation.FirstName,
                LastName = aboutInformation.LastName,
                BirthDate = aboutInformation.BirthDate,
            };
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public ActionResult EditAbout(AboutInformationViewModel viewmodel)
        {
            if (ModelState.IsValid) { 

                _repository.EditAboutInformation(new AboutInformation
                {
                    AboutMe = viewmodel.AboutMe,
                    BirthDate = viewmodel.BirthDate,
                    FirstName = viewmodel.FirstName,
                    LastName = viewmodel.LastName,
                });
                return RedirectToAction("About");
            }
            return View(viewmodel);
        }
    }
}