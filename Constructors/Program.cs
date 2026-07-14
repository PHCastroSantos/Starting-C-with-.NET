Human person = new Human("Pedro", 25);
Car car1 = new Car("Ford", "Mustang", 2022, "Red");

car1.Drive();

class Human
{
    public String? name;
    public int age;

    public Human(String name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Eat()
    {
        System.Console.WriteLine($"{name} is eating.");
    }

    public void Sleep()
    {
        System.Console.WriteLine($"{name} is sleeping.");
    }
}
    class Car
{
    public String? make;
    public String? model;
    public int year;
    public String? color;

    public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public void Drive()
        {
            System.Console.WriteLine($"You drive the {make} {model}, {year} {color}");
        }
    }