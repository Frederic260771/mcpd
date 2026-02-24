using Microsoft.AspNetCore.Mvc;
using Recette.Services;

namespace Recette.Controllers
{
    public class RecetteController : Controller
    {

        private readonly RecetteService _service;

        public RecetteController(RecetteService service)
        {
            _service = service;
        }

        public IActionResult All()
        {
            var recettes = _service.GetAll();
            return View(recettes);
        }

        public IActionResult Detail(int id)
        {
            var recette = _service.GetDetail(id);
            return View(recette);
        }






    }
}
