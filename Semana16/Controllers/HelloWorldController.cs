using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Semana16.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Bienvenida(string name, int numTimes = 1)
        {
            ViewData["name"] = "Hola {name}";
            ViewData["numTimes"] = numTimes;
            return View();
        }

        public string parameters(string name, int edad)
        {
            return HtmlEncoder.Default.Encode($"Hola {name}, tu edad es: {edad}");
        }
    }
}
