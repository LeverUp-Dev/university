internal class Program
{
    //개미수열
     static void Main(string[] args)
    {
         string str = "1";
        for(int i  = 0; i < 10; i++) {
            Console.WriteLine((i+1) + "번째:" + str);
            str = Anseries(str);
        }
    }
    public static string Anseries(string str)
    {
        char what = str[0];
        String temp = "";
        int cnt = 0;
        for (int j = 0; j < str.Length; j++)
        {
            if (what == str[j])
            {
                cnt++;
            }
            else
            {
                temp = temp + what + cnt;
                what = str[j];
                cnt = 1;
            }
             
        }
        temp = temp + what + cnt;
        return temp;
    }
}