/* System.Console.Write("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
if (age > 100)
{
    System.Console.Write("Congratulations! You are now signed up.");
} 
else if (age >= 18) {
    System.Console.WriteLine("This is not possible! You haven't even born yet.");
} 
else if (age < 0)
{
    System.Console.WriteLine("Damn, you are too old to sign up.");
}
else 
{
    System.Console.Write("Sorry, you must be 18+ to sign up.");
}
*/

System.Console.Write("Please enter your name: ");
String? name = Console.ReadLine();
if(name != "")
{
    System.Console.WriteLine($"Hello, {name}.");
} else
{
    System.Console.WriteLine("You did not enter your name!");
}
