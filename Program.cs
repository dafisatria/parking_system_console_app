class Program
{
    public static void Main(string[] args)
    {
        Vehicle vehicle = new("B-1231-XYZ", "Putih", VehicleType.Mobil);
        Vehicle vehicle2 = new("B-1234-XYZ", "Merah", VehicleType.Mobil);
        Vehicle vehicle3 = new("B-1233-XYZ", "Putih", VehicleType.Mobil);
        ParkingLot lot = new(3);

        lot.CheckIn(vehicle);
        lot.CheckIn(vehicle2);
        lot.CheckIn(vehicle3);
        lot.Status();
        // lot.CheckOut(4);
        // lot.CheckOut(2);
        // lot.CheckOut(1);
        lot.Status();
        // lot.SortPlateNumberByEvent();
        // lot.SortPlateNumberByOdd();
        // lot.SortPlateNumberByColor("merah");
        // lot.SortSlotByColor("putih");
        lot.SearchSlotByPlateNumber("B-1233-XYZ");
    }
}