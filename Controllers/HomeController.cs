using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FrontendTasks.Models;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Dynamic;

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
        
        public List<Tarea> GetTareas()
        {

            List<Tarea> tareas = new List<Tarea>();

            string url = @"https://localhost:44376/api/Services/tasks";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                tareas = JsonConvert.DeserializeObject<List<Tarea>>(json);
            }

            return tareas;

        }
        public List<Persona> GetPersonas()
        {

            List<Persona> personas = new List<Persona>();

            string url = @"https://localhost:44376/api/Services/people";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                personas = JsonConvert.DeserializeObject<List<Persona>>(json);

            }

            return personas;

        }

        public IActionResult Tareas()
        {

            dynamic mymodel = new ExpandoObject();
            mymodel.Tareas = GetTareas();
            mymodel.Personas = GetPersonas();
            return View(mymodel);

        }
        public IActionResult EditTareas()
        {

            dynamic mymodel = new ExpandoObject();
            mymodel.Tareas = GetTareas();
            mymodel.Personas = GetPersonas();
            return View(mymodel);

        }
        public  IActionResult Insertado(string description, string priority,string state, int person, string fecInicio,string fecFinal,string notes)
        {
            string resultado;
            try
            {

                string url = "https://localhost:44376/api/Services/insertTask" + person + "*" + description + "*" + state + "*" + priority + "*" + fecInicio + "*" + fecFinal + "*" + "-"+notes;

                WebRequest request = WebRequest.Create(url);
                request.Method = "POST";
                string postData = "This is a test that posts this string to a Web server.";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                using (dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    resultado = responseFromServer;
                    Console.WriteLine(responseFromServer);
                }
                response.Close();
            }
            catch (Exception e)
            {
                resultado = "false";
                ViewBag.result = resultado;
                return View();
            }

            ViewBag.result = resultado;
            return View();
        }

        public IActionResult Actualizado(int idTask,string description, string priority, string state, int person, string fecInicio, string fecFinal, string notes)
        {
            string resultado;
            DateTime DateInicio = Convert.ToDateTime(fecInicio);
            DateTime DateFinal = Convert.ToDateTime(fecFinal);
            string fecInicioFormatted = DateInicio.ToString("yyyy-MM-dd");
            string fecFinalFormatted = DateFinal.ToString("yyyy-MM-dd");

            try
            {

                string url = "https://localhost:44376/api/Services/updateTask"+idTask+"*"+ person + "*" + description + "*" + state + "*" + priority + "*" + fecInicioFormatted + "*" + fecFinalFormatted + "*" + "-" + notes;

                WebRequest request = WebRequest.Create(url);
                request.Method = "PUT";
                string postData = "This is a test that posts this string to a Web server.";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                using (dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    resultado = responseFromServer;
                    Console.WriteLine(responseFromServer);
                }
                response.Close();
            }
            catch (Exception e)
            { 
                resultado = "false";
                ViewBag.result = resultado;
                return View();
            }



            ViewBag.result = resultado;
            return View();
        }

        public IActionResult Eliminado(int idTask)
        {
            string resultado;
            try
            {

                string url = "https://localhost:44376/api/Services/deleteTask"+idTask;

                WebRequest request = WebRequest.Create(url);
                request.Method = "DELETE";
                string postData = "This is a test that posts this string to a Web server.";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                using (dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    resultado = responseFromServer;
                    Console.WriteLine(responseFromServer);
                }
                response.Close();
            }
            catch (Exception e)
            {
                resultado = "false";
                ViewBag.result = resultado;
                return View();
            }



            ViewBag.result = resultado;
            return View();
        }
        public IActionResult AddTareas()
        {
            ViewBag.crimeRef = "hola amigos";
            dynamic mymodel = new ExpandoObject();
            mymodel.Personas = GetPersonas();
            return View(mymodel);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}
