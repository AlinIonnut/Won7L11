using Won7L11.Models;
using Won7L11.Services;
using static Won7L11.Services.VehicleServices;

TankServices tank = new TankServices(0,500, CombustibleType.Gasoline);
Gasoline gasolineCar = new Gasoline(2,"Seat Ibiza", 5, 50, CombustibleType.Gasoline);
Diesel dieselCar = new Diesel(1, "Opel Astra", 13, 45, CombustibleType.Diesel);
GPL gplCar = new GPL(4, "Dacia Logan", 23.4, 45, CombustibleType.GPL);

tank.LoadingTank(300, CombustibleType.Gasoline);
tank.LoadingVehicle(20, dieselCar);
tank.LoadingVehicle(11.1, gasolineCar);
tank.LoadingVehicle(5, gplCar);

Console.WriteLine(gasolineCar.PresentTheVehicle());
Console.WriteLine(dieselCar.PresentTheVehicle());
Console.WriteLine(gplCar.PresentTheVehicle());
