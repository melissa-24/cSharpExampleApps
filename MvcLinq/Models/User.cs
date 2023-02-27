#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace MvcLinq.Models;

public class User {
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string Username {get; set;}

    public User() {}
    public User(string theFirst, string theLast, string theUsername) {
        FirstName = theFirst;
        LastName = theLast;
        Username = theUsername;
    }

    public string AUser() {
        return $@"
            First Name: {FirstName}
            Last Name: {LastName}
            Username: {Username}
        ";
    }
}