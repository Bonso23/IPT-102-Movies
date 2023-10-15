using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
                    new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama" }, 
            new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller"  },
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
            new MovieViewModel { Id = 4, Name = "Moana", Rating = "8", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 5, Name = "The Nun", Rating = "5", ReleaseYear = 2018, Genre = "Horror" },
            new MovieViewModel { Id = 6, Name = "The Croods", Rating = "7", ReleaseYear = 2014, Genre = "Adventure" },
            new MovieViewModel { Id = 7, Name = "The Croods New Age", Rating = "8", ReleaseYear = 2020, Genre = "Action" },
            new MovieViewModel { Id = 8, Name = "Dream", Rating = "7", ReleaseYear = 2023, Genre = "Comedy" },
            new MovieViewModel { Id = 9, Name = "Polite Society", Rating = "7", ReleaseYear = 2023, Genre = "Action" },
            new MovieViewModel { Id = 11, Name = "Spy", Rating = "8", ReleaseYear = 2023, Genre = "Fantasy" },
            new MovieViewModel { Id = 12, Name = "Extraction", Rating = "5", ReleaseYear = 2020, Genre = " Action/Thriller" },
            new MovieViewModel { Id = 13, Name = "Lost in Time", Rating = "5", ReleaseYear = 2019, Genre = "Adventure" },
            new MovieViewModel { Id = 14, Name = "Avatar", Rating = "5", ReleaseYear = 2007, Genre = "Adventure" },
            new MovieViewModel { Id = 15, Name = "Frozen", Rating = "9", ReleaseYear = 2013, Genre = "Adventure" },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}