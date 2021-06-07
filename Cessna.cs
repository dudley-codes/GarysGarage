using System;

namespace Garage
{
  public class Cessna : Vehicle
  {
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
      // method definition omitted
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