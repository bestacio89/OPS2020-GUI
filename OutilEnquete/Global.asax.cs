using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.Routing;
namespace OutilEnquete
{
    public class MvcApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<Models.ApplicationDbContext>(null);
        }
    }
}
