using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLCliente
    {
        
        // Instancia el objeto de la siguiente capa
        clsDCliente datosCliente = new clsDCliente();

        //ALTA CLIENTE
        public void altaCliente(clsECliente ingresadoCliente)
        {
            datosCliente.altaCliente(ingresadoCliente); // Le envia a la siguiente capa el objeto entidad
        }

        //MODIFICAR CLIENTE    
        public void modificarCliente(clsECliente ingresadoCliente)
        {
            datosCliente.modificarCliente(ingresadoCliente); // Le envia a la siguiente capa el objeto entidad
        }

        //LISTAR TODOS LOS CLIENTE
        public List<clsECliente> listarClientes()
        {
            List<clsECliente> coleccionClientes = new List<clsECliente>(); // Declaro una lista de objetos de tipo entidad clientes
            coleccionClientes = datosCliente.listarClientes(); // Se ejecuta la función y se guarda en la lista la información recibida

            if(coleccionClientes == null)
            {
                return null;
            }

            return coleccionClientes; // Devuelve la lista de entidades
        }

    }
}
