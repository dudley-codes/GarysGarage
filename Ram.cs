using System;

namespace Garage
{
  public class Ram : Vehicle // Gas powered truck
  {
    public double FuelCapacity { get; set; }


    public void RefuelTank()
    {
      // method definition omitted
    }

    public override void Drive()
    {
      Console.WriteLine($"The {MainColor} Ram goes rumblerumble");
    }

    public override void Turn()
    {
      Console.WriteLine("The truck turns wicked fast.");
    }

    public override void Stop()
    {
      Console.WriteLine("The truck stops wicked quick.");
    }
  }
}
