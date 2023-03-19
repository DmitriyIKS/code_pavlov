class Program
{
    public static void Main()
    {
Console.WriteLine("Здравуй, введите пожалуйста дату рождения");
    DateTime data1 = DateTime.Now;
    DateTime data2 = DateTime.Now;

    Console.WriteLine(data2);
    Console.WriteLine(data1.ToString("dd марта yyyy г hh:mm"));

    Console.WriteLine(data2.AddDays(4));
    Console.WriteLine(data2.AddDays(4).ToString("dd марта yyyy г hh:mm"));

    DateTime data3 = Convert.ToDateTime(Console.ReadLine());
    Console.WriteLine(data3);

    Console.ForegroundColor = ConsoleColor.Yellow;
    TimeSpan diff1 = data1.Subtract(data3);

    Console.Write(diff1.ToString("%d"));
    Console.Write(" days\n");

    int diff2 = (data1.Year * 12 + data1.Month)  -  (data3.Year * 12 + data3.Month);
    Console.Write(diff2 + " months\n");

    int diff3 = data1.Year - data3.Year - 1;
    Console.WriteLine(diff3 + " years");

    int diff4 = diff1.Days * 24;
    Console.WriteLine(diff4 + " hours");

    int diff5 = data1.DayOfYear;
    Console.WriteLine(diff5 + " number day of year");

    Console.WriteLine(365 - diff5 + " until the new Year");

    int diff6 = data3.DayOfYear;
    int diff56 = diff6 - diff5;
    if (diff56 < 0)
    {
        Console.WriteLine(-diff56+365 + " until Birthday");
    } else if (diff56 > 0)
    {
        Console.WriteLine(diff56 + " until Birthday");
    }
    Console.ForegroundColor = ConsoleColor.White;

    Console.ReadKey();
    }
    
}