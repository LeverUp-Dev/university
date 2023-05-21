internal class Program
{
        class MyLibrary
        {
            public static int Add(int x, int y)
            {
                return x + y;
            }
            public static double Add(double x, double y)
            {
                return x + y;
            }
            public static string Add(string x, string y)
            {
                return x + y;
            }
        }
    private static void Main(string[] args)
    {
        
        Console.WriteLine(MyLibrary.Add(3, 5));
        Console.WriteLine(MyLibrary.Add(3.5, 7.2));
        Console.WriteLine(MyLibrary.Add("흘러가는 대로", " 살자!"));
    }
}