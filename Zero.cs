using System;

namespace Garage
{
  public class Zero : Vehicle // Electric motorcycle
  {
    public double BatteryKWh { get; set; }


    public void ChargeBattery()
    {
      // method definition omitted
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
