Rabbit rabbit = new Rabbit();
Hawk hawk = new Hawk();
Fish fish = new Fish();
rabbit.Flee();
hawk.Hunt();
fish.Flee();
fish.Hunt();

interface IPrey
{
    void Flee();
}

interface IPredator
{
    void Hunt();
}
class Rabbit : IPrey
{
    public void Flee()
    {
        System.Console.WriteLine("The rabbit runs away.");
    }
}

class Hawk : IPredator
{
    public void Hunt()
    {
        System.Console.WriteLine("The hawk is searching for food.");
    }
}

class Fish : IPrey, IPredator
{
    public void Flee()
{
    System.Console.WriteLine("The fish swims away!");
}
    public void Hunt()
{
    System.Console.WriteLine("The fish is hunting smaller fishes.");
}
}