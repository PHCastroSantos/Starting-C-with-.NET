Car[] garage =
{
    new Car("Mustang"), new Car("Convette"), new Car("Lamborghini")
};

foreach (Car car in garage)
{
 System.Console.WriteLine(car.model);   
}

class Car
{
    public String model;
    public Car(string model)
    {
        this.model = model;
    }
}