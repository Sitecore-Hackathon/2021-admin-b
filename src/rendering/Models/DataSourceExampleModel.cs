using Sitecore.LayoutService.Client.Response.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class DataSourceExampleModel
    {
        public TextField Title { get; set; }
        public RichTextField Body { get; set; }
        public ImageField Image { get; set; }
        public HyperLinkField Promo { get; set; }
        public DateField Date { get; set; }
    }
}
