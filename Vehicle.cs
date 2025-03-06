public enum VehicleType
{
    Mobil,
    Motor
}
public class Vehicle(String plateNumber, String color, VehicleType type)
{
    public string plateNumber = plateNumber;
    public string color = color;
    public VehicleType type = type;
}