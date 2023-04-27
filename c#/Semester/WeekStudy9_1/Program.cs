internal class Program
{
    class User //User이라는 클래스 선언
    {
        public string name; //인스턴스 변수 5개 선언
        public string password; //변수의 사용법: 접근제한자 자료형 변수이름
        public string address;
        public string phoneNuber;
        public DateTime regDate; // DateTime은 시간을 표시하는 상수이다.
    }
    class Product
    {
        public string name = "default";// 인스턴스 변수 선언 후 초기화
        public int price = 1000;
    }
    public class Student 
    {
        public string id;
        public string name;
        public int grade;
        public string major;
        public DateTime birthday;
        private bool gender;

        public void Study()
        {
            Console.WriteLine("Programing study~~~~~");
        }
    }
    private static void Main(string[] args)
    {
        Product product1 = new Product() {name = "고구마", price = 2000};
        Product product2 = new Product() {name = "감자", price=1500};

        Student std1 = new Student() {id = "20231234", grade = 90};
    }
}