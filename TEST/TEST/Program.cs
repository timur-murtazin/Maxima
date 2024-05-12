namespace TEST
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /* string a1 = "abcde";
            string a2 = "abcde";
            *//*Console.WriteLine(a1 == a2);*//*
            Console.WriteLine(a1.Equals(a2));

            string a3 = "ab";
            string a4 = "a";
            a4 += 'c';
            Console.WriteLine(a4);
            Console.WriteLine(a3.Equals(a4));*/

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array1 = new int[] { 15, 12, 11, 14, 15, 16, 17, 18, 19, 20 };
            int[] array2 = new int[] { 22, 144, 11, 14, 15, 16, 17, 18, 19, 20 };
            int Sum = 1;
            int Massa = 100;
            int v1 = Sum + Massa;
            PrintArray (array2);
            PrintArray (array);
            PrintArray (array1);
            PrintInt (Sum);
            //Console.WriteLine();
            PrintInt (Massa);
            PrintInt (v1);
            List

        /*    foreach (int i in array) 
            {
                Console.WriteLine(i);
            }*/
        }
        public static void PrintArray(int[] f)
        {
            //int i = 1;
            //string s = Convert.ToString(f[i]);
            //Console.WriteLine(Convert.ToString(f[i]));
            //Console.WriteLine(f[i]);
            //Console.WriteLine(s);
            for (int i = 0; i < f.Length; i++)
            {
                string s = Convert.ToString(f[i]);
                //Console.WriteLine($"{arr[i]}");
                Console.WriteLine(s);
            }

            Console.WriteLine();
        }
        public static void PrintInt(int a)
        {
                //string s = Convert.ToString(arr[i]);
                Console.WriteLine(a);
                //Console.WriteLine(s);
                Console.WriteLine();
        }
    }
}