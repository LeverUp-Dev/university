using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Week11Study1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("14하5099");
            Box my = new Box();
            Console.WriteLine(my.Id);

            car.SetInTime();
            car.Park();
            car.SetOutTime();
            car.FeeSettle();
            Console.WriteLine(MyLibrary.Add(3, 5));
            Console.WriteLine(MyLibrary.Add(2.2, 4.4));
            Console.WriteLine(MyLibrary.Add("He", "llo"));
        }

    }
    class Box
    {
        //propull 탭 두 번
        //prop 탭 두 번
        private int id = 5;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }

    class MyLibrary
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(string a, string b)
        {
            return a + b;
        }
    }
    class Car
    {
        private String carNumber;
        private int time;
        DateTime inTime;
        DateTime outTime;
        string car;

        public Car(String inCarNumber)
        {
            carNumber = inCarNumber;
        }
        public void SetInTime()
        {
            inTime = DateTime.Now;
        }
        public void Park()
        {
            Random rand = new Random();
            Thread.Sleep(1000);
        }
        public void SetOutTime()
        {
            outTime = DateTime.Now;
            Console.WriteLine($"번호가 '{carNumber}'가 되는 차량이 {outTime}까지 이용하셨습니다.");
        }
        public void FeeSettle()
        {
            TimeSpan period = outTime - inTime;
            if (period.Milliseconds < 100) Console.WriteLine("비용은 1000원 되겠습니다");
            else if (period.Milliseconds < 200) Console.WriteLine("비용은 2000원 되겠습니다");
            else Console.WriteLine("비용은 3000원 되겠습니다");
        }
    }
}
