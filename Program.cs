class Program
{
    public static void Main(string[] args)
    {
        bool loopApp = true;
        ParkingLot? parkingLot = null;
        System.Console.WriteLine("--- Parking System ---");
        System.Console.WriteLine("1. Create Parking Lot");
        System.Console.WriteLine("2. Park");
        System.Console.WriteLine("3. Leave");
        System.Console.WriteLine("4. Status");
        System.Console.WriteLine("5. Search By Type of Vehicle");
        System.Console.WriteLine("6. Sort Plate Number By Odd Plate Number");
        System.Console.WriteLine("7. Sort Plate Number By Event Plate Number");
        System.Console.WriteLine("8. Sort Plate Number By Color Vehicle");
        System.Console.WriteLine("9. Sort Slot Number By Color Vehicle");
        System.Console.WriteLine("10. Search Slot Number By Plate Number");
        System.Console.WriteLine("0. Exit");
        while (loopApp)
        {
            System.Console.Write("Choose an option: ");
            String? input = Console.ReadLine();
            System.Console.WriteLine();

            switch (input)
            {
                case "1":
                    System.Console.Write("create_parking_lot ");
                    parkingLot = new ParkingLot(int.Parse(Console.ReadLine()));
                    System.Console.WriteLine("Created a parking lot with " + parkingLot.totalLots + " slots\n");
                    break;
                case "2":
                    System.Console.Write("park ");
                    string? vehicle = Console.ReadLine();
                    string[] data = vehicle.Split(' ');
                    if (parkingLot != null)
                    {
                        parkingLot?.CheckIn(new Vehicle(data[0], data[1], data[2]));
                    }
                    else
                    {
                        System.Console.WriteLine("Enter number of parking lot first in the first menu!\n");
                    }
                    break;
                case "3":
                    System.Console.Write("leave ");
                    if (parkingLot != null)
                    {
                    parkingLot.CheckOut(int.Parse(Console.ReadLine()));
                    }
                    else
                    {
                        System.Console.WriteLine("Enter number of parking lot first in the first menu!\n");
                    }
                    break;
                case "4":
                    System.Console.WriteLine("status");
                    parkingLot.Status();
                    break;
                case "5":
                    System.Console.Write("type_of_vehicles ");
                    if (parkingLot != null)
                    {
                    parkingLot.CountVehiclesByType(Console.ReadLine());
                    }
                    else
                    {
                        System.Console.WriteLine("Enter number of parking lot first in the first menu!\n");
                    }
                    break;
                case "6":
                    System.Console.WriteLine("registration_numbers_for_vehicles_with_ood_plate");
                    parkingLot.SortPlateNumberByOdd();
                    break;
                case "7":
                    System.Console.WriteLine("registration_numbers_for_vehicles_with_event_plate");
                    parkingLot.SortPlateNumberByEvent();
                    break;
                case "8":
                    System.Console.Write("registration_numbers_for_vehicles_with_colour ");
                    parkingLot.SortPlateNumberByColor(Console.ReadLine());
                    break;
                case "9":
                    System.Console.Write("slot_numbers_for_vehicles_with_colour ");
                    parkingLot.SortSlotByColor(Console.ReadLine());
                    break;
                case "10":
                    System.Console.Write("slot_number_for_registration_number ");
                    parkingLot.SearchSlotByPlateNumber(Console.ReadLine());
                    break;
                case "0":
                    System.Console.WriteLine("exit");
                    loopApp = false;
                    break;
            }
        }
    }
}