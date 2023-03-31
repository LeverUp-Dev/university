internal class Program
{
    private static void Main(string[] args)
    {
        int year = int.Parse(Console.ReadLine());

        LeapYear(year);
    }

    private static void LeapYear(int year)
    {
        if (year%4 == 0)
        {
            Console.WriteLine("평년");
        }
        else
        {
            Console.WriteLine("윤년");
        }
    }
}