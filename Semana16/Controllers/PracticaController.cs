using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana16.Controllers
{
    public class PracticaController : Controller
    {
        public IActionResult Index(string nombre, int edad, int añoNacimiento, int numTimes = 1)
        {
            ViewData["nombre"] = "Hola "+ nombre;
            ViewData["edad"] = "Tienes "+ edad;
            ViewData["añoNacimiento"] = "Naciste en el año"+ añoNacimiento;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
