class Plant {
    public string PlantName;
    public string SunReqs;
    public int SpreadRate;
    public List<Garden> AllGardens;

    public Plant(string thePlant) {
        PlantName = thePlant;
        SunReqs = "Full";
        SpreadRate  = 2;
        AllGardens = new List<Garden>();

    }

    public void PrintPlantInfo() {
        Console.WriteLine($"The new plant is {PlantName}");
    }

    public void AddPlant(Plant PlantName, Garden ChosenGarden) {
        ChosenGarden.GardenCapacity -= this.SpreadRate;
    }
}