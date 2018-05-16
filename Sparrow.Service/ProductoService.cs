using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sparrow.Domain;
using Sparrow.Repository;

namespace Sparrow.Service
{
    public class ProductoService : IProductoService
    {
        IProductoRepository repository;
        public ProductoService()
        {
            repository = new ProductoRepository();
        }
        public void agregarProducto(Producto producto)
        {
            repository.agregarProducto(producto;
        }

        public void editarProducto(Producto producto)
        {
            repository.editarProducto(producto);
        }

        public void eliminarProducto(int ID)
        {
            repository.eliminarProducto(ID);
        }

        public IEnumerable<object> ListarProductos()
        {
            return repository.ListarProductos();
        }

        public IEnumerable<object> ListarProductos(bool ingredientes, bool elaborados, bool unitarios, bool alerta)
        {
            return repository.ListarProductos(ingredientes, elaborados, unitarios, alerta);
        }
    }
}
