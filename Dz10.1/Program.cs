using System;
using System.Xml.Linq;

namespace Dz10._1
{
    public delegate void account(string message);
    public class Account
    {
        public event account accountShow;
        public string Name {  get; private set; }
        public string Password {  get; private set; }
        public int Age {  get; private set; }
        public int H {  get; private set; }
        public int M {  get; private set; }
        public Account(string name, string password, int age, int h, int m)
        {
            Name = name;
            Password = password;
            Age = age;
            H = h;
            M = m;
        }
        public bool LoginUser(string name, string password)
        {
            if (name == Name && password == Password)
            {
                return true;
            }
            return false;
        }
        public void ShowInfo()
        {
            ConsoleKeyInfo key;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            key = Console.ReadKey();
            if (key.Key == ConsoleKey.I)
            {
                Console.WriteLine();
                accountShow?.Invoke($"Name: {Name}\nPassword: {Password}\nAge: {Age}\nHeight: {H}\nWeight: {M}");
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Vitaliy", "123qw", 15, 183, 86);
            account1.accountShow += (message) =>
            {
                Console.WriteLine(message);
            }; 
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Password: ");
            string Password = Console.ReadLine();
            if (account1.LoginUser("Vitaliy", "123qw"))
            {
                account1.ShowInfo();
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
