//The code below create immutable values, different from the variables where you can change the value whenever you need.
//It's necessary when we DON'T WANT TO CHANGE THE VALUES IN ALL OUR CODE.

const double pi = 3.14;

Console.WriteLine($"The value of PI is: {pi}");

//If we try to change this value, it give us an error.

pi = 50;

Console.WriteLine($"The new value of PI is: {pi}");