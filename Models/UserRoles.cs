using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Database.Models;

[PrimaryKey("UserId", "RoleId")]
public class UserRoles
{
    [ForeignKey("User")]
    public int UserId { get; set;}

    [ForeignKey("Role")]
    public int RoleId { get; set;}

    // navagation
    public User User{get;set;}
    public Role Role{get;set;}
}
