using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixDemo.Models
{
    class Documentary : MediaType
    {
        public string Topic { get; private set; }
        public Documentary(string title, string genre, int releaseYear, string topic) : base(title, genre, releaseYear)
        {
            Topic = topic;
        }

        public override void Play()
        {
            System.Console.WriteLine($"Streaming {Title} - documentary on ({Topic})");
        }

        public override string GetSummary()
        {
            return base.GetSummary() + $" Topic: {Topic}";
        }

    }
}