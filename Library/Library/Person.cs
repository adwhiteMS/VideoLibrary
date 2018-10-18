using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        private List<Movie> ListOfMoviesPersonIsIn;

        public Person()
        {
            ListOfMoviesPersonIsIn = new List<Movie>();
        }

        public IEnumerable<Movie> GetMoviesPersonIsIn()
        {
            return ListOfMoviesPersonIsIn;
        }

        public void AddMovieToPerson(Movie movie)
        {
            ListOfMoviesPersonIsIn.Add(movie);
        }

        public bool RemoveMovieToPerson(Movie movie)
        {
            return ListOfMoviesPersonIsIn.Remove(movie);
        }
    }
}
