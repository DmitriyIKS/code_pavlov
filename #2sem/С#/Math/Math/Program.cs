using System;

// 1

Console.WriteLine("1 Введите целое цисло");
int a1 = Convert.ToInt16(Console.ReadLine());
if (a1> 20 && a1 < 40)
{
    Console.WriteLine("Цисло б 20 и м 40");
} else
{
    Console.WriteLine("Неизвестное чило");
}

// 2

Console.WriteLine("2 Введите целое цисло");
int a2 = Convert.ToInt16(Console.ReadLine());
if (a2 > 99 && a2 < 1000)
{
    Console.Write(a2 % 10);
    while ((a2 /= 10) != 0)
        Console.Write(a2 % 10);
} else
{
    Console.WriteLine("Не 3х знач");
}

// 3

Console.WriteLine("\n3 Введите 3 целых чисел");
int a31 = Convert.ToInt16(Console.ReadLine());
int a32 = Convert.ToInt16(Console.ReadLine());
int a33 = Convert.ToInt16(Console.ReadLine());

int sum31, sum32;
sum31 = (a31 + a32 + a33);
sum32 = (a31 * a32 * a33);

Console.WriteLine(sum32 +","+ sum31);

// 4

Console.WriteLine("4 Введите цену булки в Рублях и копейках");
int a41 = Convert.ToInt16(Console.ReadLine());
int a42 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Сколько блок хотите");
int a43 = Convert.ToInt16(Console.ReadLine());

int sum4 = (a41 * 100 + a42) * a43;
Console.WriteLine(sum4 + "Цена в копейках" + (sum4 / 100) + "Цена в рублях");

// 5

Console.WriteLine("5 Введите любое целое число");
int a5 = int.Parse(Console.ReadLine());
int sum5 = 0;

while (a5 > 0)
{
    sum5 = sum5 + a5 % 10;
    a5 = a5 / 10;
}
Console.WriteLine("Сумма цифр числа равна: " + sum5);

// 6 

Console.WriteLine("6 Введите 3 целых чисел");
int a61 = Convert.ToInt16(Console.ReadLine());
int a62 = Convert.ToInt16(Console.ReadLine());
int a63 = Convert.ToInt16(Console.ReadLine());

int sum6 = (a61 + a62 + a63) / 3;
Console.WriteLine("Среднее арифметическое: " + sum6);

// 7 

Console.WriteLine("7 Введите номер месяца в формате XX");
int a7 = Convert.ToInt16(Console.ReadLine());

switch (a7)
{
    case 01:
        Console.WriteLine("Январь - 31");
        break;
    case 02:
        Console.WriteLine("Февраль - 28 (29)");
        break;
    case 03:
        Console.WriteLine("Март - 31");
        break;
    case 04:
        Console.WriteLine("Апрель - 30");
        break;
    case 05:
        Console.WriteLine("Май - 31");
        break;
    case 06:
        Console.WriteLine("Июнь - 30");
        break;
    case 07:
        Console.WriteLine("Июль - 31");
        break;
    case 08:
        Console.WriteLine("Август - 31");
        break;
    case 09:
        Console.WriteLine("Сентябрь - 30");
        break;
    case 10:
        Console.WriteLine("Октябрь - 31");
        break;
    case 11:
        Console.WriteLine("Ноябрь - 30");
        break;
    case 12:
        Console.WriteLine("Декабрь - 31");
        break;
    default:
        Console.WriteLine("Erorr");
        break;
}

// 8 

Console.WriteLine("8 Введите целое число");
int a8 = Convert.ToInt16(Console.ReadLine());
if (a8 % 2 == 0)
{
    Console.WriteLine("Четное");
} else
{
    Console.WriteLine("Нечет");
}




Console.ReadKey();
