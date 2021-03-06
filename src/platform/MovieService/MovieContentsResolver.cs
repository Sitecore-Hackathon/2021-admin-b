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

namespace HackPlatform.MovieService
{
    public class MovieContentsResolver : RenderingContentsResolver
    {
        public MovieContentsResolver()
        { 
        }

        public override object ResolveContents(Rendering rendering, IRenderingConfiguration renderingConfig)
        {
            var contextItem = GetContextItem(rendering, renderingConfig);

            var intro = contextItem?["Intro"];
            var recommendedText = contextItem?["RecommendedText"];

            var movieFolder = "/sitecore/content/Global/Movies";

            var rootItem = Sitecore.Context.Database.GetItem(movieFolder);
            var movies = GetMovies(rootItem);
            return new
            {
                Movies = movies,
                RecommendedText = recommendedText,
                Intro = intro
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
                    Runtime = item["Runtime"],
                    Year = item["Year"],
                    Description = item["Description"],
                    ID = item.ID.ToString()
                });
        }
    }
}

