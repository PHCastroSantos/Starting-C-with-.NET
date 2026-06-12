System.Console.WriteLine("What day is it today?");
String? day = Console.ReadLine();
switch(day)
{
    case "Monday":
    System.Console.WriteLine("It's Monday!");
    break;
    case "Tuesday":
    System.Console.WriteLine("It's Tuesday!");
    break;
    case "Wednesday":
    System.Console.WriteLine("It's Wednesday!");
    break;
    case "Thursday":
    System.Console.WriteLine("It's Thursday!");
    break;
    case "Friday":
    System.Console.WriteLine("It's Friday!");
    break;
    case "Saturday":
    System.Console.WriteLine("It's Saturday!");
    break;
    case "Sunday":
    System.Console.WriteLine("It's Monday!");
    break;
    default:
    System.Console.WriteLine(day + " is not a day!");
    break;
}