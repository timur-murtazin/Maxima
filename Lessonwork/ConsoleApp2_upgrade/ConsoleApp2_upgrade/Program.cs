namespace Lessonwork;

public class ConsoleApp2_upgrade
{
    public static void Main()
    {
        int[] nums = new int[] { 1, 2, 3, 4, 5 };
        var result = ArrayChange(nums);
        PrintArray(result);     

    }
    public static int[] ArrayChange(int[] nums)
    {
        int temp = default;
        int[] res = new int[nums.Length];
        res[0] = 1;

        for (int i = 1; i < nums.Length; i++)
        {
            res[i] = res[i-1] * nums[i-1];          
        }

        temp = 1;

        for (int i = nums.Length-1;i >= 0; i--)
        {
            res[i] = temp * res[i];
            temp = temp * nums[i];
        }
        return res;
    }

    public static void PrintArray(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
} 

