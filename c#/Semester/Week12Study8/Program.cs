internal class Program
{
    private static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());
        bool isPrime = true;
        Console.WriteLine(CheckPrime(inputNum, isPrime));
    }

    private static bool CheckPrime(int inputNum, bool isPrime)
    {
        if(inputNum >= 2)
        {
            for(int i = 2; i <= inputNum-1; i++)
            {
                if((inputNum%i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}