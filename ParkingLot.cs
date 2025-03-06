class ParkingLot(int total)
{
    public int totalLots = total;
    public Dictionary<int, Vehicle> lots = [];

    public void CheckIn(Vehicle vehicle)
    {
        if (lots.Count >= totalLots)
        {
            System.Console.WriteLine("Sorry, parking lot is full\n");
            return;
        }
        if (!string.Equals(vehicle.type, "mobil", StringComparison.OrdinalIgnoreCase) && !string.Equals(vehicle.type, "motor", StringComparison.Ordinal))
        {
            System.Console.WriteLine("Sorry, only car and motorcycle can parking here\n");
            return;
        }
        for (int i = 1; i <= totalLots; i++)
        {
            if (!lots.ContainsKey(i))
            {
                lots[i] = vehicle;
                System.Console.WriteLine("Allocated slot number: " + i + "\n");
                return;
            }
        }
    }

    public void CheckOut(int slotNumber)
    {
        if (lots.ContainsKey(slotNumber))
        {
            System.Console.Write("Enter duration: ");
            int duration = int.Parse(Console.ReadLine());
            duration *= 5000;
            System.Console.WriteLine("Parking fee: "+duration);
            lots.Remove(slotNumber);
            System.Console.WriteLine("Slot number " + slotNumber + " is free\n");
        }
        else
        {
            Console.WriteLine("Slot not found\n");
        }
    }

    public void Status()
    {
        System.Console.WriteLine("Slot\tNo.\t\tType\tRegistration No Colour");
        foreach (var vehicle in lots)
        {
            System.Console.WriteLine(vehicle.Key + "\t" + vehicle.Value.plateNumber + "\t" + vehicle.Value.type + "\t" + vehicle.Value.color + "\n");
        }
    }

    public void CountVehiclesByType(string type)
    {
        if (!string.Equals(type, "mobil", StringComparison.OrdinalIgnoreCase) && !string.Equals(type, "motor", StringComparison.Ordinal))
        {
            System.Console.WriteLine("Sorry, only car and motorcycle can parking here\n");
            return;
        }
        else
        {
            System.Console.WriteLine(lots.Values.Count(vehicle => vehicle.type == type) + "\n");
        }

    }

    public void SortPlateNumberByOdd()
    {
        List<string> oddPlates = [];

        foreach (var vehicle in lots.Values)
        {
            var digits = vehicle.plateNumber.Where(char.IsDigit).ToArray();
            if (digits.Length == 0) continue;
            int lastDigit = digits.Last() - '0';

            if (lastDigit % 2 == 1)
            {
                oddPlates.Add(vehicle.plateNumber);
            }
        }
        if (oddPlates.Count > 0)
        {
            foreach (var plateNumber in oddPlates)
            {
                System.Console.WriteLine(plateNumber);
            }
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Not found\n");
        }
    }
    public void SortPlateNumberByEvent()
    {
        List<string> eventPlates = [];

        foreach (var vehicle in lots.Values)
        {
            var digits = vehicle.plateNumber.Where(char.IsDigit).ToArray();
            if (digits.Length == 0) continue;
            int lastDigit = digits.Last() - '0';

            if (lastDigit % 2 == 0)
            {
                eventPlates.Add(vehicle.plateNumber);
            }
        }
        if (eventPlates.Count > 0)
        {
            foreach (var plateNumber in eventPlates)
            {
                System.Console.WriteLine(plateNumber);
            }
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Not found\n");
        }
    }
    public void SortPlateNumberByColor(string color)
    {
        List<string> platesByColor = [];

        foreach (var vehicle in lots.Values)
        {
            if (string.Equals(vehicle.color, color, StringComparison.OrdinalIgnoreCase))
            {
                platesByColor.Add(vehicle.plateNumber);
            }
        }
        if (platesByColor.Count > 0)
        {
            foreach (var plateNumber in platesByColor)
            {
                System.Console.WriteLine(plateNumber);
            }
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Not found\n");
        }
    }
    public void SortSlotByColor(string color)
    {
        List<int> slotByColor = [];

        foreach (var vehicle in lots)
        {
            if (string.Equals(vehicle.Value.color, color, StringComparison.OrdinalIgnoreCase))
            {
                slotByColor.Add(vehicle.Key);
            }
        }
        if (slotByColor.Count > 0)
        {
            foreach (var slotNumber in slotByColor)
            {
                System.Console.WriteLine(slotNumber);
            }
            System.Console.WriteLine();
        }
        else
        {
            System.Console.WriteLine("Not found\n");
        }
    }
    public void SearchSlotByPlateNumber(string plateNumber)
    {
        bool found = false;
        foreach (var vehicle in lots)
        {
            if (string.Equals(vehicle.Value.plateNumber, plateNumber, StringComparison.OrdinalIgnoreCase))
            {
                System.Console.WriteLine(vehicle.Key);
                found = true;
                break;
            }
            System.Console.WriteLine();
        }
        if (!found)
        {
            System.Console.WriteLine("Not Found\n");
        }
    }
}
