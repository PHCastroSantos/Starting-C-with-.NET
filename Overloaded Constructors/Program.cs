Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");
Pizza pizza1 = new Pizza("stuffed crust", "red sauce", "mozzarella");
Pizza pizza2 = new Pizza("stuffed crust", "red sauce");
Pizza pizza3 = new Pizza("stuffed crust");
System.Console.WriteLine($"The pizza {pizza} has {pizza.bread}, {pizza.sauce}, {pizza.cheese}, {pizza.topping}");
System.Console.WriteLine($"The pizza {pizza1} has {pizza1.bread}, {pizza1.sauce}, {pizza1.cheese}");
System.Console.WriteLine($"The pizza {pizza2} has {pizza2.bread}, {pizza2.sauce}");
System.Console.WriteLine($"The pizza {pizza3} has {pizza3.bread}");
class Pizza
{
    public String? bread;
    public String? sauce;
    public String? cheese;
    public String? topping;

    public Pizza(String bread, String sauce, String cheese, String topping)
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
        this.topping = topping;
    }

    public Pizza(String bread, String sauce, String cheese)
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
    }

    public Pizza(String bread, String sauce)
    {
        this.bread = bread;
        this.sauce = sauce;
    }

    public Pizza(String bread)
    {
        this.bread = bread;
    }

}

