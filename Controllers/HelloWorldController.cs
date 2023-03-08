using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tt.Models;

namespace tt.Controllers;

public class HelloWorldController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HelloWorldController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string nome, int ID=1)
    {
        ViewData["Mensagem"] = "Olá"+nome;
        ViewData["ID"] =ID;

        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View("Error");
    }
}
