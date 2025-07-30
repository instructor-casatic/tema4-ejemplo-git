using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClinicaApp.Models;

namespace ClinicaApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
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
    public IActionResult Odontologia()
    {
        return View();
    }
    public IActionResult Contactanos()
    {
        return View();
    }

    public IActionResult Servicios()
    {
        return View();
    }

[HttpPost]

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
