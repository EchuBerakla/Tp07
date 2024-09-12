using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP07.Models;

namespace TP07.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
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

        ViewBag.categorias = Juego.ObtenerCategor(); 
        ViewBag.dificultades = Juego.ObtenerDificult(); 
        return View("ConfigurarJuego");
    }

    public IActionResult Comenzar(string username, int dificultad, int categoria) {
        
        Juego.CargarPartida(username, dificultad, categoria);
        return RedirectToAction("Jugar"); 
    }

    public IActionResult Ayuda() {

        return RedirectToAction("Jugar"); 
    }

    public IActionResult Jugar() {
        
        //CARGAR VIEW BAGS DE: 
        
        return View("Juego");
    }

    [HttpPost] 
    public IActionResult VerificarLaRespuesta(int idPregunta, int idRespuesta){

        ViewBag.Correcta = Juego.VerificarRespuesta(idRespuesta);
        return View("Respuesta");
    }

public IActionResult Fin()
{
    ViewBag.Username = Juego.ObtenerNombre();
    ViewBag.Puntaje = Juego.ObtenerPuntaje();
    return View();
}
}

