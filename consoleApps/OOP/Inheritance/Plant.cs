class Plant {
    public string PlantName;

    public Plant(string thePlant) {
        PlantName = thePlant;
    }

    public void PrintPlantInfo() {
        Console.WriteLine($"The new plant is {PlantName}");
    }
}