Car car = new Car();
Bycicle bycicle = new Bycicle();
Boat boat = new Boat();

Vehicle[] vehicles = {car, bycicle, boat};

foreach(Vehicle vehicle in vehicles)
{
    vehicle.Go();
}

class Vehicle
{
    public virtual void Go()
    {
        
    }
}

class Car: Vehicle
{
    public override void Go()
    {
        System.Console.WriteLine("The car is moving");
    }
}

class Bycicle: Vehicle
{
        public override void Go()
    {
        System.Console.WriteLine("The bycicle is moving");
    }
}

class Boat: Vehicle
{
        public override void Go()
    {
        System.Console.WriteLine("The boat is moving");
    }
}