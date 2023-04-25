using System.ComponentModel.Design;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {

        while (true) {
            Console.WriteLine("원의 둘레 구하기");
            Console.Write("반지름 입력:");

            double Pi = 3.14;

            double r = double.Parse(Console.ReadLine());
            double round = 2 * r * Pi;

            Console.WriteLine("원의 둘레는 " + round + "입니다.");

            Console.WriteLine("원의 넓이 구하기");
            Console.Write("반지름 입력:");

            double radius = double.Parse(Console.ReadLine());
            double area = radius * radius * Pi;

            Console.WriteLine("원의 넓이는 " + area + "입니다.");
            Console.WriteLine("종료하시겠습니까? 예/아니오");
      
                string end = Console.ReadLine();
                if (end == "예")
                {
                    break;
                }
                else if (end == "아니오")
                {
                    continue;
                }
                else if(end != "아니오")
            {
                Console.WriteLine("잘못된 입력입니다.");
                continue;
            }
        }
    }
}