using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RenderingHost;
using Sitecore.Abstractions;
using Sitecore.Data.Items;
using Sitecore.LayoutService.Configuration;
using Sitecore.LayoutService.ItemRendering.ContentsResolvers;
using Sitecore.Mvc.Presentation;

namespace Examples.MovieService
{
    public class MovieContentsResolver : RenderingContentsResolver
    {
        public MovieContentsResolver()
        { 
        }

        public override object ResolveContents(Rendering rendering, IRenderingConfiguration renderingConfig)
        {
            var contextItem = GetContextItem(rendering, renderingConfig);
            var movieFolder = contextItem["Movie Location"];

            if (String.IsNullOrEmpty(movieFolder))
            {
                movieFolder = "/sitecore/content/movies";
            }

            var rootItem = Sitecore.Context.Database.GetItem(movieFolder);
            var movies = GetMovies(rootItem);
            return new
            {
                Movies = movies
            };
        }

        private IEnumerable<object> GetMovies(Item parent)
        {
            return parent.Children
                .Where(item => item.TemplateName == "Movie")
                .Select(item => new
                {
                    Title = item["Title"],
                    Actors = item["Actors"],
                    Image = item["Image"],
                    ID = item.ID.ToString()
                });
        }
    }
}

