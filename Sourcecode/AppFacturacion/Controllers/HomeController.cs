using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppFacturacion.Models;

namespace AppFacturacion.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["pres"]="Me presento, mi nombre es Víctor Andrés Pedraza, estudiante de quinto semestre de ingeniería de sistemas en la Universidad El Bosque.";
            ViewData["pres1"]="Este software hace referencia a la actividad de prueba como parte del proceso de selección en la empresa System Tecno Digital. Dicha actividad, trata sobre un software de facturación con funcionalidades básicas, donde se crean las diferentes facturas (con un producto facturado por obligación) y la capacidad de seguir facturando productos a facturas existentes.";
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
    }
}
