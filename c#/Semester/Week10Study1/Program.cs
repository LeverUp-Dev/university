using System;
using System.Security.AccessControl;

class Point
{
    public int x;
    public int y;

}

class Student
{
    int id;
    void Study()
    {

    }

}

internal class Program
{
    private static void Main(string[] args)
    {
        //Point p1 = new Point();
        //p1.x = 3;
        //p1.y = 3;

        //Console.WriteLine("(" + p1.x + ", " + p1.y + ")");


        ////List 쓰는법
        //Point p1 = new Point();
        //p1.x = 3;
        //List<Point> plist = new List<Point>();
        //plist.Add(p1);

        //List<int> nlist = new List<int>() { 32, 4, 5, 77 };
        //nlist.Add(64);
        //nlist.Remove(32);

        //foreach (var i in nlist)
        //{
        //    Console.WriteLine(i);
        //}

        ////랜덤 쓰는법
        //Random rnd = new Random();
        //int a = rnd.Next(1, 6);
        //int b = rnd.Next(1, 6);
        //Console.WriteLine(a + b);

        //중간고사 기출문제 
        //Student s1 = new Student();
        //Student s2 = new Student();

        //List<Student> sList = new List<Student>();
        //sList.Add(s1);
        //sList.Add(s2);


        //float num = float.Parse(Console.ReadLine());
        //int ans = Round(num);
        //Console.WriteLine(ans);

        //역삼각형 만들기 
        //for (int i = 0; i < 5; i++)
        //{
        //    for(int j = 0; j < i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for(int k = 0; k < 9 - i*2; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        //중간고사 기출문제2
        //List<Student> sList = new List<Student>();

        

    }

    static int Round(float num)
    {
        float dp = num - (int)num;
        if(dp < 0.5)
        {
            return (int)num;
        }
        else
        {
            return (int)num + 1;
        }
    }

}