System.Console.Write("Please, insert yout name: ");
String? name = Console.ReadLine();
while(name == "")
{
    System.Console.Write("You forget to enter your name. Enter your name: ");
    name = Console.ReadLine();
}
System.Console.WriteLine("Hello, " + name);