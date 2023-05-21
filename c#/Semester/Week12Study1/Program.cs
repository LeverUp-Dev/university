internal class Program
{
    private static void Main(string[] args)
    {
        double sum = 0;

        for(int i = 0; i < 11; i++)
        {
            double result = Math.Pow(2, i);
            Console.WriteLine(result);
            sum += result;
        }
        Console.WriteLine("합 : {0}", sum);
    }
}