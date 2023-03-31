namespace MyTest { 
internal class Program
  {
    private static void Main(string[] args)
    {
            Console.Write("길이을 입력:");
            int lenght = int.Parse(Console.ReadLine());
            Console.Write("높이를 입력:");
            int height = int.Parse(Console.ReadLine());

            Console.Write("넓이는:");
            Console.WriteLine(lenght * height);
    }
  }
}