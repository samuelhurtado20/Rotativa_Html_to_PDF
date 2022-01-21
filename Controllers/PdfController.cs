using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using Rotativa_Html_to_PDF.Models;
using System.Collections.Generic;

namespace Rotativa_Html_to_PDF.Controllers
{
    public class PdfController : Controller
    {
        public IActionResult Index()
        {
            var movies = new Movies
            {
                Action = new List<Movie>
                {
                    new Movie("Fast And furious", 2017, "Action"),
                    new Movie("The Tomorrow War", 2021, "Action"),
                    new Movie("Red notice", 2021, "Action")
                },

                Thriller = new List<Movie>
                {
                    new Movie("Ice road", 2021, "Thriller"),
                    new Movie("Blood red sky", 2021, "Thriller"),
                    new Movie("Don't breathe 2", 2021, "Thriller")
                }
            };

            return new ViewAsPdf("Index", movies)
            {

            };
        }
    }
}
