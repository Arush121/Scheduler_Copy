using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Scheduler_Copy.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "e4a08669-9ea0-4c90-9ecd-3afcda688d71", Description = "")]
    public class StandardPage : BasePage
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Standard Heading",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual String StandardHeading { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Standard MainBody",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual XhtmlString StandardMainBody { get; set; }

    }
}