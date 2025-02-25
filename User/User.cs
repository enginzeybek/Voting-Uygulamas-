public class User
{
    private static List<string> registeredUsers = new List<string>();
    public static string UserKnowing()
    {
        Console.Write("Kullanıcı Adınız:");

        string UserName = Console.ReadLine()?.Trim();

        Console.Write("Şifreniz:");

        string Password = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(UserName) || string.IsNullOrWhiteSpace(Password))
        {
            Console.WriteLine("GEÇERLİ GİRİŞ YAPINIZ");
            return UserKnowing();
        }

        string fullUser = UserName + Password;

        if (!registeredUsers.Contains(fullUser))
        {
            Console.WriteLine("Yeni kullanıcı tespit edildi, kayıt yapılıyor...");
            registeredUsers.Add(fullUser);
        }
        else
        {
            Console.WriteLine("Hoş geldin, " + UserName + "!");
        }

        return fullUser;
    }   
    
}
    