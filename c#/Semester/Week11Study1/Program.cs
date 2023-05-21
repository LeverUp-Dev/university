internal class Program
{
    class Car
    {
        string carNumber;
        DateTime inTime;
        DateTime outTime;

        string car;
        public Car(string nCar)
        {
            this.carNumber = nCar;
        }
        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }
        public void Park()
        {
            Random sc = new Random();
            int ran = sc.Next(301);

            Thread.Sleep(ran);
            
        }
        public void SetOutTime() 
        {
            this.outTime = DateTime.Now;
        }
        public void FeeSettle() 
        {
            Console.WriteLine(this.carNumber);
            TimeSpan period = this.outTime - this.inTime;
            Console.WriteLine(period.Milliseconds + "분");

            if(period.Milliseconds > 100)
            {
                Console.WriteLine("1000원");
            } else if(period.Milliseconds < 200)
            {
                Console.WriteLine("2000원");
            } else
            {
                Console.WriteLine("3000원");
            }

        }


    }

    private static void Main(string[] args)
    {
        Car car = new Car("14하 5099");
        Car car2 = new Car("434353252342");

        car2.SetInTime();
        car2.Park();
        car2.SetOutTime();
        car2.FeeSettle();
    }
}