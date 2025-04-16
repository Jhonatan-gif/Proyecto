using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;
using Proyecto.Models;
using Proyecto.Repositories;

namespace Proyecto.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;
        public EquipoController() 
        { 
            _repository = new EquipoRepository();
        }

        public IActionResult List()
        {

            
            var equipos = _repository.DevuelveListadoEquipo();
            return View(equipos);
        }

        public IActionResult EditarEquipo(int Id)
        {
            
            var equipo = _repository.DevuelveInformacionEquipo(Id);
            return View(equipo);
        }
        [HttpPost]
        public IActionResult EditarEquipo(Equipo equipo)
        {
            try
            {
                var actualizado = _repository.ActualizarEquipo(equipo);
                if (actualizado)
                {
                    return RedirectToAction("List");
                }

                return View(equipo);
            }
            catch
            {
                return View(equipo);
            }
        }

    }
}
