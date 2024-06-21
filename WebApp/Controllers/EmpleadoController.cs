using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class EmpleadoController : Controller
    {
        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Peon p)
        {
            try
            {
                s.AltaEmpleado(p);
                ViewBag.msg = "Registro Exitoso";
            }
            catch (Exception ex)
            {
                ViewBag.msg = "Error: " + ex.Message;
            }
            return View();
        }
        //Capataz
        public IActionResult ListarPeones()
        {
            if (HttpContext.Session.GetString("UsuarioRol") != "Capataz")
            {
                return RedirectToAction("NoAutorizado","Home");
            }
            List<Peon> l = s.GetPeones();
            return View(l);
        }
        
       
        
        
        //Peon
        public IActionResult Perfil()
        {
            int? uid = HttpContext.Session.GetInt32("UsuarioId");
            Peon p = s.GetPeonXId(uid);
            return View(p);
        }

        
    }
}
