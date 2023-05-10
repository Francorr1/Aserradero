using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    class clsDStock : clsHerramientasBD
    {

        //Método para calcular el stock de un producto dado
        public int calcularStock(int idProducto)
        {
            con.Close();

            MySqlDataReader datos;
            string consulta;
            int cantidadLote, cantidadPedido, stock;

            //Calculo de la cantidad de ese producto en los lotes
            consulta = $"SELECT SUM(lote.cantidadProducto) AS cantidadLote FROM lote WHERE lote.idProducto = {idProducto}";

            datos = ejecutarQueryLectura(consulta);

            if (datos.Read() && !datos.IsDBNull(0))
            {
                cantidadLote = datos.GetInt32("cantidadLote");
            }else
            {
                cantidadLote = 0;
            }

            con.Close();

            //Calculo de la cantidad entregada de ese producto en los pedidos
            consulta = $"SELECT SUM(productospedidos.cantidadEntregada) AS cantidadPedido FROM productospedidos WHERE productospedidos.idProducto = {idProducto}";

            datos = ejecutarQueryLectura(consulta);

            if (datos.Read() && !datos.IsDBNull(0))
            {
                cantidadPedido = datos.GetInt32("cantidadPedido");
            }
            else
            {
                cantidadPedido = 0;
            }

            con.Close();

            //Resultado del stock actual de ese producto
            stock = cantidadLote - cantidadPedido;

            return stock;
        }

    }
}
