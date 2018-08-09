using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Scheduler_Copy.Models.Pages
{
    [ContentType(DisplayName = "SearchPage", GUID = "353aa67a-c022-49a9-b092-76e3179047f0", Description = "")]
    public class SearchPage : BasePage
    {
                [CultureSpecific]
                [Display(
                    Name = "Contain",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual String Contain { get; set; }
         
    }
}