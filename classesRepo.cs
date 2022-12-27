public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

static void Main(string[] args)
{
    Car myCar = new Car();
    myCar.Make = "Ford";
    myCar.Model = "Mustang";
    myCar.Year = 1969;

    Console.WriteLine($"Make: {myCar.Make}");
    Console.WriteLine($"Model: {myCar.Model}");
    Console.WriteLine($"Year: {myCar.Year}");
}
