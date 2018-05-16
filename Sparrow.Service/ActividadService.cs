using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sparrow.Domain;
using Sparrow.Repository;

namespace Sparrow.Service
{
    public class ActividadService : IActividadService
    {
        IActividadRepository repository;
        public ActividadService()
        {
            repository = new ActividadRepository();
        }
        public void agregarActividad(Actividad actividad)
        {
            repository.agregarActividad(actividad);
        }

        public IEnumerable<Object> listarActividades()
        {
            return repository.listarActividades();
        }

        public IEnumerable<Object> listarActividades(DateTime fechaInicio, DateTime fechaFin)
        {
            return repository.listarActividades(fechaInicio, fechaFin);
        }
    }
}
