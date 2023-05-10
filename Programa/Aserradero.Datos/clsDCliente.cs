using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDCliente : clsHerramientasBD
    {
        
//RECREAR CLIENTE
        private clsECliente recrearCliente(MySqlDataReader fila)
        {
            clsECliente entidadCliente = new clsECliente();

            entidadCliente.id = fila.GetInt32("idCliente");
            entidadCliente.nombre = fila.GetString("nombreCliente");
            entidadCliente.ubicacion = fila.GetString("ubicacionCliente");

            entidadCliente.fechaInscripcion = desarmarDate(fila.GetString("fechaInscripcion"));

            return entidadCliente;
        }

//ALTA CLIENTE
        public void altaCliente(clsECliente entidadCliente)
        {
            string consulta;

            consulta = $"INSERT INTO cliente (nombreCliente, ubicacionCliente) VALUES('{entidadCliente.nombre}', '{entidadCliente.ubicacion}')";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//BAJA CLIENTE
        public void bajaCliente(clsECliente entidadCliente)
        {
            string consulta;

            consulta = $"UPDATE cliente SET bajaCliente = TRUE WHERE idCliente = {entidadCliente.id}";
            ejecutarQuery(consulta);

            return;
        }

//MODIFICAR CLIENTE
        public void modificarCliente(clsECliente entidadCliente)
        {
            string consulta;

            consulta = $"UPDATE cliente SET nombreCliente = {entidadCliente.nombre} ubicacionCliente = {entidadCliente.ubicacion} WHERE idCliente = {entidadCliente.id}";
        }

#region LISTAR CLIENTES

    //Listar todos los clientes.
        public List<clsECliente> listarClientes()
        {
            List<clsECliente> coleccionClientes = new List<clsECliente>();
            clsECliente entidadCliente = new clsECliente();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM cliente WHERE bajaCliente = FALSE";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadCliente = recrearCliente(datos);
                coleccionClientes.Add(entidadCliente);
            }

            con.Close();

            return coleccionClientes;
        }

    //Listar cliente particular.
        public clsECliente listarClienteParticular(int id)
        {
            clsECliente entidadCliente = new clsECliente();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM cliente WHERE idCliente = {id}";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            if (datos.Read())
            {
                entidadCliente = recrearCliente(datos);
            }

            con.Close();

            return entidadCliente;
        }
        #endregion

    }
}
