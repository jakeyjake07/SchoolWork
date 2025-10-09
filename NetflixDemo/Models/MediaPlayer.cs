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
            new Movie("Interstellar", "Sci-fi", 2014, 150),
            new Series("The Sopranos", "Drama", 1999, 9),
            new Documentary("Life of a potato", "Tradgedy", 2026, "From seed to potato"),
            new Movie("The Dark Knight", "Action", 2008, 152),
            new Series("The Wire", "Crime", 2002, 6),
            new Documentary("Death of a potato", "Comedy", 2023, "From potato to compost"),
            new Movie("Scary Movie", "Comedy", 2000, 97),
            new Series("Demon Slayer", "Anime", 2019, 5),
            new Documentary("Planet Earth", "Nature", 2000, "From seed to planet"),
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
            System.Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

        }

        private static void ListAll()
        {
            System.Console.WriteLine("--- Media List ---");
            foreach (MediaType m in db)
            {
                System.Console.WriteLine(m.GetSummary());

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

    }

}