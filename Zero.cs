using System;

namespace Garage
{
  public class Zero : Vehicle, IElectric // Electric motorcycle
  {
    public double BatteryKWh { get; set; }
    public double CurrentChargePercentage { get; set; }

    public void ChargeBattery()
    {
      CurrentChargePercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Zero is also quiet");
    }

    public override void Stop()
    {
      Console.WriteLine("The vehcile slowly rolls to a stop.");
    }

    public override void Turn()
    {
      Console.WriteLine("The vehicle drifts through the turn.");
    }
  }
}
