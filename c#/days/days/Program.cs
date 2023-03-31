internal class Program
{
    private static void Main(string[] args)
    {
        int days = int.Parse(Console.ReadLine());

        Console.WriteLine($"{days / 7}주 {days % 7}일");
    }
}