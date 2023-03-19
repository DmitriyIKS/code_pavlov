
class MyClass
{
    public int number;
    public string name;
    // Методы(overload): 
    public void show(int a, string b)
    {
        Console.WriteLine("Возраст: " + number);
        Console.WriteLine("Имя: " + name);
    }
    public void show(string b)
    {
        Console.WriteLine("Имя данного человека: " + name);
    }
    public void show(int a)
    {
        Console.WriteLine("Этому человеку " + number + " лет!");
    }
}
class Persons
{
    static void Main()
    {
        // Сбор информации от юзера
        Console.WriteLine("Введите имена через пробел: ");
        string text1 = Console.ReadLine();
        string[] namelist = text1.Split(' ');

        Console.WriteLine("Введите возраст через пробел: ");
        string text2 = Console.ReadLine();
        string[] agelist = text2.Split(' ');

        // Первый объект: 
        MyClass A = new MyClass();
        // Второй объект: 
        MyClass B = new MyClass();
        

        // Присваивание значений полям первого объекта:
        A.number = Convert.ToInt16(agelist[0]);
        A.name = namelist[0];
        // Присваивание значений полям второго объекта: 
        B.number = Convert.ToInt16(agelist[1]);
        B.name = namelist[1];

        // Вызов методов 1: 
        Console.WriteLine("Пepвый человек");
        A.show(A.number, A.name);
        Console.WriteLine("Bтopoй человек");
        B.show(B.number, B.name);

        // Вызов методов 2: 
        A.show(A.name);

        // Вызов методов 2: 
        A.show(A.number);
    }
}