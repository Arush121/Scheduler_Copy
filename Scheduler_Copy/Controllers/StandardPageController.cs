using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;
using Scheduler_Copy.Models.Pages;
using Scheduler_Copy.Models.ViewModels;

namespace Scheduler_Copy.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var repo = ServiceLocator.Current.GetInstance<IContentLoader>();

            // Load all article pages that are direct children to the current page.
            var pages = repo.GetChildren<StandardPage>(currentPage.ContentLink);

            // TODO: Add filter to hide unpublished pages and apply access control. 

            var model = new StandardPageViewModel
            {
                CurrentPage = currentPage,
                ListOfArticles = pages
            };
            return View(model);
        }
    }




}