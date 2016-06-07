using ApplicationModel.Repositories;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class AboutInformationController : ApiController
    {
        private AboutRepository _aboutRepository = new AboutRepository();

        public AboutInformationModel Get()
        {
            var repository = new AboutRepository();
            var information = repository.GetAboutInformation();

            return new AboutInformationModel
            {
                AboutMe = information.AboutMe,
                BirthDate = information.BirthDate,
                FirstName = information.FirstName,
                LastName = information.LastName
            };
        }
    }
}
