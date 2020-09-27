using System.Collections.Generic;
using Tutorial.BlazorMovies.Shared.Entities;

namespace Tutorial.BlazorMovies.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}