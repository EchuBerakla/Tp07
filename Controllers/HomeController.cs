using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tp07.Models;

namespace Tp07.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View(Index);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult ConfigurarJuego() {

        ViewBag.categorias = BD.ObtenerCategorias(); // ???
        ViewBag.dificultades = BD.ObtenerDificultades(); // ???
        return View(ConfigurarJuego);
    }

    public IActionResult Ayuda() {

        return RedirectToAction(Jugar); // ????
    }

    public IActionResult Jugar() {

        ViewBag. PreguntaActual;

    }
}
