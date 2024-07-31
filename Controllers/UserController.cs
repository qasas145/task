using Microsoft.AspNetCore.Mvc;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Controllers;

public class UserController : Controller
{
    private readonly AppDbContext _context;

    
    
    public UserController()
    {
        _context = new AppDbContext();
    }

    public IActionResult Index()
    {
        var users = _context.Users.ToList();
        return View(users);
    }

    public IActionResult Delete(int id){
        User user = _context.Users.SingleOrDefault(u =>u.Id == id);
        _context.Users.Remove(user);
        _context.SaveChanges();
        return Redirect("/user/index");
    }

    public IActionResult AddForm() {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Add(User user) {
        
        _context.Users.Add(user);
        _context.SaveChanges();
        return Redirect("/user/index");
    }
    // edit 
    public IActionResult EditForm(int id) {;
        User user = _context.Users.SingleOrDefault(u =>u.Id == id);
        if (user == null) {
            return NotFound();
        }
        return View(user);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult UpdateUser(int id,User new_user) {
        User user = _context.Users.SingleOrDefault(u=>u.Id == id);
        if (user == null) {return NotFound();}
        user.Name = new_user.Name;
        user.Age = new_user.Age;
        user.Email = new_user.Email;
        user.Password = new_user.Password;
        _context.SaveChanges();
        
        return Redirect("/user/index");
    }
    public IActionResult Details(int id) {
         var user = _context.Users
                .Include(u => u.Posts)  // Include related posts
                .SingleOrDefault(u => u.Id == id);
        return View(user);
    }
    public IActionResult GetMessage()
    {
        ViewBag.Name = Request.Cookies["Name"];
        return View();
    }
    public IActionResult MessageForm() {
        return View();
    }
    public IActionResult MessageHandler(String name, String message) {
        TempData["Message"] = message;
        CookieOptions obj = new CookieOptions{Expires = DateTime.Now.AddDays(3)};
        Response.Cookies.Append("Name", name, obj);
        return Redirect("/user/getmessage");
    }

}
