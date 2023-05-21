internal class Program
{
    static int[] num = new int[5];
    private static void Main(string[] args)
    {
        Input();
    }

    static void Input()
    {
        Console.WriteLine("배열의 요소들");
        for (int i = 0; i < num.Length; i++)
        {
            num[i] = i + 1;
            Console.Write(num[i] + " ");
        }
    }
}