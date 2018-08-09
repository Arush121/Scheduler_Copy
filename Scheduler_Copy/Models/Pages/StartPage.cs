using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Scheduler_Copy.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "c207ccf0-6354-4b18-a1da-ee39ad0d4b1c", Description = "")]
    public class StartPage : BasePage
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Start Heading",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual String StartHeading { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Start MainBody",
           Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual XhtmlString StartMainBody { get; set; }

    }
}