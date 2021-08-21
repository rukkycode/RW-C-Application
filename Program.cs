using System;

namespace RW_C_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Strings
            string appname = "RW C# Application";
            string version = "1.0.0";

            // App Startup
            Console.WriteLine("Welcome to "+appname+" Version: "+version);

            Console.WriteLine(" _______");
            Console.WriteLine("|       |");
            Console.WriteLine("|       |");
            Console.WriteLine("|_______|");

            Console.WriteLine();
            Console.WriteLine("Whats your Player Name?");

            string playerName = Console.ReadLine();

            Console.WriteLine("Welcome to Rukky's World "+playerName+"!");
        }
    }
}
