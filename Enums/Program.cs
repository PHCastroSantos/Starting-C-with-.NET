//System.Console.WriteLine(Planets.Mercury + " is a planet #" + (int)Planets.Mercury);
//System.Console.WriteLine(Planets.Venus + " is the planet #" + (int)Planets.Venus);

String name = PlanetRadius.Earth.ToString();
int radius = (int)PlanetRadius.Earth;
double volume = Volume(PlanetRadius.Earth);
System.Console.WriteLine($"Planet: {name}");
System.Console.WriteLine($"Radius: {radius} km");
System.Console.WriteLine($"Volume: {volume}km^3");

static double Volume(PlanetRadius radius)
{
    double volume = (4.0/3.0) * Math.PI * Math.Pow((int)radius, 3);
    return volume;
}

enum Planets
{
    Mercury = 1, 
    Venus = 2, 
    Earth = 3, 
    Mars = 4, 
    Jupiter = 5, 
    Saturn = 6, 
    Uranus = 7, 
    Neptune = 8, 
    Pluto = 9
}

enum PlanetRadius
{
    Mercury = 2439, 
    Venus = 6051, 
    Earth = 6371, 
    Mars = 3389, 
    Jupiter = 69911, 
    Saturn = 58232, 
    Uranus = 25362, 
    Neptune = 24622, 
    Pluto = 1188,
}