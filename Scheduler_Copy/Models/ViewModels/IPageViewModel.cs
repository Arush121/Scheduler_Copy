using EPiServer.Core;
using Scheduler_Copy.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scheduler_Copy.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : BasePage
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Section { get; set; }
    }
}