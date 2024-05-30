using System;

namespace TEST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,,] mas = 
              { 
                { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };

            /*Console.Write($"{mas.GetLength(0)} \t") ;
            Console.Write($"{mas.GetLength(1)} \t");
            Console.Write($"{mas.GetLength(2)} ");
            Console.WriteLine();
            Console.Write($"{mas.GetUpperBound(0)} \t");
            Console.Write($"{mas.GetUpperBound(1)} \t");
            Console.Write($"{mas.GetUpperBound(2)} ");
            Console.WriteLine();*/

            Console.WriteLine(mas[0, 0, 1]);
            int x = mas.GetUpperBound(0);
            int y = mas.GetUpperBound(1);
            int z = mas.GetUpperBound(2);

            Console.Write("{");
            for (int i = 0; i <= x/*mas.GetUpperBound(0)*/; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= y/*mas.GetUpperBound(1)*/; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= z/*mas.GetUpperBound(2)*/; k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k < z/*mas.GetUpperBound(2)*/)
                            Console.Write(" , ");                                              
                    }
                    Console.Write("}");
                    if (j < y/*mas.GetUpperBound(1)*/)
                        Console.Write(" , ");   
                }
                Console.Write("}");
                if (i < x/*mas.GetUpperBound(0)*/)
                    Console.Write(" , ");
            }
            Console.Write("}");
            Console.ReadLine();

            /*int x = mas.GetUpperBound( 0 );
            int y = mas.GetUpperBound( 1 );
            int z = mas.GetUpperBound( 2 );

            Console.Write("{");
            for (int i = 0; i <= x; i++)
            {
                Console.Write("{");
                for (int j = 0; j <= y; j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= z; k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k < z)
                            Console.Write(" , ");
                    }

                    Console.Write("}");
                    if (j < y)
                        Console.Write(" , ");
                }
                Console.Write("}");

                if (i < x)
                    Console.Write(" , ");
            }
            Console.Write("}");
            Console.ReadLine();*/

            /*string a1 = "abcde";
            string a2 = "abcde";
            Console.WriteLine(a1 == a2);
            Console.WriteLine(a1.Equals(a2));

            string a3 = "ab";
            string a4 = "a";
            a4 += 'c';
            Console.WriteLine(a4);
            Console.WriteLine(a3.Equals(a4));*/

            /*int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, 2, 3, 4, 5 };
            foreach (int[] row in numbers)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            // перебор с помощью цикла for
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"{numbers[i][j]} \t");
                }
                Console.WriteLine();
            }*/

            /*foreach (var s in a1)
            {
                Console.WriteLine(s);
            }*/

            /*int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
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
            List*/

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