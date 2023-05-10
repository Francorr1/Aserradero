using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDTipoUsuario : clsHerramientasBD
    {

//RECREAR TIPO DE USUARIO
        private clsETipoUsuario recrearTipoUsuario(MySqlDataReader fila)
        {
            clsETipoUsuario entidadTipoUsuario = new clsETipoUsuario();

            entidadTipoUsuario.idTipo = fila.GetInt32("idTipo");
            entidadTipoUsuario.nombreTipo = fila.GetString("nombreTipo");
            entidadTipoUsuario.descripcionTipo = fila.GetString("descripcionTipo");

            return entidadTipoUsuario;
        }

#region LISTAR TIPOS DE USUARIO

    //Listar todos los tipos de usuario
        public List<clsETipoUsuario> listarTiposUsuario()
        {
            List<clsETipoUsuario> coleccionTiposUsuario = new List<clsETipoUsuario>();
            clsETipoUsuario entidadTipoUsuario = new clsETipoUsuario();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM tipousuario";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadTipoUsuario = recrearTipoUsuario(datos);
                coleccionTiposUsuario.Add(entidadTipoUsuario);
            }

            con.Close();

            return coleccionTiposUsuario;
        }

    //Listar un tipo de usuario específico
        public clsETipoUsuario listarTipoUsuarioParticular(int id)
        {
            clsETipoUsuario entidadTipoUsuario = new clsETipoUsuario();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM tipousuario WHERE idTipo = '{id}'";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            if (datos.Read())
            {
                entidadTipoUsuario = recrearTipoUsuario(datos);
            }

            con.Close();

            return entidadTipoUsuario;
        }
        #endregion

    }
}
