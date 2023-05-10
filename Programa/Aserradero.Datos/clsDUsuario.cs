using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Aserradero.Entidades;

namespace Aserradero.Datos
{
    public class clsDUsuario : clsHerramientasBD
    {

//RECREAR USUARIO
        private clsEUsuario recrearUsuario (MySqlDataReader fila)
        {
            clsEUsuario entidadUsuario = new clsEUsuario();
            clsDTipoUsuario datosTipoUsuario = new clsDTipoUsuario();
            clsETipoUsuario entidadTipoUsuario;

            entidadUsuario.ci = fila.GetInt32("ciUsuario");
            entidadUsuario.clave = fila.GetString("contrasenaUsuario");
            entidadUsuario.correo = fila.GetString("correoUsuario");
            entidadUsuario.nombre = fila.GetString("nombreUsuario");
            entidadUsuario.telefono = fila.GetInt32("telefonoUsuario");

            //Se debe listar el tipo de usuario correspondiente al idTipo recibido, con el fin de recrear ese tipo de usuario y asignarlo a este usuario.
            entidadTipoUsuario = datosTipoUsuario.listarTipoUsuarioParticular(fila.GetInt32("idTipo"));
            entidadUsuario.entidadTipoUsuario = entidadTipoUsuario;

            return entidadUsuario;
        }

//ALTA USUARIO
        public void altaUsuario(clsEUsuario entidadUsuario)
        {
            string consulta;

            consulta = $"INSERT INTO usuario (ciUsuario, nombreUsuario, contrasenaUsuario, telefonoUsuario, correoUsuario, idTipo) VALUES({entidadUsuario.ci}, '{entidadUsuario.nombre}', '{entidadUsuario.clave}', {entidadUsuario.telefono}, '{entidadUsuario.correo}', {entidadUsuario.entidadTipoUsuario.idTipo})";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//BAJA USUARIO
        public void bajaUsuario(int ciUsuario)
        {
            string consulta;

            consulta = $"UPDATE usuario SET bajaUsuario = TRUE WHERE ciUsuario = {ciUsuario}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//MODIFICAR USUARIO
        public void modificarUsuario(clsEUsuario entidadUsuario)
        {
            string consulta;

            consulta = $"UPDATE usuario SET nombreUsuario = '{entidadUsuario.nombre}', contrasenaUsuario = '{entidadUsuario.clave}', telefonoUsuario = '{entidadUsuario.telefono}', correoUsuario = '{entidadUsuario.correo}' WHERE ciUsuario = {entidadUsuario.ci}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

#region LISTAR USUARIOS

    //Listar todos los usuarios.
        public List<clsEUsuario> listarUsuarios()
        {
            List<clsEUsuario> coleccionUsuarios = new List<clsEUsuario>();
            MySqlDataReader datos;
            clsEUsuario entidadUsuario = new clsEUsuario();
            string consulta;

            consulta = "SELECT * FROM usuario WHERE bajaUsuario = FALSE";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadUsuario = recrearUsuario(datos);
                coleccionUsuarios.Add(entidadUsuario);
            }

            con.Close();

            return coleccionUsuarios;
        } 

    //Listar usuario específico.
        public clsEUsuario listarUsuarioParticular(int ci)
        {
            clsEUsuario entidadUsuario = new clsEUsuario();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM usuario WHERE ciUsuario = '{ci}'";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            if (datos.Read())
            {
                entidadUsuario = recrearUsuario(datos);
            }

            con.Close();

            return entidadUsuario;
        }
        #endregion

    // INICIO DE SESIÓN
        public clsEUsuario iniciarSesion(clsEUsuario intentoSesion)
        {
            clsEUsuario entidadUsuario = new clsEUsuario();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM usuario WHERE contrasenaUsuario = '{intentoSesion.clave}' AND ciUsuario = {intentoSesion.ci} AND bajaUsuario = FALSE";
            datos = ejecutarQueryLectura(consulta);

            if(datos == null)
            {
                entidadUsuario.nombre = "";
                entidadUsuario.clave = null;
                return entidadUsuario;
            }

            if (datos.Read())
            {
                entidadUsuario = recrearUsuario(datos);
            }

            con.Close();

            return entidadUsuario;
        }

    // COMPROBAR EXISTENCIA DE USUARIO
        public bool verificarUsuario(int cedula)
        {
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT ciUsuario FROM usuario";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                if (datos.GetInt32("ciUsuario") == cedula)
                {
                    con.Close();
                    return true;
                }
            }

            con.Close();
            return false;
        }

    }
}
