using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Graficas.WEB.Models;
using Graficas.Models.Analitica;

namespace Graficas.WEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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

        [HttpGet("GetAnalitica")]
        [Produces("application/json")]
        public IActionResult GetAnalitica()
        {
            List<ItemDTO> Result = new List<ItemDTO>();
            using (BLL.Analitica.ObtieneDatos Metodo = new BLL.Analitica.ObtieneDatos())
            {
                Result = Metodo.GetDatos();
            }
            if (!Result.Any())
            {
                return NotFound("No se encontraron datos");
            }
            return Ok(Result);
        }
    }
}
