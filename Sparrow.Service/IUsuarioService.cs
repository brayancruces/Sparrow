using Sparrow.Domain;

namespace Sparrow.Service
{
    public interface IUsuarioService
    {
        bool IniciarSesion(string username, string password);
        Usuario ObtenerUsuario(int ID);
    }
}
