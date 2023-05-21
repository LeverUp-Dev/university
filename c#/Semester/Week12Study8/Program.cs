internal class Program
{
    private static void Main(string[] args)
    {
        bool isSoSu = true;
        Console.Write("정수 입력: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 2; i < num; i++)//2부터 n-1까지 나누어서 떨어지면 소수 아님
        {
            if(num%i == 0)
            {
                isSoSu = false;
            }
        }

        if (!isSoSu || num < 2)//입력된 정수가 1이하 이거나 2와 n-1로까지의 수로 나누어 질 때 
        {
            Console.WriteLine("소수가 아닙니다.");
        }
        else
        {
            Console.WriteLine("소수입니다.");
        }                       
    }
}