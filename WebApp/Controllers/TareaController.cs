using Microsoft.AspNetCore.Mvc;
using Dominio;
namespace WebApp.Controllers
{
    public class TareaController : Controller
    {

        Sistema s = Sistema.GetInstancia();
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult CompletarTarea(int id)
        {
            if (HttpContext.Session.GetString("UsuarioRol") != "Peon")
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            return View();
        }
        [HttpPost]
        public IActionResult CompletarTarea(string? comentario,int id)
        {
            try
            {
                int? uid = HttpContext.Session.GetInt32("UsuarioId");
                Peon p = s.GetPeonXId(uid);
                Tarea t = p.GetTareaXId(id);
                t.CompletarTarea(comentario);
                return RedirectToAction("Perfil","Empleado");
            }catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return View();
        }
        public IActionResult AsignarTareas(int id)
        {
            if (HttpContext.Session.GetString("UsuarioRol") != "Capataz")
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            ViewBag.Id = id;
            return View();
        }
        [HttpPost]
        public IActionResult AsignarTareas(Tarea t, int peonId)
        {
            try
            {
                Peon p = s.GetPeonXId(peonId);
                p.AltaTarea(t);
                ViewBag.msg = "Tarea asignada correctamente";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return View();
        }
        public IActionResult VerTareas(int id)
        {
            if (HttpContext.Session.GetString("UsuarioRol") != "Capataz")
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            Peon buscado = s.GetPeonXId(id);
            List<Tarea> t = buscado.GetTareas();
            return View(t);
        }
        public IActionResult VerTareasPeon(int id)
        {
            if (HttpContext.Session.GetString("UsuarioRol") != "Peon")
            {
                return RedirectToAction("NoAutorizado", "Home");
            }
            Peon buscado = s.GetPeonXId(id);

            return View(buscado);
        }
    }
}
