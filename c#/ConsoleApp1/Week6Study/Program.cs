internal class Program
{
    private static void Main(string[] args)
    {
        float r = float.Parse(Console.ReadLine());

        int round = My_Round(r);
        double round2 = Math.Round(r);

        Console.WriteLine($"{round}, {round2}");
    }

    private static int My_Round(float r)
    {
        float iR = r - (int)r;

        if (r >= 0)
        {
            Console.WriteLine(iR.ToString("0.0"));
            if (iR < 0.5)
            {
                return (int)r;
            }
            else
            {
                return (int)r + 1;
            }
        }
        else
        {
            Console.WriteLine(iR.ToString("0.0"));
            if (iR < -0.5)
            {
                return (int)r - 1;
            }
            else
            {
                return (int)r;
            }
        }
    }
}