using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sparrow.Domain;

namespace Sparrow.Repository
{
    public class ActividadRepository : IActividadRepository
    {
        SparrowDBEntities context;
        public ActividadRepository()
        {
            context = new SparrowDBEntities();
        }
        public void agregarActividad(Actividad actividad)
        {
            context.Actividad.Add(actividad);
            context.SaveChanges();
        }

        public IEnumerable<Object> listarActividades()
        {
            var lista = context.Actividad.Select(x => new
            {
                Id = x.Id,
                fechaHora = x.fechaHora,
                nombre = x.TipoActividad.nombre,
                usuario = x.Usuario.nombre,
                nota = x.nota
            });
            return lista.ToList();
        }

        public IEnumerable<Object> listarActividades(DateTime fechaInicio, DateTime fechaFin)
        {
            var lista = context.Actividad.Where(x => x.fechaHora >= fechaInicio && x.fechaHora <= fechaFin).Select(x => new
            {
                Id = x.Id,
                fechaHora = x.fechaHora,
                nombre = x.TipoActividad.nombre,
                usuario = x.Usuario.nombre,
                nota = x.nota
            });
            return lista.ToList();
        }
    }
}
