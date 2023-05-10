using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsEProducto
    {

//ATRIBUTOS DEL OBJETO clsEProducto
        public int id { get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public clsEUsuario entidadUsuario { get; set; }

        //ARMADO DEL OBJETO clsEProducto
        public clsEProducto armarProducto(int id, string tipo, string descripcion, int stock, clsEUsuario entidadUsuario)
        {
            clsEProducto entidadProducto = new clsEProducto();

            entidadProducto.id = id;
            entidadProducto.tipo = tipo;
            entidadProducto.descripcion = descripcion;
            entidadProducto.stock = stock;
            entidadProducto.entidadUsuario = entidadUsuario;

            return entidadProducto;
        }

//DESARMADO DEL OBJETO clsEProducto EN UN clsEProductoSimple
        public class clsEProductoSimple
        {

            //ATRIBUTOS DEL OBJETO clsEProductoSimple
            public bool seleccionado { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
            public string stock { get; set; }
            public string usuario { get; set; }

            //DESARMADO DEL OBJETO clsEProducto
            public clsEProductoSimple[] desarmarProducto(clsEProducto[] coleccionProductos)
            {
                clsEProductoSimple[] coleccionProductosSimples = new clsEProductoSimple[coleccionProductos.Length];
                clsEProductoSimple entidadProductoSimple = new clsEProductoSimple();

                for(int cont = 0; cont < coleccionProductos.Length; cont++)
                {
                    entidadProductoSimple.seleccionado = false;
                    entidadProductoSimple.nombre = coleccionProductos[cont].tipo;
                    entidadProductoSimple.descripcion = coleccionProductos[cont].descripcion;
                    entidadProductoSimple.stock = Convert.ToString(coleccionProductos[cont].stock);
                    entidadProductoSimple.usuario = coleccionProductos[cont].entidadUsuario.nombre;

                    coleccionProductosSimples[cont] = entidadProductoSimple;
                    entidadProductoSimple = new clsEProductoSimple();
                }

                return coleccionProductosSimples;
            }

        }

    }
}
