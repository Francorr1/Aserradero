using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLPedido
    {

        // Instancia el objeto de la siguiente capa
        clsDPedido datosPedido = new clsDPedido();

        //ALTA PEDIDO
        public void altaPedido(clsEPedido ingresadoPedido)
        {
            datosPedido.altaPedido(ingresadoPedido); // Le envia a la siguiente capa el objeto entidad
        }

        //BAJA PEDIDO
        public void bajaPedido(clsEPedido ingresadoPedido)
        {
            datosPedido.bajaPedido(ingresadoPedido); // Le envia a la siguiente capa el objeto entidad
        }

        //ENTREGAR PRODUCTOS
        public void entregarProductos(clsEPedido ingresadoPedido)
        {
            datosPedido.entregarProductos(ingresadoPedido); // Le envia a la siguiente capa el objeto 
            completarPedidos(ingresadoPedido.id);
        }

        //COMPLETAR PEDIDOS
        public void completarPedidos(int idPedido)
        {
            int productosListos= 0 ; // Contador entero de la cantidad de productos listos dentro del pedido, inicia una posicion anterior a la del primer valor del array
            clsDPedido datosPedido = new clsDPedido(); // objeto que comunica con la capa de datos
            clsEPedido entidadPedido = datosPedido.informePedidoParticular(idPedido); // entidad que 

            for (int cont=0; cont < entidadPedido.cantidadSolicitada.Length; cont++) // recorre los array
            {
                if (entidadPedido.cantidadSolicitada[cont] == entidadPedido.cantidadEntregada[cont] ) // compara los valores de ambas cantidades 
                {
                    productosListos++;
                }
            }

            if (productosListos == entidadPedido.cantidadSolicitada.Length)
            {
                datosPedido.completarPedido(entidadPedido);
            }
 
        }

        //LISTAR TODOS LOS PEDIDO
        public List<clsEPedido> listarPedidos()
        {
            List<clsEPedido> coleccionPedidos = new List<clsEPedido>(); // Declaro una lista de objetos de tipo entidad pedido
            coleccionPedidos = datosPedido.listarPedidos(); // Se ejecuta la función y se guarda en la lista la información recibida

            if (coleccionPedidos == null)
            {
                return null;
            }

            return coleccionPedidos; // Devuelve la lista de entidades
        }

        //LISTAR PEDIDOS POR SU ATRIBUTO COMPLETADO
        public List<clsEPedido> listarPedidosPorCompletado(bool completado)
        {
            List<clsEPedido> coleccionPedidos = new List<clsEPedido>(); // Declaro una lista de objetos de tipo entidad pedido
            coleccionPedidos = datosPedido.listarPedidosCompletados(completado); // Se ejecuta la función y se guarda en la lista la información recibida

            if (coleccionPedidos == null)
            {
                return null;
            }

            return coleccionPedidos; // Devuelve la lista de entidades
        }

    }

}