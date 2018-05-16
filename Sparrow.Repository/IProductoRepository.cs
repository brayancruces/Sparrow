using Sparrow.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparrow.Repository
{
    public interface IProductoRepository
    {
        IEnumerable<Object> ListarProductos();
        IEnumerable<Object> ListarProductos(bool ingredientes, bool elaborados, bool unitarios, bool alerta);
        void agregarProducto(Producto producto);
        void editarProducto(Producto producto);
        void eliminarProducto(int ID);
    }
}
