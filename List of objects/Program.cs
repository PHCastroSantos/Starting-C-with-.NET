List<Player> players = new List<Player>();

players.Add(new Player("Clark"));
players.Add(new Player("Garrison"));
players.Add(new Player("Steve"));

foreach(Player player in players)
{
    System.Console.WriteLine(player.username);
}

class Player
{
    public String username;
    public Player(String username)
    {
        this.username = username;
    }
}