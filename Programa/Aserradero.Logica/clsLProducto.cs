using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLProducto
    {
        
        // Instancia el objeto de la siguiente capa
        clsDProducto datosProducto = new clsDProducto();

        //ALTA PRODUCTOS
        public void altaProducto(clsEProducto ingresadoProducto)
        {
            datosProducto.altaProducto(ingresadoProducto); // Le envia a la siguiente capa el objeto entidad
        }

        //MODIFICAR PRODUCTOS        
        public void modificarProducto(clsEProducto ingresadoProducto)
        {
            datosProducto.modificarProducto(ingresadoProducto); // Le envia a la siguiente capa el objeto entidad
        }

        //LISTAR TODOS LOS PRODUCTOS
        public List<clsEProducto> listarProductos()
        {
            List<clsEProducto> coleccionProductos = new List<clsEProducto>(); // Declaro una lista de objetos de tipo entidad producto
            coleccionProductos = datosProducto.listarProductos(); // Se ejecuta la función y se guarda en la lista la información recibida

            if (coleccionProductos == null)
            {
                return null;
            }

            return coleccionProductos; // Devuelve la lista de entidades
        }
        
        //INFORME PRODUCTO ESPECIFICO
        public clsEProducto informeProducto(int idProducto)
        {
            clsEProducto productoParticular = new clsEProducto(); // Instancio un objeto de tipo entidad producto
            productoParticular = datosProducto.listarProductoParticular(idProducto); // Se ejecuta la función y se guarda en el objeto la información recibida

            if (productoParticular == null)
            {
                return null;
            }

            return productoParticular; //Devuelve el Producto
        }

    }

}
