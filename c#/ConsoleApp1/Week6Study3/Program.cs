internal class Program
{
    private static void Main(string[] args)
    {
        Random ran = new Random();
        int x, y;

        Console.Clear();
        while (true) { 
        for(int i = 0; i < 20; i++)
        {
            x = ran.Next(50);
            y = ran.Next(20);
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*");
        }
        Thread.Sleep(4000);
        Console.Clear();
        }
    }
}