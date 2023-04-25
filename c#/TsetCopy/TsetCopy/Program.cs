using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("인치 입력:");
        int inchLen = int.Parse(Console.ReadLine());

        double changeCm = inchLen * 2.54;
        Console.WriteLine(inchLen + "인치는 " + changeCm + "입니다.");
    }
}