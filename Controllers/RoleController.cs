using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Database.Models;

namespace Database.Controllers;

public class RoleController : Controller
{
    private readonly ILogger<RoleController> _logger;

    public RoleController(ILogger<RoleController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
