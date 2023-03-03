#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FavoriteImages.Models;

public class Image {
    [Key]
    public int ImageId {get; set;}
    [Required]
    public string Name {get; set;}
    [Required]
    public string Img {get; set;}
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    public int UserId {get; set;} 
    public User? Owner {get; set;} 

}