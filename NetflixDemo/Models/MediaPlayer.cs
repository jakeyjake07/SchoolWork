using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetflixDemo.Models
{
    //Static class can not be instantiated
    static class MediaPlayer
    {
        private static List<MediaType> db = new List<MediaType>()
        {
            new Movie("Interstellar", "Sci-fi", 2014, 150, "English"),
            new Series("The Sopranos", "Drama", 1999, 9, "Italian"),
            new Documentary("Life of a potato", "Tradgedy", 2026, "From seed to potato", "English"),
            new Movie("The Dark Knight", "Action", 2008, 152, "Spanish"),
            new Series("The Wire", "Crime", 2002, 6, "English"),
            new Documentary("Death of a potato", "Comedy", 2023, "From potato to compost", "Portuguese"),
            new Movie("Scary Movie", "Comedy", 2000, 97, "Chinese"),
            new Series("Demon Slayer", "Anime", 2019, 5, "English"),
            new Documentary("Planet Earth", "Nature", 2000, "From seed to planet", "English"),
            new KidsMovie("Shrek", "Comedy", 2001, 90, "English", 3),
            new KidsMovie("Shrek 2", "Comedy", 2004, 90, "English", 3),
            new KidsMovie("Shrek 3", "Comedy", 2007, 90, "English", 3),
            new KidsMovie("Shrek 4", "Comedy", 2010, 90, "English", 3),
            new Movie("The Matrix", "Sci-fi", 1999, 150, "English"),
            new Series("Game of Thrones", "Drama", 2011, 8, "English"),
        };


        public static void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                switch (Console.ReadLine())
                {
                    case "1":
                        ListAll();
                        break;

                    case "2":
                        FilterByGenre();
                        break;

                    case "3":
                        SearchByTitle();
                        break;

                    case "4":
                        PlayMedia();
                        break;

                    case "5":
                        SearchByLanguage();
                        break;
                    case "6":
                        ListGenres();
                        break;

                    case "7":
                        OldestMedia();
                        break;

                    case "8":
                        SearchByRelease();
                        break;

                    case "0":
                        running = false;
                        break;

                    default:
                        System.Console.WriteLine("Invalid option.");
                        break;
                }

            }
        }

        private static void PrintMenu()
        {
            System.Console.WriteLine("--- Netflix Mini ---");
            System.Console.WriteLine("1. List all media");
            System.Console.WriteLine("2. Filter by genre");
            System.Console.WriteLine("3. Search by title");
            System.Console.WriteLine("4. Play a media");
            System.Console.WriteLine("5. Search by language");
            System.Console.WriteLine("6. List genres");
            System.Console.WriteLine("7. Oldest media");
            System.Console.WriteLine("8. Seach by release year");
            System.Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

        }

        private static void ListAll()
        {
            System.Console.WriteLine("--- Media List ---");
            foreach (var m in db)
            {
                System.Console.WriteLine(m.GetSummary() + " " + $"({m.GetAge()})");

            }

        }

        private static void FilterByGenre()
        {
            System.Console.WriteLine("Enter a genre to filter by: ");
            string genre = Console.ReadLine().ToLower();

            bool found = false;

            foreach (MediaType m in db)
            {
                if (m.Genre.ToLower() == genre)
                {
                    found = true;
                    System.Console.WriteLine(m.GetSummary());
                }

            }

            if (!found)
            {
                System.Console.WriteLine("No results found.");
            }
        }


        private static void SearchByTitle()
        {
            System.Console.WriteLine("Enter a title to search for: ");
            string title = Console.ReadLine().ToLower();
            bool found = false;

            foreach (MediaType m in db)
            {
                if (m.Title.ToLower() == title)
                {
                    found = true;
                    System.Console.WriteLine(m.GetSummary());
                    break;
                }
            }

            if (!found)
            {
                System.Console.WriteLine("No results found.");
            }
        }

        private static void PlayMedia()
        {
            System.Console.WriteLine("Enter a title to play: ");
            string title = Console.ReadLine().ToLower();
            bool found = false;

            foreach (MediaType m in db)
            {
                if (m.Title.ToLower() == title)
                {
                    found = true;
                    m.Play();
                    break;
                }
            }

            if (!found)
            {
                System.Console.WriteLine("No results found.");
            }
        }


        public static void GetUpperCaseTitle()
        {
            foreach (MediaType m in db)
            {
                System.Console.WriteLine(m.Title.ToUpper());
            }
        }



        public static void PrintMovies()
        {
            foreach (MediaType m in db)
            {
                if (m is Movie)
                {
                    System.Console.WriteLine(m.GetSummary());
                }
            }
        }

        public static void PrintSeries()
        {
            foreach (MediaType s in db)
            {
                if (s is Series)
                {
                    System.Console.WriteLine(s.GetSummary());
                }
            }
        }

        public static void PrintDocumentaries()
        {
            foreach (MediaType d in db)
            {
                if (d is Documentary)
                {
                    System.Console.WriteLine(d.GetSummary());
                }
            }
        }


        public static void LongSeries()
        {
            foreach (Series s in db)
            {
                if (s.Seasons > 3)
                {
                    System.Console.WriteLine(s.GetSummary());
                }
            }
        }


        public static void Documentaries()
        {
            foreach (Documentary d in db)
            {
                System.Console.WriteLine(d.GetSummary());
            }
        }

        public enum DramaCrime
        {
            Drama,
            Crime
        }


        public static void SearchByLanguage()
        {
            System.Console.WriteLine("Enter a language to search for: ");
            string language = Console.ReadLine().ToLower();
            bool found = false;

            foreach (MediaType m in db)
            {
                if (m.Language.ToLower() == language)
                {
                    found = true;
                    System.Console.WriteLine(m.GetSummary());
                }
            }

            if (!found)
            {
                System.Console.WriteLine("No results found.");
            }
        }


        public static void ListGenres()
        {
            System.Console.WriteLine("--- Genres ---");
            var genres = new List<string>();

            foreach (MediaType m in db)
            {
                if (!genres.Contains(m.Genre))
                    System.Console.WriteLine(m.Genre);
                genres.Add(m.Genre);
            }
        }

        public static void IsLongerThan120()
        {
            foreach (Movie m in db)
            {
                if (m.DurationMinutes > 120)
                {
                    System.Console.WriteLine(m.GetSummary());
                }
            }
        }

        public static void OldestMedia()
        {

            MediaType oldest = null;

            foreach (MediaType m in db)
            {
                if (oldest == null || m.ReleaseYear < oldest.ReleaseYear)
                {
                    oldest = m;
                }
            }

            if (oldest != null)
            {
                System.Console.WriteLine(oldest.GetSummary());
            }
            else
            {
                System.Console.WriteLine("No results found.");
            }

        }


        public static void SearchByRelease()
        {
            System.Console.WriteLine("Enter a release year to search for: ");
            int year = int.Parse(Console.ReadLine());
            

            foreach (MediaType m in db)
            {
                if (m.ReleaseYear == year)
                {
                    
                    System.Console.WriteLine(m.GetSummary());
                }
            }

        }




    }
}