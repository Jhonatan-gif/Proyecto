using Proyecto.Models;

namespace Proyecto.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipo()
        {

            List<Equipo> equipos = new List<Equipo>();
            {
                Equipo ldu = new Equipo
                {
                    Id = 1,
                    Nombre = "LDU",
                    PartidosJugados = 10,
                    PartidosGanados = 6,
                    PartidosEmpatados = 2,
                    PartidosPerdidos = 2,
                    TotalPuntos = 30
                };

                Equipo bsc = new Equipo
                {
                    Id = 2,
                    Nombre = "BSC",
                    PartidosJugados = 10,
                    PartidosGanados = 5,
                    PartidosEmpatados = 3,
                    PartidosPerdidos = 2,
                    TotalPuntos = 3
                };
                equipos.Add(ldu);
                equipos.Add(bsc);

                return equipos;
            }

        }
    }
