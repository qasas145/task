namespace Database.Models;

public class Role
{

    public int Id{get;set;}
    public String RoleName{get;set;}
    public List<User> Users{get;set;}

}
