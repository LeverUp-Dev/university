internal class Program
{
    private static void Main(string[] args)
    {
        
        Random r = new Random();
        int n = r.Next(6) +1;
        int n2 = r.Next(6) + 1;
        Console.WriteLine(n+n2);
   
    }
}
