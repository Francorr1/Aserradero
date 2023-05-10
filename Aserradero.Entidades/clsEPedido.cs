using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsEPedido
    {

//ATRIBUTOS DEL OBJETO clsEPedido
        public int id { get; set; }
        public string fechaSolicitud { get; set; }
        public string fechaLimite { get; set; }
        public int[] cantidadEntregada { get; set; }
        public int[] cantidadSolicitada { get; set; }
        public bool completado { get; set; }
        public clsECliente entidadCliente { get; set; }
        public clsEUsuario entidadUsuario { get; set; }
        public clsEProducto[] coleccionProductos { get; set; }

//ARMADO DEL OBJETO clsEPedido
        public clsEPedido armarPedido(int id, string fehcaSolicitud, string fechaLimite, int[] cantidadEntregada, int[] cantidadSolicitada , bool completado, clsECliente entidadCliente, clsEUsuario entidadUsuario, clsEProducto[] coleccionProductos)
        {
            clsEPedido entidadPedido = new clsEPedido();

            entidadPedido.id = id;
            entidadPedido.fechaSolicitud = fechaSolicitud;
            entidadPedido.fechaLimite = fechaLimite;
            entidadPedido.cantidadEntregada = cantidadEntregada;
            entidadPedido.cantidadSolicitada = cantidadSolicitada;
            entidadPedido.completado = completado;
            entidadPedido.entidadCliente = entidadCliente;
            entidadPedido.entidadUsuario = entidadUsuario;
            entidadPedido.coleccionProductos = coleccionProductos;

            return entidadPedido;
        }

//DESARMADO DEL OBJETO clsEPedido EN UN clsEPedidoSimple
        public class clsEPedidoSimple
        {

            //ATRIBUTOS DEL OBJETO clsEPedidoSimple
            public bool seleccionado { get; set; }
            public string solicitado { get; set; }
            public string limite { get; set; }
            public string cantidadEntregada { get; set; }
            public string productos { get; set; }
            public string cantidadSolicitada { get; set; }
            public string completado { get; set; }
            public string cliente { get; set; }
            public string usuario { get; set; }

            //DESARMADO DEL OBJETO clsEPedido
            public clsEPedidoSimple[] desarmarPedido(clsEPedido[] coleccionPedidos)
            {
                clsEPedidoSimple[] coleccionPedidosSimples = new clsEPedidoSimple[coleccionPedidos.Length];
                clsEPedidoSimple entidadPedidoSimple = new clsEPedidoSimple();

                for (int cont = 0; cont < coleccionPedidos.Length; cont++)
                {
                    string productos = "", solicitada = "", entregada = "";

                    entidadPedidoSimple.solicitado = coleccionPedidos[cont].fechaSolicitud;
                    entidadPedidoSimple.limite = coleccionPedidos[cont].fechaLimite;

                    //Se desarman las cantidades entregadas
                    entregada = coleccionPedidos[cont].cantidadEntregada[0].ToString();
                    if (coleccionPedidos[cont].cantidadEntregada.Length > 0) {
                        for (int subCont = 1; subCont < coleccionPedidos[cont].cantidadEntregada.Length; subCont++)
                        {
                            entregada = entregada + "\n" + coleccionPedidos[cont].cantidadEntregada[subCont].ToString();
                        }
                    }
                    entidadPedidoSimple.cantidadEntregada = entregada;

                    //Se desarman las cantidades solicitadas
                    solicitada = coleccionPedidos[cont].cantidadSolicitada[0].ToString();
                    if (coleccionPedidos[cont].cantidadSolicitada.Length > 0) {
                        for (int subCont = 1; subCont < coleccionPedidos[cont].cantidadSolicitada.Length; subCont++)
                        {
                            solicitada = solicitada + "\n" + coleccionPedidos[cont].cantidadSolicitada[subCont].ToString();
                        }
                    }
                    entidadPedidoSimple.cantidadSolicitada = solicitada;

                    //Se desarman el atributo completado
                    if (coleccionPedidos[cont].completado){
                        entidadPedidoSimple.completado = "✓";
                    }else
                    {
                        entidadPedidoSimple.completado = "✕";
                    }

                    entidadPedidoSimple.cliente = coleccionPedidos[cont].entidadCliente.nombre;
                    entidadPedidoSimple.usuario = coleccionPedidos[cont].entidadUsuario.nombre;

                    //Se desarman los productos
                    productos = coleccionPedidos[cont].coleccionProductos[0].tipo;
                    if (coleccionPedidos[cont].coleccionProductos.Length > 0) {
                        for (int subCont = 1; subCont < coleccionPedidos[cont].coleccionProductos.Length; subCont++)
                        {
                            productos = productos + "\n" + coleccionPedidos[cont].coleccionProductos[subCont].tipo;
                        }
                    }
                    entidadPedidoSimple.productos = productos;

                    entidadPedidoSimple.seleccionado = false;

                    coleccionPedidosSimples[cont] = entidadPedidoSimple;
                    entidadPedidoSimple = new clsEPedidoSimple();
                }

                return coleccionPedidosSimples;
            }

        }

    }
}
