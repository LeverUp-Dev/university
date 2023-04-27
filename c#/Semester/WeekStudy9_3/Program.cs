using System.Reflection;

internal class Program
{
    class Student
    {
        public string name;
        public int grade;
    }
    private static void Main(string[] args)
    {
        List<Student> list = new List<Student>();
        list.Add(new Student() { name = "홍길동", grade = 1 });
        list.Add(new Student() { name = "김헬창", grade = 2 });
        list.Add(new Student() { name = "이말년", grade = 2 });
        list.Add(new Student() { name = "개페급", grade = 3 });
        list.Add(new Student() { name = "엄준식", grade = 1 });

        //for(int i =  0; i < list.Count-1; i++)
        //{
        //    if (list[i].grade > 1)
        //    {
        //        list.RemoveAt(i);
        //    }
        //}

        for(int i = list.Count - 1; i >= 0; i--)
        {
            if (list[i].grade > 1)
            {
                list.RemoveAt(i);
            }
        }

        foreach (var item in list)
        {
            Console.WriteLine(item.name + ":" + item.grade);
        }

    }
}