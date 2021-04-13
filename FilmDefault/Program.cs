using System;

namespace FilmDefault
{
    class Program
    {
        enum Genres { Action, Adventure, Comedy, Crime_and_mystery, Fantasy, Horror, Romance, Science_fiction, Thriller, Western, Other, Unknown }
        static void Main(string[] args)
        {
            FilmRuntime("The Matrix", Genres.Science_fiction, 120);
            FilmRuntime("The Matrix", Genres.Science_fiction);
            FilmRuntime("The Matrix", 120);
            FilmRuntime("The Matrix");
        }
        static void FilmRuntime(string title, Enum genre, int lenght = 90)
        {
            Console.WriteLine($"{title} ({lenght} minuten, {genre})");
        }
        static void FilmRuntime(string title, int lenght = 90)
        {
            FilmRuntime(title,  Genres.Unknown, lenght);
        }
    }
}
