List<String> food = new List<String>();

food.Add("Pizza");
food.Add("Hamburguer");
food.Add("Hotdog");
food.Add("Hotdog");
food.Add("Bacon");
food.Add("Apple");
food.Remove("Pizza");
food.Insert(0, "Pasta");

String[] foodArray = food.ToArray();


foreach(String item in food)
{
    System.Console.WriteLine(item);
}
