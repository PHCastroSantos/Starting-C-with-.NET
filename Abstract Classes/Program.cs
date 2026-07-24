Car car = new Car();
Bike bike = new Bike();
Vehicle vehicle = new Vehicle();

car.go();
bike.go();

abstract class Vehicle
{
    public int speed = 0;
    public int wheel = 0;
    public String? name;
    public void go()
    {
        System.Console.WriteLine($"You have a {name}. It has {wheel} wheels and the maximum speed is {speed}Km/h.");
    }
}

class Bike : Vehicle
{

    public Bike()
    {
    wheel = 2;
    speed = 30;
    name = "Bike";
    }
}

class Car : Vehicle
{
    public Car()
    {
    wheel = 4;
    speed = 120;
    name = "Car";
    }
}

