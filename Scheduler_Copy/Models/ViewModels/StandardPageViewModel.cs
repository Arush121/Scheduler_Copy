using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using Scheduler_Copy.Models.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace Scheduler_Copy.Models.ViewModels
{
    public class StandardPageViewModel
    {
        public IEnumerable<StandardPage> ListOfArticles { get; set; }
        public StandardPage CurrentPage { get; set; }
    }


    public static class HtmlHelperExtensions
    {

        public static IHtmlString MenuList(
            this HtmlHelper helper,
            ContentReference rootLink,
            Func<MenuItem, HelperResult> itemTemplate)
        {
            var currentContentLink = helper.ViewContext.RequestContext.GetContentLink();
            var contentLoader = ServiceLocator.Current.GetInstance<IContentLoader>();
            var filterForVisitor = new FilterContentForVisitor();

            var pagePath = contentLoader.GetAncestors(currentContentLink)
                .Reverse()
                .Select(x => x.ContentLink)
                .SkipWhile(x => !x.CompareToIgnoreWorkID(rootLink))
                .ToList();

            var menuItems = contentLoader.GetChildren<PageData>(rootLink)
                .Where(page => !filterForVisitor.ShouldFilter(page) && page.VisibleInMenu)
                .Select(page => new MenuItem
                {
                    Page = page,
                    Selected = page.ContentLink.CompareToIgnoreWorkID(currentContentLink) ||
                                    pagePath.Contains(page.ContentLink)
                }
                )
                .ToList();

            var buffer = new StringBuilder();
            var writer = new StringWriter(buffer);
            foreach (var menuItem in menuItems)
            {
                itemTemplate(menuItem).WriteTo(writer);
            }

            return new MvcHtmlString(buffer.ToString());
        }

        public class MenuItem
        {
            public PageData Page { get; set; }
            public bool Selected { get; set; }
        }

    }
}