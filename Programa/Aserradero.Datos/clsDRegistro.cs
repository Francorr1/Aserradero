using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDRegistro : clsHerramientasBD
    {

//RECREAR REGISTRO
        private clsERegistro recrearRegistro(MySqlDataReader fila)
        {
            clsERegistro entidadRegistro = new clsERegistro();
            clsDUsuario datosUsuario = new clsDUsuario();
            clsEUsuario entidadUsuario;

            entidadRegistro.id = fila.GetInt32("idRegistro");
            
            entidadRegistro.fechaSesion = desarmarDate(fila.GetString("fechaSesion"));

            //Se debe listar el usuario correspondiente al id recibido, con el fin de recrear ese usuario y asignarlo a este registro.
            entidadUsuario = datosUsuario.listarUsuarioParticular(fila.GetInt32("ciUsuario"));
            entidadRegistro.entidadUsuario = entidadUsuario;

            entidadRegistro.descripcionRegistro = fila.GetString("descripcionRegistro");

            return entidadRegistro;
        }

//ALTA REGISTRO
        public void altaRegistro(clsERegistro entidadRegistro)
        {
            string consulta;

            consulta = $"INSERT INTO registro (descripcionRegistro, ciUsuario) VALUES ('{entidadRegistro.descripcionRegistro}', {entidadRegistro.entidadUsuario.ci})";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

#region LISTAR REGISTROS

    //Listar todos los registros
        public List<clsERegistro> listarRegistros()
        {
            List<clsERegistro> coleccionRegistros = new List<clsERegistro>();
            clsERegistro entidadRegistro = new clsERegistro();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM registro";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadRegistro = recrearRegistro(datos);
                coleccionRegistros.Add(entidadRegistro);
            }

            con.Close();

            return coleccionRegistros;
        }

    //Listar registros por una fecha particular
        public List<clsERegistro> listarRegistroPorFecha(string fechaSesion)
        {
            List<clsERegistro> coleccionRegistros = new List<clsERegistro>();
            clsERegistro entidadRegistro = new clsERegistro();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM registro WHERE fechaSesion = '{fechaSesion}'";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadRegistro = recrearRegistro(datos);
                coleccionRegistros.Add(entidadRegistro);
            }

            con.Close();

            return coleccionRegistros;
        }

    //Listar registros por un usuario particular
        public List<clsERegistro> listarRegistroPorUsuario(int ci)
        {
            List<clsERegistro> coleccionRegistros = new List<clsERegistro>();
            clsERegistro entidadRegistro = new clsERegistro();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM registro WHERE ciUsuario = {ci}";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadRegistro = recrearRegistro(datos);
                coleccionRegistros.Add(entidadRegistro);
            }

            con.Close();

            return coleccionRegistros;
        }
        #endregion

    }
}