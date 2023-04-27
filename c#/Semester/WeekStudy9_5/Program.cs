internal class Program
{
    class Test
    {
        public void Print()
        {
            Console.WriteLine("Print 출력");
        }
    }
    private static void Main(string[] args)
    {
        Test test = new Test();
        test.Print();
        test.Print();
        test.Print();
    }
}