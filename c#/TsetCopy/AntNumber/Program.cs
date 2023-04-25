using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string str = "1";
        int n = 1;
        while (n <= 20)
        {
            Console.WriteLine(n + "번째 수열:" + str);

            char to = str[0];
            int cnt = 0;
            string temp = "";
            for(int i = 0; i<str.Length; i++)
            {
                if(to == str[i])
                cnt++;
                else
                {
                    temp = temp + to + cnt;
                    cnt = 0;
                    to = str[i];
                    cnt++;
                }
                if(i+1 == str.Length)
                    temp = temp + to + cnt;
            }
            str = temp;
            n++;
        }
    }
}