Dog dog = new Dog();
Cat cat = new Cat();

dog.Speak();
cat.Speak();

abstract class Animal
{
    public virtual void Speak()
    {
        System.Console.WriteLine("The animal goes *brrr*");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        System.Console.WriteLine("wulf wulf, wulf wulf.");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        System.Console.WriteLine("Meow, meow.");
    }
}