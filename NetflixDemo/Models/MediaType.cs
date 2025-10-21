using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixDemo.Models
{
    //Abstracted class can not be instantiated, meant to be inherited
    abstract class MediaType
    {
        //Encapsulation protects data so we can't change it by mistake
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public int ReleaseYear { get; private set; }
        public string Language { get; private set; }

        public MediaType(string title, string genre, int releaseYear, string language)
        {
            Title = title;
            Genre = genre;
            ReleaseYear = releaseYear;
            Language = language;
        }


        //Abstract method must be overriden
        public abstract void Play();

        //Virtual method can be overriden
        public virtual string GetSummary()
        {
            return $"{Title} ({ReleaseYear}) - {Genre} - {Language}";
        }

        public virtual string GetAge()
        {
            return $"{DateTime.Now.Year - ReleaseYear}" + " years since release.";
        }


    }
}