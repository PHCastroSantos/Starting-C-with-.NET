Car car1 = new Car("Mustang");
Car car2 = new Car("Ferrari");
System.Console.WriteLine(Car.numberOfCars);
Car.StartRace();
class Car
{
    String model;
    public static int numberOfCars;
    public Car(String model)
    {
        this.model = model;
        numberOfCars++;
    }

    public static void StartRace()
    {
        System.Console.WriteLine("The race has begun");
    }
}