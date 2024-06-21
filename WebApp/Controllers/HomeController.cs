using Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        Sistema s = Sistema.GetInstancia();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string ema, string contra)
        {
            Empleado buscado = s.Login(ema, contra);
            if(buscado != null) {

                HttpContext.Session.SetInt32("UsuarioId", buscado.Id);
                HttpContext.Session.SetString("UsuarioNombre", buscado.Nombre);
                HttpContext.Session.SetString("UsuarioRol", buscado.GetType().Name);
                return RedirectToAction("Index", "Home");
            }
            else 
            {
                ViewBag.msg = "Datos incorrectos";
                return View();
            }

        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult NoAutorizado()
        {
            return View();
        }
    }
}
