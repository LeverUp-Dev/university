internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("R을 입력하시오.");
        int r = int.Parse(Console.ReadLine());
        FindN(r);
    }
    static void FindN(int n)
    {
        int sum = 1, cnt = 1;
        while (sum < n)
        {
            cnt++;
            sum += cnt;
        }
        Console.WriteLine("N은 {0}입니다", cnt-1);
    }
}