using System;

namespace Garage
{
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero()
      {
        MainColor = "red",
        MaximumOccupancy = 2,
        BatteryKWh = 5.5
      };
      Tesla modelS = new Tesla()
      {
        MainColor = "black",
        MaximumOccupancy = 5,
        BatteryKWh = 10.1

      };
      Cessna mx410 = new Cessna()
      {
        FuelCapacity = 1400,
        MaximumOccupancy = 3,
        MainColor = "silver"
      };
      Ram pickup = new Ram()
      {
        MainColor = "purple",
        MaximumOccupancy = 6,
        FuelCapacity = 16
      };

      fxs.Drive();
      fxs.Stop();
      fxs.Turn();
      Console.WriteLine();
      modelS.Drive();
      modelS.Turn();
      modelS.Stop();
      Console.WriteLine();
      mx410.Drive();
      mx410.Turn();
      mx410.Stop();
      Console.WriteLine();
      pickup.Drive();
      pickup.Turn();
      pickup.Stop();


    }
  }
}
