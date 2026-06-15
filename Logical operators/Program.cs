System.Console.Write("What's the temperature outside (C): ");
double temp = Convert.ToDouble(Console.ReadLine());

if (temp >= 10 && temp <= 25)
{
    System.Console.WriteLine("It's warm outside!");
} else if (temp <= -50 || temp >= 50)
{
    System.Console.WriteLine("DO NOT GO OUTSIDE!");
}