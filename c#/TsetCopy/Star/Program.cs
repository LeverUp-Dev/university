internal class Program
{
    private static void Main(string[] args)
    {
        for(int i  = 0; i < 8; i++)
        {
            for (int j = 1; j < 8-i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < i*2+1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}