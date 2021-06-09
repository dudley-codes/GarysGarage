using System;

namespace Garage
{
  public class Tesla : Vehicle, IElectric
  {
    public double BatteryKWh { get; set; }

    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
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
