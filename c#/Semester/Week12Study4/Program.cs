internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 33, 5, 9, 23, 4, 6 };
        Min(nums);
    }

    private static void Min(int[] nums)
    {
        int min = nums[3];

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
            else
            {
                min = min;
            }            
        }
        Console.WriteLine("nums의 최소값은 {0}입니다.", min);
    }
}