using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Abstractions;
using Sitecore.Data.Items;
using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering.ContentsResolvers;
using Sitecore.Mvc.Presentation;

namespace MyProject.LayoutService
{
    public class NavigationContentsResolver : RenderingContentsResolver
    {
        private const int NavigationDepth = 2;

        private readonly BaseLinkManager _linkManager;

        public NavigationContentsResolver(BaseLinkManager linkManager)
        {
            _linkManager = linkManager;
        }

        public override object ResolveContents(Rendering rendering, IRenderingConfiguration renderingConfig)
        {
            var contextItem = GetContextItem(rendering, renderingConfig);
            var siteRoot = contextItem?.Axes.GetAncestors().FirstOrDefault(item => item.DescendsFrom(Templates.SiteRoot.Id));
            if (siteRoot == null)
            {
                return new
                {
                    title = "SiteRoot is null",
                    url = "/",
                    children = new List<object>()
                };
            }

            // First page under our site root should be Home
            var children = GetNavigation(siteRoot, NavigationDepth).FirstOrDefault();

            return new
            {
                Title = "Home",
                Url = "/",
                Children = children,
            };
        }

        private IEnumerable<object> GetNavigation(Item parent, int depth)
        {
            depth--;
            return parent.Children
              .Where(item => item.DescendsFrom(Templates.Page.Id))
              .Select(item => new
              {
                  Title = item[Templates.Page.Fields.Title],
                  Url = _linkManager.GetItemUrl(item),
              });
        }
    }
}