using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;
using Proyecto.Repositories;

namespace Proyecto.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {

            EquipoRepository repository = new EquipoRepository();
            var equipos = repository.DevuelveListadoEquipo();
            return View(equipos);

        }
    }
}
