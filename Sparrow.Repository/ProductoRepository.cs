using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sparrow.Domain;

namespace Sparrow.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        SparrowDBEntities context;
        public ProductoRepository()
        {
            context = new SparrowDBEntities();
        }
        public void agregarProducto(Producto producto)
        {
            context.Producto.Add(producto);
            context.SaveChanges();
        }

        public void editarProducto(Producto producto)
        {
            var resultado = context.Producto.FirstOrDefault(x => x.Id == producto.Id);

            resultado.nombre = producto.nombre;
            resultado.medidaId = producto.medidaId;
            resultado.tipoId = producto.tipoId;
            context.SaveChanges();
        }

        public void eliminarProducto(int ID)
        {
            context.Producto.Remove(context.Producto.FirstOrDefault(x => x.Id == ID));
            context.SaveChanges();
        }

        public IEnumerable<object> ListarProductos()
        {
            var lista = context.Producto.Select(x => new
            {
                Id = x.Id,
                tipo = x.Tipo.nombre,
                nombre = x.nombre,
                medida = x.Medida.nombre,
                stock = x.stock,
                alertaStock = x.stock <= x.alertaStock ? true: false,
                costoUnitario = x.costoUnitario
            }).ToList();
            return lista;
        }

        public IEnumerable<object> ListarProductos(bool ingredientes, bool elaborados, bool unitarios, bool alerta)
        {
            var lista = context.Producto.Where(x => x.Tipo.nombre == "Brayan");
            if (ingredientes)
            {
                lista.Concat(context.Producto.Where(x => x.Tipo.nombre == "Ingredientes"));
            }
            if (elaborados)
            {
                lista.Concat(context.Producto.Where(x => x.Tipo.nombre == "Productos Elaborados"));
            }
            if (unitarios)
            {
                lista.Concat(context.Producto.Where(x => x.Tipo.nombre == "Productos Unitarios"));
            }
            if (alerta)
            {
                lista.Concat(context.Producto.Where(x => x.stock <= x.alertaStock));
            }
            else
            {
                lista.Concat(context.Producto.Where(x => x.stock > x.alertaStock));
            }
            return lista.Select(x => new
            {
                Id = x.Id,
                tipo = x.Tipo.nombre,
                nombre = x.nombre,
                medida = x.Medida.nombre,
                stock = x.stock,
                alertaStock = x.stock <= x.alertaStock ? true: false,
                costoUnitario = x.costoUnitario
            }).ToList();
        }
    }
}
