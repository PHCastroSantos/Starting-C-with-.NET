Car car1 = new Car("Mustang", "Red");
Car car2 = Copy(car1);

System.Console.WriteLine(car2.color + " " +  car2.model);

static Car Copy(Car car)
{
    return new Car(car.model, car.color);
}
class Car
{
    public String model;
    public String color;

    public Car(String model, String color)
    {
        this.model = model;
        this.color = color;
    }
}