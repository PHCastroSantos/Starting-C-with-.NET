using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(Multiply(2,3,6));
        System.Console.WriteLine(Multiply(2,3));
        System.Console.WriteLine();

        Console.ReadLine();

    }


    static double Multiply(double a, double b)
{
  return a * b;  
}

static double Multiply(double a, double b, double c)
{
  return a * b * c;  
}

}

