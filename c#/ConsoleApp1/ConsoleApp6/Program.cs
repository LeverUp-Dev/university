using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("숫자를 입력하세요: ");
        double num = double.Parse(Console.ReadLine());
        Console.WriteLine("반올림 값: " + MyRound(num));
        Console.WriteLine("절대값: " + MyAbs(num));
    }

    static double MyRound(double num)
    {
        return Math.Round(num);
    }

    static double MyAbs(double num)
    {
        return Math.Abs(num);
    }
}
