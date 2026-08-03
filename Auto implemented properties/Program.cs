Car car = new Car("Porshe");
System.Console.WriteLine(car.Model);
class Car
{
    public String Model {get; set;}

    public Car(String model)
    {
        this.Model = model;
    }
}