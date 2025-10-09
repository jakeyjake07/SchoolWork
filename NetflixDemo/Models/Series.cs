using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixDemo.Models
{
    class Series : MediaType
    {
        public int Seasons { get; private set; }
        public Series(string title, string genre, int releaseYear, int seasons) : base(title, genre, releaseYear)
        {
            Seasons = seasons;
        }

        public override void Play()
        {
            System.Console.WriteLine($"Now playing series: {Title} - {Seasons} seasons");
        }
    }
}