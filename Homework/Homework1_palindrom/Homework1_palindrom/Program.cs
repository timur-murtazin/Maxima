namespace Homework1_palindrom
{
    public class Program
    {
        public static void Main()
        {
            string x = "1";
            int y;
            Console.Write("Введите число: ");
            x = Console.ReadLine();
            //Console.WriteLine(x);
            y = Convert.ToInt32(x);
            isPalindrom(y);
        }

        public static Boolean isPalindrom(Int32 number)
        {
            char[] n1 = number.ToString().ToCharArray();
            char[] n2 = number.ToString().ToCharArray();
            Array.Reverse(n2);

            String s1 = new String(n1);
            String s2 = new String(n2);

            if (s1 == s2) 
            {
                Console.WriteLine("Является палиндромом");
            }
            else
            {
                Console.WriteLine("Не является палиндромом");
            }
            return (s1 == s2);

        }
    }
}
