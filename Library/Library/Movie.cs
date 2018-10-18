using System;
using System.Collections.Generic;

namespace Library
{
    public class Movie
    {
        public string Title { get; set; }

        public Person Director { get; set; }

        public List<Person> Actor { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int MovieId { get; set; }

        public bool Avaliable { get; set; }

    }
}
