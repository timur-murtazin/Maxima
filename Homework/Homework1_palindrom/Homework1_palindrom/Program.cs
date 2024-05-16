namespace Homework1_palindrom
{
    public class Program
    {
        public static void Main()
        {
            string base_number;
            int modify_number;
            Console.Write("Введите число: ");
            base_number = Console.ReadLine();
            modify_number = Convert.ToInt32(base_number);
            isPalindrom(modify_number);

            int Num = default, reverseNum = default, NumCopy = default;  //решение как надо, математический метод
            Num = Convert.ToInt32(base_number);                          

            while (Num != 0)
            {
                reverseNum = reverseNum*10 + Num%10;
                Num /= 10;
            }
            Console.WriteLine (NumCopy == reverseNum);                  //
        }

        public static Boolean isPalindrom(Int32 number)                 //решение через строковые значения
        {
            char[] base_char = number.ToString().ToCharArray();
            char[] modify_char = number.ToString().ToCharArray();
            Array.Reverse(modify_char);

            String s1 = new String(base_char);
            String s2 = new String(modify_char);

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
