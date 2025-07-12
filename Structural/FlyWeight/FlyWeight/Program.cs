using FlyWeight;
using FlyWeight.Entities;

LoadData data = new LoadData();
if (data.isDataLoaded())
{
    Console.WriteLine($"\nTotal Routes Loaded: {data.ShipRoutes.Count}");

    Console.WriteLine("                             /* ---------------------------  Report --------------------------- */");

    // Display ShipRoute assignments and demonstrate Flyweight reuse.
    foreach (ShipRoute shipRoute in data.ShipRoutes)
    {
        Console.WriteLine($"Employee Details    => ID   : {shipRoute.Employee.Id},      Name    : {shipRoute.Employee.Name}");
        Console.WriteLine($"Ship Details        => ID   : {shipRoute.Ship.Id},          Name    : {shipRoute.Ship.Name},        YearOfMake : {shipRoute.Ship.YearOfMake}");
        Console.WriteLine($"Ship Route          => From : {shipRoute.FromCountry.Name}  TO      : {shipRoute.ToCountry.Name}");
        Console.WriteLine("                                 ------------------------------------------------------ ");
        Thread.Sleep(300);
    }
}