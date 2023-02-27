public class Actor {
    public string FullName {get; set;}
    public int Age {get; set;}

    public Actor(string theName, int theAge) {
        FullName = theName;
        Age = theAge;
    }
}