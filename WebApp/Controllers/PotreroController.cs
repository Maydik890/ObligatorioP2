using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class PotreroController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UsuarioRol") != "Capataz")
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            IEnumerable<Potrero> lp = s.GetPotreroOrdenado();
            return View(lp);
        }
        public IActionResult AsignarPotrero(string id)
        {
            if (HttpContext.Session.GetString("UsuarioRol") != "Capataz")
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            ViewBag.Id = id;
            List<Potrero> lp = s.GetPotreros();
            return View(lp);
        }
        [HttpPost]
        public IActionResult AsignarPotrero(string ganId, int potId)
        {
            List<Potrero> lp = s.GetPotreros();
            try { 
                Ganado g = s.GetGanadoXId(ganId);
                Potrero p = s.GetPotreroXId(potId);
                p.AgregarGanado(g);
                ViewBag.msg = "Asignado con exito";
                return View(lp);
            }
            catch(Exception ex) 
            {
                ViewBag.msg = ex.Message;
                return View(lp);
            }
            
        }
    }
}
