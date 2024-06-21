using Dominio;
using Microsoft.AspNetCore.Mvc;
using PagedList;

namespace WebApp.Controllers
{
    public class GanadoController : Controller
    {
        Sistema s = Sistema.GetInstancia();
       
        
        public IActionResult ListaGanado()
        {
            if (HttpContext.Session.GetString("UsuarioRol") is null)
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            List<Ganado> l = s.GetGanados();
           
            return View(l);
        }
        [HttpPost]
        public IActionResult ListaGanado(int Peso, string Tipo)
        {
            if (HttpContext.Session.GetString("UsuarioRol") !="Capataz")
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            List<Ganado> lg = s.GetGanadosXPesoTipo(Peso, Tipo);
           
            return View(lg);
        }
        public IActionResult Details(string id)
        {

            if (HttpContext.Session.GetString("UsuarioRol") is null)
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            Ganado g = s.GetGanadoXId(id);
            return View(g);
        }
        public IActionResult AsignarVacuna(string id)
        {
            if (HttpContext.Session.GetString("UsuarioRol") is null)
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            TempData["id"] = id;
            List<Vacuna> v = s.GetVacunas();
            return View(v);
        }
        [HttpPost]
        public IActionResult AsignarVacuna(string slcVacuna, string id)
        {
            if (HttpContext.Session.GetString("UsuarioRol") is null)
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            List<Vacuna> lv = s.GetVacunas();
            try
            {
                Vacuna v = s.GetVaunaXNombre(slcVacuna);
                Ganado g = s.GetGanadoXId(id);
                DateTime fecha = DateTime.Now;
                g.AltaVacunacion(v, fecha);
                ViewBag.msg = "Vacuna asignada correctamente";
                return View(lv);
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
                return View(lv);
            }
        }
        public IActionResult RegistrarBovino()
        {
            if (HttpContext.Session.GetString("UsuarioRol") != "Capataz")
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult RegistrarBovino(Bovino b)
        {
            try
            {
                s.AltaGanado(b);
                ViewBag.msg = "Registro de Bovino exitoso";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
                return View();
            }
        }
    }
}
