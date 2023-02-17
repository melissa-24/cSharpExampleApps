class Flowering : Plant {
    public string BloomSeason;

    public Flowering(string thePlant, string theSeason) :base(thePlant) {
        BloomSeason = theSeason;
    }
}