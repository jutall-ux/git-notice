SayHello();
SayHello();
SayHello();
void SayHello()
{
    Console.WriteLine("Привет Мир");
}
void Greet(string name)
{
    Console.WriteLine($"Имя: {name}");
}
Greet("Александр");
Greet("Саша");
Greet("Санёк");
void PrintPerson(string name,int age,string city)
{
    Console.WriteLine($"Имя: {name},Возраст: {age} город :{city}");
}
PrintPerson("Егор", 15, "Москва");
int Square(int x)
{
    return x**2;
}
Square(5);
Console.WriteLine(x);