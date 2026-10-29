using Microsoft.AspNetCore.Mvc;
using OrganizacionEventos.Models;

namespace OrganizacionEventos.Controllers
{
    public class EventoController : Controller
    {
        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Evento evento)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("EventoRegistrado", "true");
                return View("Resultado", evento);
            }

            return View("Crear", evento);
        }
    }
}