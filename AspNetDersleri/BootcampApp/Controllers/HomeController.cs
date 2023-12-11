using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BootcampApp.Models;

namespace BootcampApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {        
        return View(Repository.Bootcamps);
    }
}
