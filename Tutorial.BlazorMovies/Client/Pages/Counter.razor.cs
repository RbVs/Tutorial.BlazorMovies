using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Tutorial.BlazorMovies.Shared.Entities;

namespace Tutorial.BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] private SingletonService Singleton { get; set; }
        [Inject] private TransientService Transient { get; set; }

        private int currentCount;
        private List<Movie> _movies;

        protected override void OnInitialized()
        {
            _movies = new List<Movie>
            {
                new Movie {Title = "Joker", ReleaseDate = new DateTime(2019, 7, 2)},
                new Movie {Title = "Avengers", ReleaseDate = new DateTime(2016, 11, 23)},
            };
            base.OnInitialized();
        }

        private void IncrementCount()
        {
            currentCount++;

            Transient.Value = currentCount;
            Singleton.Value = currentCount;
        }
    }
}