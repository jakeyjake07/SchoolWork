using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixDemo.Models
{
    internal class Movie : MediaType
    {

        public int DurationMinutes { get; private set; }
        public Movie(string title, string genre, int releaseYear, int durationMinutes, string language) : base(title, genre, releaseYear, language)
        {
            DurationMinutes = durationMinutes;
        }

        public override void Play()
        {
            System.Console.WriteLine($"Now playing movie: {Title} ({DurationMinutes} minutes)");
        }
    }
}