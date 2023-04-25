internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("자연수 다섯개를 입력하시오.");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());

        int[] maxFind = { a, b, c, d, e };

        int max = maxFind.Max();
        Console.WriteLine("제일 큰 자연수는 " + max + "입니다.");
    }
}