using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        int sum = 0;
        Console.Write("정수를 입력:");
        int inputNum = int.Parse(Console.ReadLine());

        while (inputNum != 0)
        {
            Console.WriteLine("입력된 종합");
            sum += inputNum;
            Console.WriteLine(sum);

            Console.Write("정수를 입력:");
            inputNum = int.Parse(Console.ReadLine());
        } 
    }
}