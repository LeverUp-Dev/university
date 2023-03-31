using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            ConsoleKeyInfo c = Console.ReadKey();
            int n2 = int.Parse(Console.ReadLine());

            switch (c.Key)
            {
                case ConsoleKey.Add:
                case ConsoleKey.OemPlus:
                Console.WriteLine(n1 + n2); break;
                default: break; 
                    
            }
        }
    }
}