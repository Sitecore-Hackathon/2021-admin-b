using Sitecore.LayoutService.Client.Response.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderingHost.Models
{
    public class Banner
    {
        public TextField Title { get; set; }
        public TextField Background_Color { get; set; }
        public ImageField Background_Image { get; set; }
    }
}
