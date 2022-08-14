using System;

namespace Hello_User
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(":) Please enter your First Name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + " " + "Welcome to C# practice with Kelebogile");
            Console.ReadLine();
        }
    }
}
