using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Database.Models;

namespace Database.Controllers;

public class PostController : Controller
{
    private readonly ILogger<PostController> _logger;

    public PostController(ILogger<PostController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }


    public IActionResult GetAll() {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

}
