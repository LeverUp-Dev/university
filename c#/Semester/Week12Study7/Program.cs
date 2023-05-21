using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("첫번째 문자열 입력:");
        string st1 = Console.ReadLine();
        Console.Write("두번째 문자열 입력:");
        string st2 = Console.ReadLine();

        bool choice = Strcmp(st1, st2);

        Console.WriteLine(choice);
    }
    static bool Strcmp(string str1, string str2)
    {
        if (str1.Length == str2.Length)
        {
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == str2[i])
                {
                    i++;
                }
                else
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

        return true;
    }
}