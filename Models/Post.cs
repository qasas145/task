using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models;

public class Post
{

    public int Id{get;set;}
    public String Title{get;set;}
    public String Category{get;set;}
    public String Body{get;set;}
    public int Likes{get;set;}
    public int Shares{get;set;}

    [ForeignKey("User")]
    public int UserId{get;set;}
    public User User{get;set;}

}
