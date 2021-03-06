using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feature.Movies.Models
{
    public class MovieModel
    {
        public String Intro { get; set; }

        public String RecommendedText { get; set; }

        public List<Movie> Movies { get; set; }

        public MovieModel()
        {
            var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
            var dataSource = Sitecore.Context.Database.GetItem(dataSourceId);

            Intro = dataSource?["Intro"];
            RecommendedText = dataSource?["RecommendedText"];

            var movieFolder = "/sitecore/content/Global/Movies";

            var rootItem = Sitecore.Context.Database.GetItem(movieFolder);
            Movies = GetMovies(rootItem).ToList();
        }

        public IEnumerable<Movie> GetMovies(Item parent)
        {
            return parent.Children
                .Where(item => item.TemplateName == "Movie")
                .Select(item => new Movie
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
