using System.Linq;
using Sparrow.Domain;
using Sparrow.Helpers;

namespace Sparrow.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SparrowDBEntities context;
        public UsuarioRepository()
        {
            context = new SparrowDBEntities();
        }

        public bool IniciarSesion(string username, string password)
        {
            var resultado = context.Usuario.Where(x => x.nombreUsuario == username && x.contraseña == password);
            bool respuesta = false;
            if (resultado.Count() > 0)
            {
                SessionHelper.userID = resultado.First().Id;
                respuesta = true;
            }
            return respuesta;
        }

        public Usuario ObtenerUsuario(int ID)
        {
            var usuario = context.Usuario.FirstOrDefault(x => x.Id == ID);
            return usuario;
        }
    }
}
