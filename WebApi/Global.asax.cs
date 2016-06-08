using System.Web.Http;
using ApplicationModel;
using ApplicationModel.Db;
using System.Data.Entity;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Database.SetInitializer(new DatabaseInitializer());
            var dbContext = new ApplicationContext();
            dbContext.Database.Initialize(false);
        }
    }
}
