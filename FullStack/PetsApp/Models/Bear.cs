#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace PetsApp.Models;

public class Bear {
    [Key]
    public int BearId {get; set;}

    [Required]
    public string Title {get; set;}
    public string Img {get; set;} 
    public DateTime CreatedAt { get; set; } = DateTime.Now; 
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}