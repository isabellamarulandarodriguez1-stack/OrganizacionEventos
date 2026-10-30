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

 public IActionResult RegistroVisitantes()
{
    if (HttpContext.Session.GetString("EventoRegistrado") != "true")
    {
        return RedirectToAction("Crear", "Evento");
    }

    return View("RegistroVisitantes");
}



[HttpPost]
public IActionResult ProcesarPago(RegistroVisitanteViewModel modelo)
{
   
    TempData["Mensaje"] = $"¡Registro exitoso para {modelo.NombreCompleto}! Método de pago seleccionado: {modelo.MetodoPago}.";
    return RedirectToAction("RegistroVisitantes");
}
}