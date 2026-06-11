System.Console.Write("Enter side A of the triangle: ");
double a = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter side B of the triangle: ");
double b = Convert.ToDouble(Console.ReadLine());
double c = Math.Sqrt((a * a) + (b * b));
System.Console.Write($"The Hypotenuse is: {c}");
