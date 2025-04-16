using Proyecto.Models;
using System.Collections.Generic;
using System.Linq;

namespace Proyecto.Repositories
{
    public class EquipoRepository
    {
        private List<Equipo> equipos;

        public EquipoRepository()
        {
            // Inicializamos la lista una sola vez
            equipos = new List<Equipo>
        {
            new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosEmpatados = 2,
                PartidosPerdidos = 2
            },
            new Equipo
            {
                Id = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2
            }
        };
        }

        public IEnumerable<Equipo> DevuelveListadoEquipo()
        {
            return equipos.OrderBy(item => item.TotalPuntos).ToList();
        }

        public Equipo DevuelveInformacionEquipo(int Id)
        {
            return equipos.FirstOrDefault(item => item.Id == Id);
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            var existente = equipos.FirstOrDefault(e => e.Id == equipo.Id);
            if (existente != null)
            {
                existente.Nombre = equipo.Nombre;
                existente.PartidosJugados = equipo.PartidosJugados;
                existente.PartidosGanados = equipo.PartidosGanados;
                existente.PartidosEmpatados = equipo.PartidosEmpatados;
                existente.PartidosPerdidos = equipo.PartidosPerdidos;

                return true;
            }
            return false;
        }
    }

}
