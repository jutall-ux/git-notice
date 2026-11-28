while (true)
{
    string first = Console.ReadLine();
    if (first == "exit") break;

    int num1 = int.Parse(first);
    int num2 = int.Parse(Console.ReadLine());
    string znak = Console.ReadLine();

    if (znak == "+") Add();
    else if (znak == "-") Subtract();
    else if (znak == "*") Multiply();
    else if (znak == "/") Divide();

    void Add() => Console.WriteLine(num1 + num2);
    void Subtract() => Console.WriteLine(num1 - num2);
    void Multiply() => Console.WriteLine(num1 * num2);
    void Divide() => Console.WriteLine(num1 / num2);
}

// === этот код выполнится ПОСЛЕ выхода из цикла ===
var phone = new Phone { Model = "Nokia" };
phone.Charge(50);
phone.Use(20);
Console.WriteLine($"{phone.Model}: {phone.Battery}%");

// класс — в самом конце файла
public class Phone
{
    private int _battery;

    public string Model { get; set; }

    public int Battery
    {
        get => _battery;
        set
        {
            if (value > 100) _battery = 100;
            else if (value < 0) _battery = 0;
            else _battery = value;
        }
    }

    public void Charge(int amount) => Battery += amount;
    public void Use(int amount) => Battery -= amount;
}