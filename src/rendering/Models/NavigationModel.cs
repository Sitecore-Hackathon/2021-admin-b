using System.Collections.Generic;
using Sitecore.AspNet.RenderingEngine.Binding.Attributes;

namespace RenderingHost.Models
{
    public class NavigationModel
    {
        [SitecoreComponentField]
        public string Title { get; set; }

        [SitecoreComponentField]
        public string Url { get; set; }

        [SitecoreComponentField]
        public IEnumerable<NavigationModel> Children { get; set; }
    }
}
