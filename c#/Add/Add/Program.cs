internal class Program
{

    static int sum;
    static void Main(string[] args)
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        float s = (a + b + c) / 2;

        float d = s*(s-a)*(s-b)*(s-c);

        Console.WriteLine(Math.Sqrt(d));
    }

}