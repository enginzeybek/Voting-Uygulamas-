public class Art
{
    private static Dictionary<string, int> artVotes = new Dictionary<string, int>
    {
        { "PICTORIAL ART", 0 },
        { "STATUE ART", 0 },
        { "MUSIC ART", 0 }
    };

    public static void ShowList()
    {
        Console.WriteLine("\n🎨 Sanat Kategorileri:");
        foreach (var art in artVotes.Keys)
        {
            Console.WriteLine("- " + art);
        }
    }

    public static void Vote()
    {
        Console.Write("Lütfen oy vermek istediğiniz sanat türünü yazın: ");
        string choice = Console.ReadLine()?.ToUpper().Trim();

        if (artVotes.ContainsKey(choice))
        {
            artVotes[choice]++;
            Console.WriteLine($"{choice} için oy verdiniz! ✅");
        }
        else
        {
            Console.WriteLine("⚠ Geçersiz seçim! Lütfen listeden bir sanat türü girin.");
        }
    }

    public static void ShowResults()
    {
        Console.WriteLine("\n🎨 Sanat Oylama Sonuçları:");
        foreach (var art in artVotes)
        {
            Console.WriteLine($"{art.Key}: {art.Value} oy");
        }
    }
}