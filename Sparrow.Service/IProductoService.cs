using Sparrow.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparrow.Service
{
    public interface IProductoService
    {
        IEnumerable<Object> ListarProductos();
        IEnumerable<Object> ListarProductos(string ingredientes, string elaborados, string unitarios, bool alarma);
        void agregarProducto(Producto producto);
        void editarProducto(Producto producto);
        void eliminarProducto(int ID);
        Producto obtenerProducto(int id);
    }
}
