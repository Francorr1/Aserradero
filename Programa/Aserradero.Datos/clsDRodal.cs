using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDRodal : clsHerramientasBD
    {

//RECREAR RODAL
        private clsERodal recrearRodal(MySqlDataReader fila)
        {
            clsERodal entidadRodal = new clsERodal();
            clsDEspecie datosEspecie = new clsDEspecie();
            clsDUsuario datosUsuario = new clsDUsuario();
            clsEEspecie entidadEspecie;
            clsEUsuario entidadUsuario;

            entidadRodal.id = fila.GetInt32("idRodal");
            entidadRodal.dimensiones = fila.GetInt32("dimensionesRodal");

            //Se debe listar la especie correspondiente al id recibido, con el fin de recrear esa especie y asignarla a este rodal.
            entidadEspecie = datosEspecie.listarEspecieParticular(fila.GetInt32("idEspecie"));
            entidadRodal.entidadEspecie = entidadEspecie;

            //Se debe listar el usuario correspondiente al id recibido, con el fin de recrear ese usuario y asignarlo a este rodal.
            entidadUsuario = datosUsuario.listarUsuarioParticular(fila.GetInt32("ciUsuario"));
            entidadRodal.entidadUsuario = entidadUsuario;

            return entidadRodal;
        }

//ALTA RODAL
        public void altaRodal(clsERodal entidadRodal)
        {
            string consulta;

            consulta = $"INSERT INTO rodal (dimensionesRodal, idEspecie, ciUsuario) VALUES({entidadRodal.dimensiones}, {entidadRodal.entidadEspecie.id}, {entidadRodal.entidadUsuario.ci})";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//BAJA RODAL
        public void bajaRodal(clsERodal entidadRodal)
        {
            string consulta;

            consulta = $"UPDATE rodal SET bajaRodal = TRUE WHERE idRodal = {entidadRodal.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//MODIFICAR RODAL
        public void modificarRodal(clsERodal entidadRodal)
        {
            string consulta;

            consulta = $"UPDATE rodal SET dimensionesRodal = {entidadRodal.dimensiones}, ciUsuario = {entidadRodal.entidadUsuario.ci} WHERE idRodal = {entidadRodal.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

#region LISTAR RODALES

    //Listar todos los rodales.
        public List<clsERodal> listarRodales()
        {
            List<clsERodal> coleccionRodales = new List<clsERodal>();
            clsERodal entidadRodal = new clsERodal();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM rodal WHERE bajaRodal = FALSE";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadRodal = recrearRodal(datos);
                coleccionRodales.Add(entidadRodal);
            }

            con.Close();

            return coleccionRodales;
        }

    //Listar rodal específico.
        public clsERodal listarRodalParticular(int id)
        {
            clsERodal entidadRodal = new clsERodal();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM rodal WHERE idRodal = {id}";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            if (datos.Read())
            {
                entidadRodal = recrearRodal(datos);
            }

            con.Close();

            return entidadRodal;
        }

    //Listar rodal por especie
        public clsERodal informeRodalPorEspecie(clsEEspecie entidadEspecie)
        {
            clsERodal entidadRodal = new clsERodal();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * from rodal WHERE idEspecie = {entidadEspecie.id}";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            if (datos.Read())
            {
                entidadRodal = recrearRodal(datos);
            }

            con.Close();
            return entidadRodal;
        }
        #endregion

    }
}
