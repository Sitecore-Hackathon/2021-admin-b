using Feature.Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Project.Common.layouts
{
    public partial class Sample_Sublayout : System.Web.UI.UserControl
    {
        public String Intro { get; set; }

        public String RecommendedText { get; set; }

        public List<Movie> Movies { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            var model = new MovieModel();


            Intro = model.Intro;
            RecommendedText = model.RecommendedText;
            Movies = model.Movies;
        }

        protected void rptMoviesRepeater_bind(object sender, RepeaterItemEventArgs e)
        {
            Movie movie = (Movie)e.Item.DataItem;

            var litTitle = (Literal)e.Item.FindControl("litMovieTitle");
            var div = (HtmlGenericControl)e.Item.FindControl("divContainer");

            litTitle.Text = movie.Title;
            div.Attributes["style"] = $"background-image:url('{movie.Image}')";
            div.Attributes["data-actors"] = movie.Actors;
            div.Attributes["data-id"] = movie.ID.ToString();
            div.Attributes["data-title"] = movie.Title;
        }
    }
}