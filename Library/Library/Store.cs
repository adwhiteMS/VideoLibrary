using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Store
    {
        private List<Movie> Movies = new List<Movie>();

        public Movie CheckoutMovie(int MovieId)
        {
            var movie = Movies.SingleOrDefault<Movie>(x => x.MovieId == MovieId)
            if (movie == null)
            {
                throw new AccessViolationException("Movie doesn't exists!");
            }

            if (movie.Avaliable)
            {
                movie.Avaliable = false;
                return movie;
            }
            else
            {
                throw new AccessViolationException("Movie not avaliable!");
            }
        }

        public bool IsMovieAvaliable(int MovieId)
        {
            var movie = Movies.SingleOrDefault<Movie>(x => x.MovieId == MovieId)
            if (movie == null || !movie.Avaliable)
            {
                return false;
            }
            return true;
        }

        public IEnumerable<Movie> ListOfMovies()
        {
            return Movies;
        }

        public void AddMovieToList(Movie movie)
        {
            Movies.Add(movie);
        }

        public bool RemoveMovieToList(Movie movie)
        {
            return Movies.Remove(movie);
        }

    }
}
