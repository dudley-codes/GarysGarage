namespace Garage
{
  public interface IElectric
  {
    void ChargeBattery();
    double CurrentChargePercentage { get; set; }

  }

  public interface IGas
  {
    double CurrentTankPercentage { get; set; }
    void RefuelTank();
  }
}