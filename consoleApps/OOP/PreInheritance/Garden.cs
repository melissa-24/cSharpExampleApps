class Garden {
    public string GardenName;
    public int GardenCapacity;
    public List<Plant> AllPlants;

    public Garden(string theGarden) {
        GardenName = theGarden;
        GardenCapacity = 20;
        AllPlants = new List<Plant>();
    }

    public void GardenAdded() {
        Console.WriteLine("A new Garden has been added");
    }
    public void GardenInfo() {
        Console.WriteLine($"{GardenName} has a Capacity of {GardenCapacity} plants");
    }
    public void ShowPlants() {
        foreach(var plant in AllPlants) {
            Console.WriteLine($"{plant.PlantName} is in {GardenName}");
        }
    }
}