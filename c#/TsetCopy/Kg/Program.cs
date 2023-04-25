using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Kg 입력:");
        double kg = double.Parse(Console.ReadLine());

        double pound = 2.20462262262f;

        double changeP = kg * pound;
        Console.WriteLine(kg + "Kg은 " + changeP + "pound 입니다.");
    }
}