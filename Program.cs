using System.Text.Json;

namespace Login
{
    public class inputClient
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public int LengthUser, LengthPassword;
    }
    class Client
    {
        static void Main()
        {
            inputClient client = new inputClient();
            Console.WriteLine("Your Username : ");
            client.Username = Console.ReadLine();

            Console.WriteLine("Your Password : ");
            client.Password = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(client.Username.Length + "_" + client.Username + " " + client.Password.Length + "_" + client.Password);
            string jsonString = JsonSerializer.Serialize(client);

            Console.WriteLine(jsonString);
            Console.ReadLine();
            StreamWriter sw = new StreamWriter("D:\\GameTech\\Matkul\\Pemrograman Jaringan Komputer\\Data.json");
            sw.WriteLine(jsonString);
            sw.Close();

            string fileName = "D:\\GameTech\\Matkul\\Pemrograman Jaringan Komputer\\Data.json";
            string json = File.ReadAllText(fileName);
            inputClient client2 = JsonSerializer.Deserialize<inputClient>(json);
            Console.WriteLine($"username: {client2.Username}");
            Console.WriteLine($"Password: {client2.Password}");
         
        }
    }
}