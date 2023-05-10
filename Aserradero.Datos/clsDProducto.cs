using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Aserradero.Entidades;

namespace Aserradero.Datos
{
    public class clsDProducto : clsHerramientasBD
    {

//RECREAR PRODUCTO
        protected clsEProducto recrearProducto(MySqlDataReader datos)
        {
            clsEProducto entidadProducto = new clsEProducto();
            clsDUsuario datosUsuario = new clsDUsuario();
            clsDStock datosStock = new clsDStock();
            clsEUsuario entidadUsuario;

            entidadProducto.id = datos.GetInt32("idProducto");
            entidadProducto.tipo = datos.GetString("tipoProducto");
            entidadProducto.descripcion = datos.GetString("descripcionProducto");

            //Se debe listar el usuario correspondiente al id recibido, con el fin de recrear ese usuario y asignarlo a este producto.
            entidadUsuario = datosUsuario.listarUsuarioParticular(datos.GetInt32("ciUsuario"));
            entidadProducto.entidadUsuario = entidadUsuario;

            //Se debe calcular el stock de este producto específico para poder definir la varibable "stock".
            entidadProducto.stock = datosStock.calcularStock(entidadProducto.id);

            return entidadProducto;
        }

//ALTA PRODUCTO
        public void altaProducto(clsEProducto entidadProducto)
        {
            string consulta;

            consulta = $"INSERT INTO producto (tipoProducto, descripcionProducto, ciUsuario) VALUES('{entidadProducto.tipo}', '{entidadProducto.descripcion}', {entidadProducto.entidadUsuario.ci})";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//MODIFICAR PRODUCTO
        public void modificarProducto(clsEProducto entidadProducto)
        {
            string consulta;

            consulta = $"UPDATE producto SET tipoProducto = '{entidadProducto.tipo}', descripcionProducto = '{entidadProducto.descripcion}', ciUsuario = {entidadProducto.entidadUsuario.ci} WHERE idProducto = {entidadProducto.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

#region LISTAR PRODUCTOS

    //Listar productos
        public List<clsEProducto> listarProductos()
        {
            List<clsEProducto> coleccionProductos = new List<clsEProducto>();
            clsEProducto entidadProducto = new clsEProducto();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM producto";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                entidadProducto = recrearProducto(datos);
                coleccionProductos.Add(entidadProducto);
            }

            con.Close();

            return coleccionProductos;
        }

    //Listar producto particular
        public clsEProducto listarProductoParticular(int id) //Duda sobre el tipo de dato en parámetros.
        {
            clsEProducto entidadProducto = new clsEProducto();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM producto WHERE idProducto = '{id}'";
            datos = ejecutarQueryLectura(consulta);

            if (datos.Read())
            {
                entidadProducto = recrearProducto(datos);
            }

            con.Close();

            return entidadProducto;
        }

    //Listar todos los productos de un pedido
        public clsEProducto[] productosEnPedido(int idPedido)
        {
            List<clsEProducto> coleccionProductos = new List<clsEProducto>();
            clsEProducto entidadProducto = new clsEProducto();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT producto.* FROM productospedidos JOIN producto ON productospedidos.idProducto = producto.idProducto WHERE productospedidos.idPedido = {idPedido}";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                entidadProducto = recrearProducto(datos);
                coleccionProductos.Add(entidadProducto);
            }

            con.Close();

            return coleccionProductos.ToArray();
        }
        #endregion

    }
}
