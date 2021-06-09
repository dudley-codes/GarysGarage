using System;
using System.Collections.Generic;

namespace Garage
{
  class Program
  {
    static void Main(string[] args)
    {
      Zero fxs = new Zero();
      Zero fx = new Zero();
      Tesla modelS = new Tesla();

      fx.CurrentChargePercentage = 99.9;
      fxs.CurrentChargePercentage = 80.1;
      modelS.CurrentChargePercentage = 70.3;

      List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
            };

      Console.WriteLine("Electric Vehicles");
      foreach (IElectric ev in electricVehicles)
      {
        Console.WriteLine($"Current charge for is {ev.CurrentChargePercentage}");
      }

      foreach (IElectric ev in electricVehicles)
      {
        // This should charge the vehicle to 100%
        ev.ChargeBattery();
      }

      foreach (IElectric ev in electricVehicles)
      {
        Console.WriteLine($"{ev.CurrentChargePercentage}");
      }

      /***********************************************/

      Ram ram = new Ram();
      Cessna cessna150 = new Cessna();

      ram.CurrentTankPercentage = 50.1;
      ram.FuelCapacity = 15;
      cessna150.CurrentTankPercentage = 25.5;
      cessna150.FuelCapacity = 1000;

      List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

      Console.WriteLine("Gas Vehicles");
      foreach (IGas gv in gasVehicles)
      {
        Console.WriteLine($"{gv.CurrentTankPercentage}");
      }

      foreach (IGas gv in gasVehicles)
      {
        // This should completely refuel the gas tank
        gv.RefuelTank();
      }

      foreach (IGas gv in gasVehicles)
      {
        Console.WriteLine($"{gv.CurrentTankPercentage}");
      }
    }
  }
}
