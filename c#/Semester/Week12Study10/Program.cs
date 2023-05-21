internal class Program
{
    private static void Main(string[] args)
    {   //배열선언
        string[] animal = { "Cat", "Dog", "Horse" };
        //:를 animal배열 요소 사이마다 집어넣어 합침
        string animals = string.Join(":", animal);
        //animals를 출력
        Console.WriteLine(animals);
        //문자열의 모든 문자를 대문자로 변경
        string animalsUp = animals.ToUpper();
        //animalsUp를 :문자를 기ㅐ준으로 잘라 배열에 집어넣음  
        string[] str = animalsUp.Split(":");

        foreach(var item in str)
        {
            Console.WriteLine(item);
        }
    }
}