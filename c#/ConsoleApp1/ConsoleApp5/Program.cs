internal class Program
{
    private static void Main(string[] args)
    {
        int x = 0, y = 0;
        Console.CursorVisible = false;
        while (true)
        {
            ConsoleKeyInfo c = Console.ReadKey();

            
            switch (c.Key)
            {
                case ConsoleKey.LeftArrow:
                    x--;
                    if (x < 0) { x = 0; }
                    break;
                case ConsoleKey.RightArrow:
                    x++;
                    break;
                case ConsoleKey.UpArrow:
                    if (y < 0) { y = 0; }
                    y--;
                    break;
                case ConsoleKey.DownArrow:
                    y++;
                    break;
                default: break;
            }
            Console.SetCursorPosition(x, y);
            Console.WriteLine("*"); 
        }


    }
}