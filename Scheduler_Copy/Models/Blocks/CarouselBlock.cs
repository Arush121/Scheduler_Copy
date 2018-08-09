using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Scheduler_Copy.Models.Blocks
{
    [ContentType(DisplayName = "CarouselBlock", GUID = "70bb5ab2-942a-4ea5-af36-40664e6b643a", Description = "")]
    public class CarouselBlock : BlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}