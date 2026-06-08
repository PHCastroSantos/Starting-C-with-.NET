//It's used when we convert a value to a different type of data.

//Example:
double a = 3.14;
int b = Convert.ToInt32(a);

Console.WriteLine(b);

//In this example, we are converting the variable A, that is a double to be stored in a variable data type intenger called B.
//The result will be "3", since intenger doens't allow 3.14.
//We can get the type using Console.WriteLine(variable.getType());
//Example:
Console.WriteLine(a.GetType());
Console.WriteLine(b.GetType());