System.Console.Write("How many rows?: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("How many columns?: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.Write("What symbol?: ");
String? symbol = Console.ReadLine();

for(int i = 0; i < rows; i++ )
{
    for(int j = 0; j < columns; j++)
    {
        System.Console.Write(symbol);
    }
    System.Console.WriteLine();
}