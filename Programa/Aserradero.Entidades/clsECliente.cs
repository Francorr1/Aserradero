using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsECliente
    {

//ATRIBUTOS DEL OBJETO clsECliente
        public int id { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public string fechaInscripcion { get; set; }

//ARMADO DEL OBJETO clsECliente
        public clsECliente armarCliente(int id, string nombre, string ubicacion, string fechaInscripcion)
        {
            clsECliente entidadCliente = new clsECliente();

            entidadCliente.id = id;
            entidadCliente.nombre = nombre;
            entidadCliente.ubicacion = ubicacion;
            entidadCliente.fechaInscripcion = fechaInscripcion;

            return entidadCliente;
        }

//DESARMADO DEL OBJETO clsECliente EN UN clsEClienteSimple
        public class clsEClienteSimple
        {

            //Atributos del objeto clsEClienteSimple
            public bool seleccionado { get; set; }
            public string nombre { get; set; }
            public string ubicacion { get; set; }
            public string inscripcion { get; set; }

            //Desarmado del objeto clsEClienteSimple
            public clsEClienteSimple[] desarmarCliente(clsECliente[] coleccionClientes)
            {
                clsEClienteSimple[] coleccionClientesSimples = new clsEClienteSimple[coleccionClientes.Length];
                clsEClienteSimple entidadClienteSimple = new clsEClienteSimple();

                for (int cont = 0; cont < coleccionClientes.Length; cont++)
                {
                    entidadClienteSimple.seleccionado = false;
                    entidadClienteSimple.nombre = coleccionClientes[cont].nombre;
                    entidadClienteSimple.ubicacion = coleccionClientes[cont].ubicacion;
                    entidadClienteSimple.inscripcion = coleccionClientes[cont].fechaInscripcion;

                    coleccionClientesSimples[cont] = entidadClienteSimple;
                    entidadClienteSimple = new clsEClienteSimple();
                }
                return coleccionClientesSimples;
            }

        }

    }
}
