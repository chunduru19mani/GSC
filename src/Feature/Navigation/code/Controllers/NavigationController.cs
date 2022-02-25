using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GSC.Feature.Navigation.Repositories;

namespace GSC.Feature.Navigation.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        public ActionResult PrimaryNavigation()
        {
            
            var NavigationRoot = Sitecore.Context.Database.GetItem(Templates.Root.ID);
            var PrimaryNavigation = NavigationRepository.GetNavigationList(NavigationRoot);
            return View("PrimaryNavigation", PrimaryNavigation);
        }
    }
}