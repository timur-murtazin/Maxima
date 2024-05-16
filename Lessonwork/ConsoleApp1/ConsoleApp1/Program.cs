namespace Lessonwork;

public class ConsoleApp1
{
    public static void Main()
    {
        int[] nums = new int [] { -1, 1, 0, -3, 3 };
        var res = ArrayTask1(nums);
        PrintArray(res);
    }
    public static int[] ArrayTask1(int[] nums)
    {
        int[] result = new int[nums.Length];
        int multiplay = nums[0];
        int zeroIndex = default;
        int zeroCount = default;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                if (multiplay == 0)
                {
                    multiplay += nums[i];
                }
                else
                {
                    multiplay *= nums[i];
                }
            }
            else
            {
                zeroIndex = i;
                zeroCount++;
            }
            if (zeroCount > 1)
            {
                return result;
            }
        }

        if (zeroCount == 1)
        {
            result[zeroIndex] = multiplay;
            return result;
        }

        for (int i = 0; i < result.Length; i++)
        {
            if (nums[i] == 0)
            {
                result[i] = 0;
            }
            else
            {
                result[i] = multiplay / nums[i];
            }
        }
        return result;
    }
    static void PrintArray(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}



//Задание. На вход поступает массив целых чисел nums[]. Надо верннуть новый массив,
//где каждый элемент равен произведению всех элементов, кроме nums[i]

//Input: [1,2,3,4]
//Output: [24,12,8,6]

//Input: [-1,1,0,-3,3]
//Output: [0,0,9,0,0]