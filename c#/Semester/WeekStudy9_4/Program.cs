internal class Program
{
    class Test 
    {
        public static int Add(int x, int y)
        {
        return x + y;
        }

        public static long Square(int x, int y)
        {
            int sum = 1;
            for(int i = 0; i < y; i++)
            {
                sum = sum * x;
            }
            return sum;
        }

        public static int Product(int x, int y)
        {
            return x * y;
        }

        public static float DivideA(int x, int y)
        {
            return (float)x / (float)y; ;
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Test.Add(4, 6));
        Console.WriteLine(Test.Square(2, 13));
        Console.WriteLine(Test.Product(4, 6));
        Console.WriteLine(Test.DivideA(25, 6));
    }
}