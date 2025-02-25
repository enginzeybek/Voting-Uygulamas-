public class Movie
{
    private static Dictionary<string, int> movieVotes = new Dictionary<string, int>
    {
        { "KING OF THE KINGS", 0 },
        { "PIRATES OF THE CARIBBEAN", 0 },
        { "MATRIX", 0 }
    };

    public static void ShowList()
    {
        Console.WriteLine("\n🎬 Film Kategorileri:");
        foreach (var movie in movieVotes.Keys)
        {
            Console.WriteLine("- " + movie);
        }
    }

    public static void Vote()
    {
        Console.Write("Lütfen oy vermek istediğiniz filmi yazın: ");
        string choice = Console.ReadLine()?.ToUpper().Trim();

        if (movieVotes.ContainsKey(choice))
        {
            movieVotes[choice]++;
            Console.WriteLine($"{choice} için oy verdiniz! ✅");
        }
        else
        {
            Console.WriteLine("⚠ Geçersiz seçim! Lütfen listeden bir film girin.");
        }
    }

    public static void ShowResults()
    {
        Console.WriteLine("\n🎬 Film Oylama Sonuçları:");
        foreach (var movie in movieVotes)
        {
            Console.WriteLine($"{movie.Key}: {movie.Value} oy");
        }
    }
}