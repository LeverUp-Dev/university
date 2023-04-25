
using System.Runtime.CompilerServices;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        /*for(int i=0; i<10;  i+=2) 
        {
            Console.WriteLine(i);
        }*/
        //배열
        /*int num = 3;
        Int32 nn = new Int32();

        string s1 = "h"; //파란색은 키워드.
        String s2 = "h"; //초록색은 클래스.*/


        /*int[] ns = new int[10];
        for (int i = 0; i < 10; i++)
        {
            ns[i] = i+1;
            Console.WriteLine(ns[i]);
        }*/

        //*탑 만들기
        Console.Write("별탑의 높이:");
        int len = int.Parse(Console.ReadLine());
        for (int i = 1; i<=len; i++) // 1
        { 
            for (int j=1; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        } 
        for (int i=1; i <= len; i++) //2
        {
            for (int j = len-i; j > 0; j--) 
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++) {
                Console.Write("*");
            }

            Console.WriteLine("");
        } 
        for(int i=1; i<=len;  i++)
        {
            for(int j=len; j>i; j--)
            {
                Console.Write(" ");
            }
            for(int s=1; s<i*2; s++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //2의0승부터10승까지 출력
        /*
        double sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            double pow = Math.Pow(2, i);
            Console.WriteLine(pow);
            sum += pow;
        }
        Console.WriteLine(sum);*/

        //입력 값이 0이 아닐 시 매번 총합을 출력

        /*
        int input = int.Parse(Console.ReadLine());
        int s = 0;
        while (input != 0)
        {
            s += input;
            Console.WriteLine(s);
            input = int.Parse(Console.ReadLine());
        }  */
        /*
        int[] nums = { 32, 34, 36, 38, 40 };

        int ans = Min(nums);
        Console.WriteLine(ans); */

    }
    private static int Min(int[] nums) 
    {
        int min = nums[0];
        for(int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i]) 
            {
                min = nums[i];
            }
        }
        return min;
    }
}