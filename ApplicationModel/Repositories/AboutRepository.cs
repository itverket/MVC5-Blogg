using System.Linq;

namespace ApplicationModel.Repositories
{
    public class AboutRepository
    {
       private ApplicationContext _dbContext;

        public AboutRepository()
        {
            _dbContext = new ApplicationContext();
        }

        public AboutInformation GetAboutInformation()
        {
            return _dbContext.AboutInformation.FirstOrDefault();
        }

        public void EditAboutInformation(AboutInformation newAboutInformation)
        {
            var aboutInformation = _dbContext.AboutInformation.FirstOrDefault();
            if (aboutInformation != null)
            {
                aboutInformation.AboutMe = newAboutInformation.AboutMe;
                aboutInformation.BirthDate = newAboutInformation.BirthDate;
                aboutInformation.FirstName = newAboutInformation.FirstName;
                aboutInformation.LastName = newAboutInformation.LastName;
            }
            else
            {
                _dbContext.AboutInformation.Add(new AboutInformation
                {
                    BirthDate = newAboutInformation.BirthDate,
                    FirstName = newAboutInformation.FirstName,
                    LastName = newAboutInformation.LastName,
                    AboutMe = newAboutInformation.AboutMe
                });
            }
            _dbContext.SaveChanges();
        }

    }
}