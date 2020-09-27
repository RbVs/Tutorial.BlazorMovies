using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Tutorial.BlazorMovies.Shared.Entities;

namespace Tutorial.BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] private SingletonService Singleton { get; set; }
        [Inject] private TransientService Transient { get; set; }
        [Inject] public IJSRuntime JsRuntime { get; set; }

        private int currentCount;

        private static int currentCountStatic;
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

        private async Task IncrementCount()
        {
            currentCount++;

            Transient.Value = currentCount;
            Singleton.Value = currentCount;

            currentCountStatic++;
            await JsRuntime.InvokeVoidAsync("dotnetStaticInvocation");
        }

        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}