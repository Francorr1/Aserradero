using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using Aserradero.Entidades;

namespace Aserradero.Datos
{
    public class clsHerramientasBD
    {
        static string ip = "localhost";

        static string usuario = "root";
        static string clave = "";  // <-- Inseguro, las credenciales están en el código
        static string database = "aserraderoutu";

        // String de conexión con la DB
        protected MySqlConnection con = new MySqlConnection($"server={ip};userid={usuario};password={clave};database={database};SSL Mode=None");// <- Inseguro, no usa SSL

        /// <summary>
        /// Ejecuta una consulta SQL de lectura
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar</param>
        /// <returns>Un MySqlDataReader con los resultados</returns>
        public MySqlDataReader ejecutarQueryLectura(string query)
        {
            try //Se realiza un tryCatch para comprobar que hay conexión con la base de datos
            {
                con.Open(); // Se abre la conexión
                var cmd = new MySqlCommand(query, con); // Se crea el comando SQL

                MySqlDataReader dr = cmd.ExecuteReader(); // Se crea un reader para los datos

                return dr; // Se devuelve el MySqlDataReader
            }
            catch (MySqlException) //En caso de no haber conexión, se devuelve null, lo que le indica a las demás capas que no se pudo conectar, llegando hasta la capa de interfaz
            {
                con.Close();
                return null;
            }
             
        }

        /// <summary>
        /// Ejecuta una consulta SQL, no devuelve nada
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar</param>
        public void ejecutarQuery(string query)
        {
            con.Open(); // Se abre la conexión
            var cmd = new MySqlCommand(query, con); // Se crea el comando SQL

            cmd.ExecuteNonQuery(); // Se ejecuta la query

            con.Close(); // Se cierra la conexión
            return; // Se devuelve el resultado final
        }


        //Desarmar la fecha que viene desde la base de datos, a una fecha útil para su muestreo al usuario
        public string desarmarDate(string fechaBD)
        {
            string fechaPrograma;
            string[] subFecha = { "" };
            char[] espacio = { ' ' };

            subFecha = fechaBD.Split(espacio);
            fechaPrograma = subFecha[0];


            return fechaPrograma;
        }

    }
}
