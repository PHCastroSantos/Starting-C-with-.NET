Human person = new Human();

person.name = "Pedro";
person.age = 25;

person.Eat();
person.Sleep();

class Human
{
    public String? name;
    public int age;

    public void Eat()
    {
        System.Console.WriteLine($"{name} is eating.");
    }

    public void Sleep()
    {
        System.Console.WriteLine($"{name} is sleeping.");
    }
}

