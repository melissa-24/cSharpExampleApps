// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Garden {
    public string GardenName;
    public int GardenCapacity;

    public Garden(string theGarden, int theCapacity) {
        GardenName = theGarden;
        GardenCapacity = 20;
    }

    public void GardenAdded() {
        Console.WriteLine("A new Garden has been added");
    }
    public void GardenInfo() {
        Console.WriteLine($"{GardenName} has a Capacity of {GardenCapacity} plants");
    }

}

// Garden Honeybee = new Garden("Honeybee's Garden");