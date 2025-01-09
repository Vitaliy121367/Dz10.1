using System;

namespace Dz10._1
{
    public delegate void AccountEdit(string name, string password);
    public class Account
    {
        public event AccountEdit account;
        public string Name {  get; private set; }
        public string Password {  get; private set; }
        public Account(string name, string password)
        {
            Name = name;
            Password = password;
        }
        public bool LoginUser(string name, string password)
        {
            if (name == Name || password == Password)
            {
                return true;
            }
            return false;
        }
        public void ShowInfo()
        {
            ConsoleKeyInfo key;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            do
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.I)
                {

                }
            }
            while (key.Key != ConsoleKey.Escape);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                
            }
            else
            {

            }
        }
    }
}
