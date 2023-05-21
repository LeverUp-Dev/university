internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("시작 수를 입력하시오.");
        int in1 = int.Parse(Console.ReadLine());
        Console.WriteLine("마침 수를 입력하시오.");
        int in2 = int.Parse(Console.ReadLine());

        for(int i = in1; i <= in2; i++)
        {
            Console.Write(i + " ");
        }
    }
}