using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var model = new HomeIndexViewModel { Proyectos = proyectos };
            return View(model);
        }
        private List<ProyectoViewModel> ObtenerProyectos()
        {
            return new List<ProyectoViewModel>() { 
            new ProyectoViewModel
            {
                Titulo = "vTorke",
                Descripcion = "CRM realizado en ASP.NET Framework",
                Link = "http://ferreagro.ddns.net:2323/",
                ImagenURL = "/img/pgvTorke.png"
            },
            new ProyectoViewModel
            {
                Titulo = "Sitio Web Motorke",
                Descripcion = "Pagina web realizada con HTML",
                Link = "http://www.motorke.com.mx",
                ImagenURL = "/img/pgMotorke.png"
            },
            new ProyectoViewModel
            {
                Titulo = "E-Commerce realizado en PrestaShop",
                Descripcion = "Pagina web administrada con PrestaShop",
                Link = "http://www.torke.com.mx",
                ImagenURL = "/img/pgTorke.png"
            }
            };
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