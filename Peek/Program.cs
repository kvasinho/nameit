using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = args.Length > 0 ? args[0] : String.Empty;
            if (String.IsNullOrEmpty(name))
            {
                Console.WriteLine("So... Whats you name, you enigmatic guy? ");
                name = Console.ReadLine() ?? "Mister X";
            }
            
            Console.WriteLine($"Hello {name}");
           // Console.ReadLine();

        }
    }
}