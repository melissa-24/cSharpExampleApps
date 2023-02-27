// Add this after doing the any function
void PrintEach(IEnumerable<dynamic> items, string msg = "") {
    Console.WriteLine("\n" + msg);
    foreach(var item in items) {
        Console.WriteLine(item.ToString());
    }
}



// Lambda functions using Linq
// Lambda allows us to query data collections

List<int> numbers = new List<int>() {
    5,6,8,12,34,56
};
List<int> numsOverTen = numbers.Where(num => num > 10).ToList();
// new list using where clause (like sql) 
// var = var > 10 is our condition
// .tolist is part of Linq that allows us to return a list
// /first or default can replace where (where will alsways return)

// Console.WriteLine(string.Join(", ", numsOverTen));
// this is how we can print the list more as a list

// Console.WriteLine("----------------------------------------");

// numbers is like our table where we are selecting all
// .where is that clause we add to the end of our sql query.


List<string> users = new List<string>() {
    "Emily", "Melissa", "Juli", "Brianna"
};
// Console.WriteLine(string.Join(", ", users));
int minNameLength = users.Min(user => user.Length);
// Console.WriteLine(minNameLength);

// Console.WriteLine("----------------------------------------");

List<Movie> movies = new List<Movie> {
    new Movie("Back to the Future", "Michael J. Fox", 10, 1985),
    new Movie("Back to the Future II", "Michael J. Fox", 10, 1986),
    new Movie("Back to the Future III", "Michael J. Fox", 10, 1988),
    new Movie("Star Trek", "Christopher Pine", 9, 2016),
    new Movie("The Martian", "Matt Damon", 7, 2015),
    new Movie("The Greatest Showman", "Hugh", 8, 2019),
    new Movie("Test Movie", "Test Actor", 6, 1980),
};
List<Actor> Actors = new List<Actor> {
    new Actor("Matt Damon", 48),
    new Actor("Zack Efron", 30),
};

// Will cause a server error
// Movie chosenMovie = movies.First(movie => movie.Title == "Start Trek");
// Movie chosenMovie = movies.First(movie =>  movie.Title == "Star Trek");

Movie? oneMovie = movies.FirstOrDefault(m => m.Title == "Star Trek");
// Movie? oneMovie = movies.FirstOrDefault(m => m.Title == "Start Trek");

// chosenMovie.ToString();

// if(oneMovie != null) {
//     Console.WriteLine(oneMovie.ToString());
// } else {
//     Console.WriteLine("Movie not in list");
// }

Console.WriteLine("----------------------------------------");

oneMovie = movies.FirstOrDefault(m => m.Rating == 10);
// if(oneMovie != null) {
//     Console.WriteLine(oneMovie.ToString());
// } else {
//     Console.WriteLine("Movie not in list");
// }

// Console.WriteLine("----------------------------------------");

Movie? oldestMovie = movies.FirstOrDefault(movie => movie.Year == movies.Min(m => m.Year));
// if(oldestMovie != null) {
//     Console.WriteLine(oldestMovie);
// } else {
//     Console.WriteLine("Movie not in list");
// }

// Console.WriteLine("----------------------------------------");

bool ratingOver9 = movies.Any(movie => movie.Rating >  9);
// Console.WriteLine($"are any movies rated above 9? {ratingOver9}");

// Console.WriteLine("----------------------------------------");

List<Movie> filterdMovies = movies.OrderByDescending(movie => movie.Title).ToList();
PrintEach(filterdMovies);

Console.WriteLine("----------------------------------------");

filterdMovies = movies.Where(movie => movie.LeadActor == "Michael J. Fox").OrderByDescending(movie => movie.Title).ToList();
// PrintEach(filterdMovies);

// Console.WriteLine("----------------------------------------");

filterdMovies = movies.Where(movie => movie.Title.StartsWith("T")).ToList();
// PrintEach(filterdMovies);

// Console.WriteLine("----------------------------------------");

var selected = movies.Select(m => m.Title);
// PrintEach(selected);

// Console.WriteLine("----------------------------------------");

selected = movies
    .Where(movie => movie.LeadActor == "Michael J. Fox")
    .Select(movie => movie.Title)
    .OrderBy(title => title)
    .ToList();
// PrintEach(selected);