using System;

namespace ChangeBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int temp = a; 
            a = b; b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}