using Sparrow.Domain;
using Sparrow.Repository;

namespace Sparrow.Service
{
    public class UsuarioService : IUsuarioService
    {
        IUsuarioRepository repository;
        public UsuarioService()
        {
            repository= new UsuarioRepository();
        }
        public bool IniciarSesion(string username, string password)
        {
            return repository.IniciarSesion(username, password);
        }

        public Usuario ObtenerUsuario(int ID)
        {
            return repository.ObtenerUsuario(ID);
        }
    }
}
