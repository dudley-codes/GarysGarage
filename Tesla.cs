using System;

namespace Garage
{
  public class Tesla : Vehicle
  {
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
      // method definition omitted
    }
    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Tesla doesn't make any sound.");
    }

    public override void Stop()
    {
      Console.WriteLine("The vehicle screetches to a halt.");
    }

    public override void Turn()
    {
      Console.WriteLine("The car slides around the bend.");
    }
  }
}
