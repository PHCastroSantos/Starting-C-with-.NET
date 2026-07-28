Car car = new Car("Chevy", "Corvette", 2022, "Blue");
System.Console.WriteLine(car.ToString());

class Car
{
    String make;
    String model;
    int year;
    String color;

    public Car (String make, String model, int year, String color)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public override string ToString()
    {
        return "This is a " + make + " " + model;
    }
}