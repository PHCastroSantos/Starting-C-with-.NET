int x;
int y;
int result;

try
{
System.Console.Write("Enter number 1: ");
x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter number 2: ");
y = Convert.ToInt32(Console.ReadLine());

result = x / y;

System.Console.WriteLine("Result: " + result);

}

catch (FormatException e)
{
    System.Console.WriteLine("Enter only numbers, please!");
}
catch (DivideByZeroException e)
{
    System.Console.WriteLine("You can't divide by 0.");
}
finally
{
    System.Console.WriteLine("Thanks for visiting!");
}
