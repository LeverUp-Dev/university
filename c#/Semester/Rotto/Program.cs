internal class Program
{
    private static void Main(string[] args)
    {
        Random ran = new Random();
        Console.WriteLine("로또");
        int[] rottoNum = new int[6];

        for (int i = 0; i < 6; i++)
        {
            rottoNum[i] = ran.Next(45) + 1;
            for (int j = 0; j < i; j++)
            {
                if (rottoNum[i] == rottoNum[j])
                    i--;
            }
            Console.Write(rottoNum[i] + " ");
        }
    }
}