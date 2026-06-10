//To use random numbers, you have to create an instance (object) from the class Random.
Random random = new Random();
//To access the method, you have to use the object that you created and the method.

//int num = random.Next(1, 11);
//double num = random.NextDouble();

//For multiples random numbers:
int num1 = random.Next(1, 11);
int num2 = random.Next(1, 11);
int num3 = random.Next(1, 11);

System.Console.WriteLine(num1);
System.Console.WriteLine(num2);
System.Console.WriteLine(num3);

