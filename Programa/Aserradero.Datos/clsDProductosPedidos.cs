using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDProductosPedidos : clsHerramientasBD
    {

        //Se listan las cantidades entregadas del producto ingresado, en el pedido ingresado
        public int[] cantidadEntregada(int idPedido)
        {
            List<int> ids = new List<int>();
            int[] coleccionIds;
            int id;
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT cantidadEntregada FROM productospedidos WHERE idPedido = {idPedido}";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                id = datos.GetInt32("cantidadEntregada");
                ids.Add(id);
            }

            con.Close();

            coleccionIds = ids.ToArray();

            return coleccionIds;
        }

        //Se listan las cantidades solicitadas del producto ingresado, en el pedido ingresado
        public int[] cantidadSolicitada(int idPedido)
        {
            List<int> ids = new List<int>();
            int[] coleccionIds;
            int id;
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT cantidadSolicitada FROM productospedidos WHERE idPedido = {idPedido}";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                id = datos.GetInt32("cantidadSolicitada");
                ids.Add(id);
            }

            con.Close();

            coleccionIds = ids.ToArray();

            return coleccionIds;
        }

    }
}
