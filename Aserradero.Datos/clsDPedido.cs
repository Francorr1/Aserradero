using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDPedido : clsHerramientasBD
    {

//RECREAR PEDIDO
        private clsEPedido recrearPedido(MySqlDataReader fila)
        {
            clsEPedido entidadPedido = new clsEPedido();
            clsDCliente datosCliente = new clsDCliente();
            clsDUsuario datosUsuario = new clsDUsuario();
            clsDProducto datosProducto = new clsDProducto();
            clsDProductosPedidos datosProductosPedidos = new clsDProductosPedidos();
            clsECliente entidadCliente;
            clsEUsuario entidadUsuario;
            clsEProducto[] coleccionProductos;

            entidadPedido.id = fila.GetInt32("idPedido");
            
            entidadPedido.fechaSolicitud = desarmarDate(fila.GetString("fechaSolicitud"));
            
            entidadPedido.fechaLimite = desarmarDate(fila.GetString("fechaLimite"));

            entidadPedido.completado = fila.GetBoolean("completadoPedido");

            //Se debe listar el cliente correspondiente al id recibido, con el fin de recrear ese cliente y asignarlo a este pedido.
            entidadCliente = datosCliente.listarClienteParticular(fila.GetInt32("idCliente"));
            entidadPedido.entidadCliente = entidadCliente;

            //Se debe listar el cliente correspondiente al id recibido, con el fin de recrear ese cliente y asignarlo a este pedido.
            entidadUsuario = datosUsuario.listarUsuarioParticular(fila.GetInt32("ciUsuario"));
            entidadPedido.entidadUsuario = entidadUsuario;

            //Se le deben asignar todos los productos que el pedido a recrear tiene asignados
            coleccionProductos = datosProducto.productosEnPedido(entidadPedido.id);
            entidadPedido.coleccionProductos = coleccionProductos;

            //Se deben asignar las cantidades entregadas de cada uno de los productos asignados
            entidadPedido.cantidadEntregada = datosProductosPedidos.cantidadEntregada(entidadPedido.id);

            //Se deben asignar las cantidades solicitadas de cada uno de los productos asignados
            entidadPedido.cantidadSolicitada = datosProductosPedidos.cantidadSolicitada(entidadPedido.id);

            return entidadPedido;
        }

//ALTA PEDIDO
        public void altaPedido(clsEPedido entidadPedido)
        {
            string consulta;

            consulta = $"INSERT INTO pedido (fechaSolicitud, fechaLimite, idCliente, ciUsuario) VALUES('{entidadPedido.fechaSolicitud}', '{entidadPedido.fechaLimite}', {entidadPedido.entidadCliente.id}, {entidadPedido.entidadUsuario.ci})";
            ejecutarQuery(consulta);

            con.Close();

            //Al hacer un alta de un pedido, se debe hacer un alta de un productopedido. Se realiza a continuación
            for (int cont = 0; cont < entidadPedido.coleccionProductos.Length; cont++)
            {                                                                                               /*Abajo falta la cantidad entregada, ahora no hay tiempo para eso*/
                consulta = $"INSERT INTO productospedidos VALUES({entidadPedido.coleccionProductos[cont].id}, (SELECT MAX(idPedido) FROM pedido), 0, {entidadPedido.cantidadSolicitada[cont]})";
                ejecutarQuery(consulta);

                con.Close();
            }
            return;
        }

//BAJA PEDIDO
        public void bajaPedido(clsEPedido entidadPedido)
        {
            string consulta;

            consulta = $"UPDATE pedido SET bajaPedido = TRUE WHERE idPedido = {entidadPedido.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//COMPLETAR PEDIDO
        public void completarPedido(clsEPedido entidadPedido)
        {
            string consulta;

            consulta = $"UPDATE pedido SET completadoPedido = TRUE WHERE idPedido = {entidadPedido.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//ENTREGAR PRODUCTOS DE UN PEDIDO
        public void entregarProductos(clsEPedido entidadPedido)
        {
            string consulta;

            for (int cont = 0; cont < entidadPedido.coleccionProductos.Length; cont++)
            {
                consulta = $"UPDATE productospedidos SET cantidadEntregada = cantidadEntregada + {entidadPedido.cantidadEntregada[cont]} WHERE idPedido = {entidadPedido.id} AND idProducto = {entidadPedido.coleccionProductos[cont].id}";
                ejecutarQuery(consulta);

                con.Close();
            }

            return;
        }

#region LISTAR PEDIDOS

    //Listar todos los pedidos.
        public List<clsEPedido> listarPedidos()
        {
            List<clsEPedido> coleccionPedidos = new List<clsEPedido>();
            clsEPedido entidadPedido = new clsEPedido();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM pedido WHERE bajaPedido = FALSE";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                entidadPedido = recrearPedido(datos);
                coleccionPedidos.Add(entidadPedido);

            }

            con.Close();

            return coleccionPedidos;
        }

    //Listar pedido por su atributo "Completado"
        public List<clsEPedido> listarPedidosCompletados(bool completado)
        {
            List<clsEPedido> coleccionPedidos = new List<clsEPedido>();
            clsEPedido entidadPedido = new clsEPedido();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM pedido WHERE completadoPedido = {completado} AND bajaPedido = FALSE";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                entidadPedido = recrearPedido(datos);
                coleccionPedidos.Add(entidadPedido);
            }

            con.Close();

            return coleccionPedidos;
        }

        //Informe pedido particular
        public clsEPedido informePedidoParticular(int idPedido)
        {
            clsEPedido entidadPedido = new clsEPedido();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM pedido WHERE idPedido = {idPedido}";
            datos = ejecutarQueryLectura(consulta);

            if (datos.Read())
            {
                entidadPedido = recrearPedido(datos);
            }

            con.Close();

            return entidadPedido;
        }

        #endregion

    }
}