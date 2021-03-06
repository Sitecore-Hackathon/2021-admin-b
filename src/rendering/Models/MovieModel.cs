using Sitecore.AspNet.RenderingEngine.Binding.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenderingHost.Models
{
    public class MovieModel
    {
        [SitecoreComponentField]
        public String Intro { get; set; }

        [SitecoreComponentField]
        public String RecommendedText { get; set; }

        public Movie[] Movies { get; set; }
    }

    public class Movie
    {
        public string Title { get; set; }

        public string Year { get; set; }

        public string Runtime { get; set; }

        public string Description { get; set; }

        public string Actors { get; set; }

        public string Image { get; set; }

        public string ID { get; set; }
    }
}
