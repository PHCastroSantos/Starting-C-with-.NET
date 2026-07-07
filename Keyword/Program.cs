double x;
double y;
double result;

System.Console.Write("Enter in number 1: ");
x = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter in number 2: ");
y = Convert.ToDouble(Console.ReadLine());

result = Multiply(x, y);
System.Console.Write("The result is: " + result);

static double Multiply(double x, double y) {
    double z = x * y;
    return z;
}