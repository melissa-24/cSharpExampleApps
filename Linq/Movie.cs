public class Movie {
    public string Title {get; set;}
    public string LeadActor {get; set;}
    public double Rating {get; set;}
    public int Year {get; set;}

    public Movie(string theTitle, string theLeadActor, double theRating, int theYear) {
        Title = theTitle;
        LeadActor = theLeadActor;
        Rating = theRating;
        Year = theYear;
    }

    public override string ToString()
    {
        return $@"
            Title: {Title}
            Lead Actor: {LeadActor}
            Rating: {Rating}
            Year: {Year}
        ";
    }


}

