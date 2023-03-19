namespace Celsius
{
    class Program
    {
        static void Main()
        {
        
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Дорогой друг привествую тебя!");
            Console.ResetColor();
            Found:
            Console.Write("Выберите тип вводимой температуры ( Ф / К / Ц ): ");
            string typeTempPre = Console.ReadLine().ToUpper();

            Console.Write("Выберите тип переобразуемой температуры ( Ф / К / Ц ): ");
            string typeTemp = Console.ReadLine().ToUpper();

            Console.Write("Введите число: ");
            int a = Convert.ToInt16(Console.ReadLine());
            double b;
            Console.ForegroundColor = ConsoleColor.Blue;
            if (typeTempPre == "Ф" && typeTemp == "Ф" || typeTempPre == "К" && typeTemp == "К" || typeTempPre == "Ц" && typeTemp == "Ц")
            {
                Console.WriteLine("Вы ввели одинаковые типы данных");
            }
            else if (typeTempPre == "Ф" && typeTemp == "К")
            {
                b = 5 * (a - 32) / 9 + 273.15;
                Console.WriteLine("Convertation finished " + b);
            }
            else if (typeTempPre == "Ф" && typeTemp == "Ц")
            {
                b = (a - 32) * 5 / 9;
                Console.WriteLine("Convertation finished " + b);
            }
            else if (typeTempPre == "К" && typeTemp == "Ф")
            {
                b = 9 * (a - 273.15) / 5 + 32;
                Console.WriteLine("Convertation finished " + b);
            }
            else if (typeTempPre == "К" && typeTemp == "Ц")
            {
                b = a - 273.15;
                Console.WriteLine("Convertation finished " + b);
            }
            else if (typeTempPre == "Ц" && typeTemp == "Ф")
            {
                b = (a * 9 / 5) + 32;
                Console.WriteLine("Convertation finished " + b);
            }
            else if (typeTempPre == "Ц" && typeTemp == "К")
            {
                b = a + 273.15;
                Console.WriteLine("Convertation finished " + b);
            }
            else
            {
                Console.ResetColor();
                Console.Write("Вы ввели неправильное значение, хотите повторно ввсти значения? (да/нет) ");
                string ff1 = Console.ReadLine().ToLower();
                if (ff1 == "да" || ff1 == "д")
                {
                    goto Found;
                } 
            }
            Console.ResetColor();
            Console.Write("Хотите продолжить? (да/нет) ");
            string ff = Console.ReadLine().ToLower();
            if (ff == "да" || ff == "д")
            {
                goto Found;
            } else if (ff == "нет" || ff == "н")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("До свидания!"); } else { Console.WriteLine("Erorr"); }
            Console.ResetColor();
            
            Console.ReadKey();
        } 
    }
}


