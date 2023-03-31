internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("가위 바위 보");
        int my = int.Parse(Console.ReadLine());

        Random r = new Random();
        int com = r.Next(1, 4);

        if (com == 1) Console.WriteLine("Draw");
        else if (com == 2) Console.WriteLine("Win");
        else if (com == 3) Console.WriteLine("Lose");
    }
}