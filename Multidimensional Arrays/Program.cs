String [,] parkingLot = { {"Mustang" ,"F-150", "Explorer"},
                          {"Corvette", "Camaro", "Silverado"},
                          {"Corolla", "Camry", "Rav4"}

}; 

parkingLot[0, 2] = "Fusion";
parkingLot[2, 0] = "Ferrari";

foreach(String car in parkingLot)
{
    System.Console.WriteLine(car);
}