// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("My name is Dmitriy");
var input = Console.ReadLine();
if(input == "") { Console.WriteLine("try again"); }
else if(input == "lmao") { Console.WriteLine("lmaobargini"); }
else { Console.WriteLine(input); }

// S1.1. Вывести на экран число  с точностью до сотых. -------------
double a = 1.87789;
Console.WriteLine(Math.Round(a, 2));

// S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.----------
double a2 = 1.68994;
Console.WriteLine(Math.Round(a2, 1));

// S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры.
// Выводимому числу должно предшествовать сообщение «Вы ввели число».------------
Console.Write($"Введите число: ");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели число {a3}");

// S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры.
// После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».------------
Console.Write($"Введите число: ");
int a4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a4} - вот какое число Вы  ввели");

// S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.------------
int a5 = 1;
int b5 = 13;
int c5 = 49;
Console.WriteLine($"{a5} {b5} {c5}");

// S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.-----------
int a6 = 7;
int b6 = 15;
int c6 = 100;
Console.WriteLine($"{a6}  {b6}  {c6}");

// S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.----------
Random rnd7 = new Random();
int a7 = rnd7.Next();
int b7 = rnd7.Next();
int c7 = rnd7.Next();
Console.WriteLine($"{a7}  {b7}  {c7}");

// S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.----------
Random rnd8 = new Random();
int a8 = rnd8.Next();
int b8 = rnd8.Next();
int c8 = rnd8.Next();
int d8 = rnd8.Next();
Console.WriteLine($"{a8} {b8} {c8} {d8}");

// S1.9. Вывести на экран числа 50 и 10 одно под другим.
int a9 = 50;
int b9 = 10;
Console.WriteLine($"{a9}\n{b9}");

// S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.
int a10 = 5;
int b10 = 10;
int c10 = 21;
Console.WriteLine($"{a10}\n{b10}\n{c10}");

// S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.
Random rnd11 = new Random();
int a11 = rnd11.Next();
int b11 = rnd11.Next();
int c11 = rnd11.Next();
int d11 = rnd11.Next();
Console.WriteLine($"{a11}\n{b11}\n{c11}\n{d11}");

// S1.12. Составить программу вывода на экран следующей информации: 5 10
//                                                                  7 см
int a12 = 5;
int b12 = 10;
string c12 = ("7 см");
Console.WriteLine($"{a12} {b12}");
Console.WriteLine($"{c12}");

// S1.13. Составить программу вывода на экран следующей информации: 2 кг
//                                                                  13 17
int a13 = 2;
int b13 = 13;
int c13 = 17;
string d13 = ("кг");
Console.WriteLine($"{a13} {d13}\n{b13} {c13}");