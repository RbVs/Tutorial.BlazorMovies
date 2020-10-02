using System;
using System.Collections.Generic;
using Tutorial.BlazorMovies.Shared.Entities;

namespace Tutorial.BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Title = "Spiderman: Far from Home", 
                    ReleaseDate = new DateTime(2019, 7, 2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjMyOTM4MDMxNV5BMl5BanBnXkFtZTcwNjIyNzExOA@@._V1_SY1000_CR0,0,674,1000_AL_.jpg"

                },
                new Movie
                {
                    Title = "Moana", 
                    ReleaseDate = new DateTime(2016, 11, 23),
                    Poster = "https://m.media-amazon.com/images/M/MV5BNWFkN2E3ZDYtYmVlMy00N2YyLWI1NzQtOTRlZmYyYmQ1MzRjXkEyXkFqcGdeQXVyMjI2NzcyNDk@._V1_SY1000_SX1000_AL_.jpg"
                },
                new Movie
                {
                    Title = "Inception", 
                    ReleaseDate = new DateTime(2010, 7, 16),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_SY1000_CR0,0,675,1000_AL_.jpg"
                }
            };
        }
    }
}