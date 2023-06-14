internal class Program
{

    class NumGuess
    {        
        public int answerNum;
        public int inputNum;

        public void FindNum()
        {
            Random r = new Random();
            answerNum = r.Next(100, 300);

            while (answerNum != inputNum) 
            {           
                Console.Write("숫자를 입력해주세요:");
                inputNum = int.Parse(Console.ReadLine());

                if (inputNum > answerNum)
                {
                    Console.WriteLine(inputNum + "보다는 작은 숫자입니다.");
                }
                else if (inputNum < answerNum)
                {
                    Console.WriteLine(inputNum + "보다는 큰 숫자입니다.");
                }
                
            }
            Console.WriteLine("정답입니다.");
        }
    }

    private static void Main(string[] args)
    {
        NumGuess numGuess = new NumGuess();
        numGuess.FindNum();
    }
}