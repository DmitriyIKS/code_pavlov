using System.Text;

namespace Om
{
    public class Program
    {
        public static void Main()
        {
            /*// 1
            Console.WriteLine("1 Введите количество резисторов: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            int sum1 = 0;
            int a1 = 0;

            while (a1<num1)
            {
                Console.WriteLine("Введите сопротивление: ");
                int i1 = Convert.ToInt16(Console.ReadLine());
                sum1 =sum1 + i1;
                a1++;
            }
            Console.WriteLine(sum1);

            // 2
            Console.WriteLine("\n2 Введите количество резисторов: ");
            double num2 = Convert.ToInt16(Console.ReadLine());
            double sum2 = 0;
            double a2 = 0;

            while (a2 < num2)
            {
                Console.WriteLine("Введите сопротивление: ");
                double i2 = Convert.ToInt16(Console.ReadLine());
                sum2 = 1/(sum2 + (1/i2));
                a2++;
            }
            Console.WriteLine(sum2);

            // 3
            Console.WriteLine("\n2 Введите сумму вклада: ");
            decimal num3 = Convert.ToDecimal(Console.ReadLine());
            decimal sum3 = 0;
            decimal a3 = 0;

            if (num3 < 1000)
            {
                sum3 = num3 + ((num3 / 100) * 5);
                Console.WriteLine(sum3);
            }
            else if (num3 >= 1000 && num3 <= 3000)
            {
                sum3 = num3 + ((num3 / 100) * 7);
                Console.WriteLine(sum3);
            }
            else if (num3 > 3000)
            {
                sum3 = num3 + ((num3 / 100) * 10);
                Console.WriteLine(sum3);
            }
            else
            {
                Console.WriteLine("erorr");
            }
            
            */
            // 4 
            Console.Write("\n4 Введите число для преобразование в прописное: ");
            int val = Convert.ToInt32(Console.ReadLine());
            if (val == 0)
            {
                Console.WriteLine("НУЛЬ");
            }
            else if (val > 1000000)
            {
                Console.WriteLine("Число не может быть больше тысячных");
            }
            else
            {
                Console.WriteLine(Numbs.Str(val));
            }

            Console.ReadKey();
        }
        public class Numbs
        {
            private static string[] stolniki =
            {
            "", "сто ", "двести ", "триста ", "четыреста ",
            "пятьсот ", "шестьсот ", "семьсот ", "восемьсот ", "девятьсот "
        };

            private static string[] desyatki =
            {
            "", "десять ", "двадцать ", "тридцать ", "сорок ", "пятьдесят ",
            "шестьдесят ", "семьдесят ", "восемьдесят ", "девяносто "
        };

            public static string Str(int val, bool male, string one, string two, string five)
            {
                string[] numbs20 =
                {
                "", "один ", "два ", "три ", "четыре ", "пять ", "шесть ",
                "семь ", "восемь ", "девять ", "десять ", "одиннадцать ",
                "двенадцать ", "тринадцать ", "четырнадцать ", "пятнадцать ",
                "шестнадцать ", "семнадцать ", "восемнадцать ", "девятнадцать "
            };

                int num = val % 1000;
                if (0 == num) return "";
                if (num < 0) throw new ArgumentOutOfRangeException("val", "Параметр не может быть отрицательным");
                if (num > 1000000) throw new ArgumentOutOfRangeException("val", "Число не может быть больше тысячных");
                if (!male)
                {
                    numbs20[1] = "одна ";
                    numbs20[2] = "две ";
                }

                StringBuilder r = new StringBuilder(stolniki[num / 100]);

                if (num % 100 < 20)
                {
                    r.Append(numbs20[num % 100]);
                }
                else
                {
                    r.Append(desyatki[num % 100 / 10]);
                    r.Append(numbs20[num % 10]);
                }

                r.Append(Case(num, one, two, five));

                if (r.Length != 0) r.Append(" ");
                return r.ToString();
            }

            public static string Case(int val, string one, string two, string five)
            {
                int t = (val % 100 > 20) ? val % 10 : val % 20;

                switch (t)
                {
                    case 1: return one;
                    case 2: case 3: case 4: return two;
                    default: return five;
                }
            }

            public static string Str(int val)
            {
                bool minus = false;
                if (val < 0) { val = -val; minus = true; }

                int n = (int)val;

                StringBuilder r = new StringBuilder();

                if (0 == n) r.Append("0 ");
                if (n % 1000 != 0)
                    r.Append(Numbs.Str(n, true, "", "", ""));

                n /= 1000;

                r.Insert(0, Numbs.Str(n, false, "тысяча", "тысячи", "тысяч"));
                n /= 1000;

                if (minus) r.Insert(0, "минус ");

                r[0] = char.ToUpper(r[0]);

                return r.ToString();
            }
        }
    }
}