using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercice1.Controllers
{
    public class RandomController : Controller
    {

        public IActionResult Index()
        {
            Random r = new Random();
            
            ViewData["NombreAleatoire"] = r.Next(1,101);

            return View();
        }

    }
}
