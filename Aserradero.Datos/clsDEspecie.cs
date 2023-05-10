using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDEspecie : clsHerramientasBD
    {

//RECREAR ESPECIES
        private clsEEspecie recrearEspecie(MySqlDataReader fila)
        {
            clsEEspecie entidadEspecie = new clsEEspecie();

            entidadEspecie.id = fila.GetInt32("idEspecie");
            entidadEspecie.nombre = fila.GetString("nombreEspecie");
            entidadEspecie.descripcion = fila.GetString("descripcionEspecie");

            return entidadEspecie;
        }

//ALTA ESPECIE
        public void altaEspecie(clsEEspecie entidadEspecie)
        {
            string consulta;

            consulta = $"INSERT INTO especie (nombreEspecie, descripcionEspecie) VALUES('{entidadEspecie.nombre}', '{entidadEspecie.descripcion}')";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

//MODIFICAR ESPECIE
        public void modificarEspecie(clsEEspecie entidadEspecie)
        {
            string consulta;

            consulta = $"UPDATE especie SET nombreEspecie = '{entidadEspecie.nombre}', descripcionEspecie = '{entidadEspecie.descripcion}' WHERE idEspecie = {entidadEspecie.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

#region LISTAR ESPECIES

    //Listar todas las especies.
        public List<clsEEspecie> listarEspecies()
        {
            List<clsEEspecie> coleccionEspecies = new List<clsEEspecie>();
            clsEEspecie entidadEspecie = new clsEEspecie();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM especie";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                entidadEspecie = recrearEspecie(datos);
                coleccionEspecies.Add(entidadEspecie);
            }

            con.Close();

            return coleccionEspecies;
        }

    //Listar especie particular.
        public clsEEspecie listarEspecieParticular(int idEspecie)
        {
            clsEEspecie entidadEspecie = new clsEEspecie();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM especie WHERE idEspecie = '{idEspecie}'";
            datos = ejecutarQueryLectura(consulta);

            if (datos.Read())
            {
                entidadEspecie = recrearEspecie(datos);

            }

            con.Close();

            return entidadEspecie;
        }
        #endregion

    }
}
