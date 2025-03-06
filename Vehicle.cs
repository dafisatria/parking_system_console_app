public enum VehicleType
{
    Mobil,
    Motor
}
public class Vehicle
{
    public string plateNumber;
    public string color;
    public VehicleType type;

    public Vehicle(String plateNumber, String color, VehicleType type)
    {
        this.plateNumber = plateNumber;
        this.color = color;
        this.type = type;
    }
}