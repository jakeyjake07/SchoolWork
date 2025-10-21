using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixDemo.Models
{
    internal class KidsMovie : Movie
    {
        public int RecommendedAge { get; private set; }
        public KidsMovie(string title, string genre, int releaseYear, int durationMinutes, string language, int recommendedAge) : base(title, genre, releaseYear, durationMinutes, language)
        {
            RecommendedAge = recommendedAge;
        }
       

        public override void Play()
        {
            System.Console.WriteLine($"Now playing kids movie: {Title} - Movie for kids ({RecommendedAge}+ years old)"); 
        }
    }
}