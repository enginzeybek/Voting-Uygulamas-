public class Program
{
    static List<string> users = new List<string>(); // Kullanıcı listesi
    public static void Main(string[] args)
    {
        Console.WriteLine("📢 Voting Uygulamasına Hoşgeldiniz!");
        
        // Kullanıcı giriş yapacak
            
            string user = User.UserKnowing();

            if (!users.Contains(user))
            {
                users.Add(user);
                Console.WriteLine("✅ Yeni kullanıcı kaydedildi!");
            }
            else
            {
                Console.WriteLine("✅ Kullanıcı girişi başarılı!");
            }

            while (true)
            {
                Console.WriteLine("\n📌 Oylamak istediğiniz kategoriyi seçin:");
                Console.WriteLine("1 - 🎨 Sanat");
                Console.WriteLine("2 - 🎬 Film");
                Console.WriteLine("3 - ⚽ Spor");
                Console.WriteLine("4 - 🔚 Oylamayı Bitir ve Sonuçları Göster");

                Console.Write("Seçiminiz: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Art.ShowList();
                        Art.Vote();
                        break;
                    case "2":
                        Movie.ShowList();
                        Movie.Vote();
                        break;
                    case "3":
                        Sport.ShowList();
                        Sport.Vote();
                        break;
                    case "4":
                        ShowResults();
                        return; 
                    default:
                        Console.WriteLine("⚠ Geçersiz seçim! Lütfen 1-4 arasında bir değer girin.");
                        break;
                }
            }
    }

    static void ShowResults()
        {
            Console.WriteLine("\n📊 OYLAMA SONUÇLARI:");

            Art.ShowResults();
            Movie.ShowResults();
            Sport.ShowResults();

            Console.WriteLine("\n📢 Oylama tamamlandı! Çıkış yapılıyor...");
        }
}