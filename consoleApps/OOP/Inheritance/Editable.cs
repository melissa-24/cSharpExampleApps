class Editable : Plant {
    public string Category;
    public string HarvestTime;

    public Editable(string thePlant, string theCategory, string theHarvest) :base(thePlant) {
        Category = theCategory;
        HarvestTime = theHarvest;
    }
}