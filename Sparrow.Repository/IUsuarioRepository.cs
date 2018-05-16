using Sparrow.Domain;

namespace Sparrow.Repository
{
    public interface IUsuarioRepository
    {
        bool IniciarSesion(string username, string password);
        Usuario ObtenerUsuario(int ID);
    }
}
