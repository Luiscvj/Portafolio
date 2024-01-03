using Microsoft.AspNetCore.Mvc;
using Portafolio.Interfaces;
using Portafolio.Models;
using Portafolio.Services;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyecto _repositorioProyectos;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyecto repositorioProyectos, IConfiguration configuration)
        {
            _logger = logger;
            _repositorioProyectos = repositorioProyectos;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var apellido = _configuration.GetValue<string>("Apellido");
            List<Proyecto> ProyectosGenerados = _repositorioProyectos.ObtenerProyectos().Take(2).ToList();
            HomeViewModel model = new HomeViewModel()
            { 
                Proyectos = ProyectosGenerados
            };
            _logger.LogCritical("Este es un mensaje critico" + apellido);
            _logger.LogInformation("Este es un emnsaje del log");
            return View(model);
        }

        public IActionResult Contacto() 
        {
             return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel) 
        {
            return RedirectToAction("Gracias");
        }


        public IActionResult Gracias() 
        {
            return View();
        }
    
        public IActionResult Proyectos() 
        {
            var proyectos = _repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
