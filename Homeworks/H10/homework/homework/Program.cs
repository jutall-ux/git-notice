var m1 = new Movie();
var m2 = new Movie("Матрица");
var m3 = new Movie("Начало", "Фантастика", 9);
var kettle = new Kettle();
var toaster = new Toaster();
kettle.Name = "Redmond";
kettle.TurnOn();
kettle.Boil();
kettle.Beep();
toaster.Name = "Philips";
toaster.TurnOn();
toaster.Toast();
toaster.Beep();
m1.PrintInfo();
m2.PrintInfo();
m3.PrintInfo();
class Movie
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int Rating { get; set; }
    public Movie(string title, string genre, int rating)
    {
        Title = title;
        Genre = genre;
        Rating = rating;
    }
    public Movie(string title) : this(title, "Неизвестен", 0)
    {
    }
    public Movie() : this("Без названия", "Неизвестен", 0)
    {
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Название: {Title}, жанр: {Genre}, рейтинг: {Rating}");
    }
}
class Device
{
    public string Name;
    public void TurnOn()
    {
        Console.WriteLine("Устройство включено");
    }
    public virtual void Beep()
    {
        Console.WriteLine("Устройство подаёт сигнал");
    }
}
class Kettle : Device
{
    public void Boil()
    {
        Console.WriteLine("Чайник кипятит воду");
    }
    public override void Beep()
    {
        Console.WriteLine("Чайник пикнул: пи-пи");
    }
}
class Toaster : Device
{
    public void Toast()
    {
        Console.WriteLine("Тостер поджаривает хлеб");
    }
    public override void Beep()
    {
        Console.WriteLine("Тостер пикнул: динь");
    }
}