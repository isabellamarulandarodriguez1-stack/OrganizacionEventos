using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrganizaciónEventos.Models;

namespace OrganizaciónEventos.Controllers;

public class HomeController : Controller
{
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

 public IActionResult RegistrosVisitantes()
{
    if (HttpContext.Session.GetString("EventoRegistrado") != "true")
    {
        return RedirectToAction("Crear", "Evento");
    }

    return View("RegistroVisitantes"); // O simplemente puedes dejar solo return View(); si el archivo se llama exactamente igual que el método.
}


// Recibe los datos cuando el usuario completa el formulario y elige el pago
[HttpPost]
public IActionResult ProcesarPago(RegistroVisitanteViewModel modelo)
{
    // Aquí puedes guardar los datos temporalmente o pasarlos a una vista de éxito
    TempData["Mensaje"] = $"¡Registro exitoso para {modelo.NombreCompleto}! Método de pago seleccionado: {modelo.MetodoPago}.";
    return RedirectToAction("RegistrosVisitantes");
}
}