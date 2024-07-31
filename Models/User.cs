namespace Database.Models;

public class User
{

    public int Id{get;set;}
    public String Name{get;set;}
    public int Age{get;set;}
    public String Email{get;set;}
    public String Password {get;set;}


    // navagation
    public List<Role> Roles{get;set;}
    public List<Post> Posts{get;set;}
}
