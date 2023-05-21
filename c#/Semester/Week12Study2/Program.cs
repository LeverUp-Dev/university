internal class Program
{
    private static void Main(string[] args)
    {
        Random r = new Random();

        Console.Clear();//콘솔화면의 모든것을 지운다.

        for (int i = 0; i < 20; i++)
        {
            int xR = r.Next(30);//x좌표
            int yR = r.Next(20);//y좌표
            Console.SetCursorPosition(xR, yR);//출력 위치 정한다
            Console.WriteLine("*");
            Thread.Sleep(300);//0.3초를 기다린다
        }
        Console.SetCursorPosition(0, 21);
    }
}