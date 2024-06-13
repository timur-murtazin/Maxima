namespace ConsoleApp1;
public class Program
{
    public static void Main()
    {
        var x = 0;
        var y = 0;
        string str = null;
        int[] num = [ 1, 2, 3, 4, 5];
        string[] args = ["ssa", "sa", "a", "sasas"];

        object res = null;

        Console.Write("Введите первое число: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите сообщение: ");
        str = Console.ReadLine();

        OperationSum operation = Sum;
        res = operation(x, y);
        Console.WriteLine($"Сумма = {res}");

        OperationLenghtStr operation1 = StrLenght;
        res = operation1(str);
        Console.WriteLine($"Длина строки = {res}");

        OperationMultiply operationMultiply = Multiply;
        res = operationMultiply(x, y);
        Console.WriteLine($"Произведение = {res}");

        OperationSumList operationSumList = SumList;
        res = operationSumList(num);
        Console.WriteLine($"Сумма массива = {res}");

        OperationMultiplyList operationMultiplyList = MultiplyList;
        res = operationMultiplyList(num);
        Console.WriteLine($"Произведение массива = {res}");

        OperationMiddleResList operationMiddleResList = MiddleResList;
        res = operationMiddleResList(num);
        Console.WriteLine($"Среднее значение массива = {res}");

        OperationListStrLenght operationListStrLenght = ListStrLenght;
        res = operationListStrLenght(args);

        OperationStrUp operationStrUp = StrUp;
        res = operationStrUp(str);
        Console.WriteLine(res);

        OperationPalindrome operationPalindrome = Palindrome;
        res = operationPalindrome(str);


    }

    public static int Sum(int x, int y)
    {
        int result = default;
        result = x + y;
        return result;
    }

    public static int SumList(int []nums)
    {
        int res = default;
        for (int i = 0; i < nums.Length; i++)
        {
            res += nums[i];
        }
        return res;
    }

    public static int MiddleResList(int[] nums)
    {
        int res = default;
        int midres = default;
        for (int i = 0; i < nums.Length; i++)
        {
            res += nums[i];
        }
        midres = res / nums.Length;
        return midres;
    }

    public static int MultiplyList(int[] nums)
    {
        int res = 1;
        for (int i = 0;i < nums.Length; i++)
        {
            res *= nums[i];
        }
        return res;
    }

    public static double Multiply(double x, double y)
    {
        double res = default;
        res = x * y;
        return res;
    }

    public static int StrLenght(string str)
    {
        int len = default;
        len = str.Length;
        return len;
    }

    public static string ListStrLenght(string[] str)
    {
        int len = default;
        int i = 0;
        Console.WriteLine("Длины строк в массиве: ");
        do
        {
            len = str[i].Length;
            Console.WriteLine(len);
            i++;
        }
        while (i < str.Length);
        return "Конец вывода";
    }

    public static string Palindrome(string str)
    {
        char[] base_char = str.ToCharArray();
        char[] modify_char = str.ToCharArray();
        Array.Reverse(modify_char);

        string base_str = new string(base_char);
        string modify_str = new string(modify_char);

        if (base_str == modify_str)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("Не палиндром");
        }
        return base_str;
    }

    public static string StrUp(string str)
    {
        string strUp = default;
        strUp = str.ToUpper();
        return strUp;
    }

    delegate int OperationSum(int x, int y);
    delegate int OperationLenghtStr(string str);
    delegate double OperationMultiply(double x, double y);
    delegate int OperationSumList(int[] nums);
    delegate int OperationMiddleResList(int[] nums);
    delegate string OperationStrUp(string str);
    delegate string OperationListStrLenght(string[] str);
    delegate string OperationPalindrome(string str);
    delegate int OperationMultiplyList(int[] nums);
}