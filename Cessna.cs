using System;

namespace Garage
{
  public class Cessna : Vehicle, IGas
  {
    public double FuelCapacity { get; set; }
    public double CurrentTankPercentage { get; set; }

    public void RefuelTank()
    {
      CurrentTankPercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Cessna goes Zoooooom!");
    }

    public override void Stop()
    {
      Console.WriteLine("The Cessna barely stops at the end of the runway.");
    }

    public override void Turn()
    {
      Console.WriteLine("The airplane glides through the turn.");
    }
  }
}