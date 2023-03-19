using System;

namespace maths2
{
    class Program
    {
        public static void Main()
        {
            // 1 
            Console.WriteLine("1 Здратввуй, введи диапозон чисел:");

            Console.Write("\na: ");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nb: ");
            int b1 = Convert.ToInt32(Console.ReadLine());

            for (int i = (1 + a1); i < b1; i++)
                    Console.WriteLine(i);

            // 2
            Console.WriteLine("\n2 Здратввуй, введи диапозон чисел:");

            Console.Write("\na: ");
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nb: ");
            double b2 = Convert.ToDouble(Console.ReadLine());

            while (a2 <= b2 + 0.1)
            {
                Console.WriteLine(Math.Round(a2,1));
                a2 += 0.1;
            }
            // 3
            Console.WriteLine("\n3 Здратввуй, введи диапозон чисел:");

            Console.Write("\na: ");
            double a3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nb: ");
            double b3 = Convert.ToDouble(Console.ReadLine());

            if (a3 == b3)
            {
                Console.WriteLine("=");
            } else if (a3 > b3)
            {
                Console.WriteLine($"{a3} > {b3}");
            } else if (a3 < b3)
            {
                Console.WriteLine($"{a3} < {b3}");
            }

            // 4
            Console.WriteLine("\n4 Здратввуй, введи 6-значное число:");

            Console.Write("\na: ");
            int a4 = int.Parse(Console.ReadLine());

            char[] arr = a4.ToString().ToCharArray();
            int sum41 = (int.Parse(arr[0].ToString()) + int.Parse(arr[1].ToString()) + int.Parse(arr[2].ToString()));
            int sum42 = (int.Parse(arr[3].ToString()) + int.Parse(arr[4].ToString()) + int.Parse(arr[5].ToString()));

            if (sum41 == sum42)
            {
                Console.WriteLine("ura");
            } else if (sum42 != sum41)
            {
                Console.WriteLine("ne ura");
            }

            // 5
            Console.WriteLine("\n5 Здратввуй, введи диапозон чисел:");

            Console.Write("\na: ");
            int a5 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nb: ");
            int b5 = Convert.ToInt32(Console.ReadLine());

            for (int i5 = (1 + a5); i5 < b5; i5++) { if (i5 % 2 == 0) { Console.WriteLine(i5); } }

            // 6

            Console.WriteLine("\n6 Здратввуй, введи сколько чисел нужно суммировать:");

            Console.Write("\na: ");

            int a6 = int.Parse(Console.ReadLine());
            int sum6 = 0;
            int i6;
            while (a6 > 0)
            {
                Console.Write("\nx (Число): ");
                sum6 = sum6 + int.Parse(Console.ReadLine());
                a6--;
            }
            Console.WriteLine("Сумма чисел равна: " + sum6);

            // 7

            string a7;

            Console.WriteLine("\n7 Здраствуй, введи предложение: ");
            a7 = Console.ReadLine();
            string[] b7 = a7.Split(' ');
            string c7 = "";

            for (int i7 = b7.Length - 1; i7 >= 0; i7--)
            {
                c7 += b7[i7] + " ";
            }
            Console.WriteLine(c7);
        }
    }
}