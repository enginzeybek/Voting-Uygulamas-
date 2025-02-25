public class Sport
{
    private static Dictionary<string, int> sportVotes = new Dictionary<string, int>
    {
        { "FOOTBALL", 0 },
        { "BASKETBALL", 0 },
        { "VOLLEYBALL", 0 }
    };

    public static void ShowList()
    {
        Console.WriteLine("\n⚽ Spor Kategorileri:");
        foreach (var sport in sportVotes.Keys)
        {
            Console.WriteLine("- " + sport);
        }
    }

    public static void Vote()
    {
        Console.Write("Lütfen oy vermek istediğiniz spor dalını yazın: ");
        string choice = Console.ReadLine()?.ToUpper().Trim();

        if (sportVotes.ContainsKey(choice))
        {
            sportVotes[choice]++;
            Console.WriteLine($"{choice} için oy verdiniz! ✅");
        }
        else
        {
            Console.WriteLine("⚠ Geçersiz seçim! Lütfen listeden bir spor girin.");
        }
    }

    public static void ShowResults()
    {
        Console.WriteLine("\n⚽ Spor Oylama Sonuçları:");
        foreach (var sport in sportVotes)
        {
            Console.WriteLine($"{sport.Key}: {sport.Value} oy");
        }
    }
}