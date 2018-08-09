using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Scheduler_Copy.Models.Blocks
{
    [ContentType(DisplayName = "CarouselBlockItem", GUID = "1dea80ea-9865-4725-9122-a3b3f8055a4f", Description = "")]
    public class CarouselBlockItem : BlockData
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