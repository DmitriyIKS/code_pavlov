namespace Sunday
{
    class Program
    {
        static void Main()
        {
            Sunday day1 = new Sunday();
            day1.day = 1; day1.name = "Понедельник";

            Sunday day2 = new Sunday();
            day2.day = 2; day2.name = "Вторник";

            Sunday day3 = new Sunday();
            day3.day = 3; day3.name = "Серда";

            Sunday day4 = new Sunday();
            day4.day = 4; day4.name = "Четверг";

            Sunday day5 = new Sunday();
            day5.day = 5; day5.name = "Пятница";

            Sunday day6 = new Sunday();
            day6.day = 6; day6.name = "Суббота";
            
            

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Дорогой друг привествую тебя!");
            Console.ResetColor();

            LMAO:
            Console.WriteLine("Введите число от 1 до 7, чтобы узнать сколько дней осталось до выходного: ");
            int num = Convert.ToInt16(Console.ReadLine());

            if (num > 7 || num < 1)
            {
                Console.WriteLine("Вы ввели неправильное число");
                goto LMAO;
            } else if (num == 7)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("У вас выходной (Воскресенье)");
                Console.ResetColor();
            } else
            {
                switch (num) {
                    case 1: day1.PrintDay(); break;
                    case 2: day2.PrintDay(); break;
                    case 3: day3.PrintDay(); break;
                    case 4: day4.PrintDay(); break;
                    case 5: day5.PrintDay(); break;
                    case 6: day6.PrintDay(); break;
                }
            }
        }
    }
    class Sunday
    {
        public string name = "Undefinded";
        public int day;

        public void PrintDay()
        {
            Console.WriteLine(7-day + " до выходного дня, сегодня " + name);
        }
    }
}