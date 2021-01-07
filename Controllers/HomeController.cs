using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontendTasks.Models;

namespace FrontendTasks.Controllers
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
            return View();
        }

        public IActionResult Tareas()
        {

            List<Tarea> tareas = new List<Tarea>()
            {
                new Tarea{descripcion="Hola",idPersona=1,idTarea=5,estado="Pendiente",prioridad="Alta",fecFinal="2020-12-24",fecInicio="2020-12-23",notas="Nada"}
            };
            return View(tareas);
        }
        public IActionResult AddTareas()
        {

            List<Tarea> tareas = new List<Tarea>()
            {
                new Tarea{descripcion="Hola",idPersona=1,idTarea=5,estado="Pendiente",prioridad="Alta",fecFinal="2020-12-24",fecInicio="2020-12-23",notas="Nada"}
            };
            return View(tareas);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class Tarea
    {
       public int idTarea{ get; set; }
       public string descripcion { get; set; } 
       public string estado { get; set; } 
       public string prioridad { get; set; } 
       public string fecInicio { get; set; } 
       public string fecFinal { get; set; } 
       public int idPersona { get; set; } 
       public string notas { get; set; } 

        public void getNamePerson() { }
    }
}
