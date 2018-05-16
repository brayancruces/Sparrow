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
    }
}
