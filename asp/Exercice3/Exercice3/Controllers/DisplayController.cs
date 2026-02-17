using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3.Controllers
{
    internal class DisplayController : Controller
    {

        public IActionResult Index()
        {
            string prenom = "fred";
            int age = 54;

            List<string> hobbies = new List<string>()
            {
                "Informatique","Musique"
            };

            ViewData["Prenom"] = prenom;
            ViewData["Age"] = age;
            ViewData["hobbies"] = hobbies;


            return View();
        }
    }
}







}
}
