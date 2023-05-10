using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDGrupoTroza : clsHerramientasBD
    {

//RECREAR GRUPO DE TROZAS
        private clsEGrupoTroza recrearGrupoTroza(MySqlDataReader fila)
        {
            clsEGrupoTroza entidadGrupoTroza = new clsEGrupoTroza();
            clsDRodal datosRodal = new clsDRodal();
            clsERodal entidadRodal;

            entidadGrupoTroza.id = fila.GetInt32("idGrupoTroza");
            entidadGrupoTroza.diametro = fila.GetInt32("diametroGrupoTroza");
            entidadGrupoTroza.cantidad = fila.GetInt32("cantidadGrupoTroza");

            //Se debe listar el rodal correspondiente al id recibido, con el fin de recrear ese rodal y asignarlo a este grupo de trozas.
            entidadRodal = datosRodal.listarRodalParticular(fila.GetInt32("idRodal"));
            entidadGrupoTroza.entidadRodal = entidadRodal;

            return entidadGrupoTroza;
        }

//ALTA GRUPO DE TROZAS
       public void altaGrupoTroza(clsEGrupoTroza entidadGrupoTroza)
        {
            string consulta;

            consulta = $"INSERT INTO grupotroza (diametroGrupoTroza, cantidadGrupoTroza, idRodal) VALUES({entidadGrupoTroza.diametro}, {entidadGrupoTroza.cantidad}, {entidadGrupoTroza.entidadRodal.id})";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

        #region MODIFICAR GRUPO DE TROZAS
        
    //Modificar normal
        public void modificarGrupoTroza(clsEGrupoTroza entidadGrupoTrozas)
        {
            string consulta;

            consulta = $"UPDATE grupotroza SET diametroGrupoTroza = {entidadGrupoTrozas.diametro}, idRodal = {entidadGrupoTrozas.entidadRodal.id} WHERE idGrupoTroza = {entidadGrupoTrozas.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

    //Aumento de trozas
        public void sumarTrozas(clsEGrupoTroza entidadGrupoTroza)
        {
            string consulta;

            consulta = $"UPDATE grupotroza SET cantidadGrupoTroza = cantidadGrupoTroza + {entidadGrupoTroza.cantidad} WHERE grupotroza.idGrupoTroza = {entidadGrupoTroza.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }

    //Disminución de trozas
        public void restarTrozas(clsELote entidadLote)
        {
            string consulta;

            consulta = $"UPDATE grupotroza SET grupotroza.cantidadGrupoTroza = grupotroza.cantidadGrupoTroza - {entidadLote.cantidadTroza} WHERE idGrupoTroza = {entidadLote.entidadGrupoTroza.id}";
            ejecutarQuery(consulta);

            con.Close();

            return;
        }
        #endregion

        #region LISTAR GRUPOS DE TROZAS

        //Listar todos los grupos de trozas.
        public List<clsEGrupoTroza> listarGruposTrozas()
        {
            List<clsEGrupoTroza> coleccionGrupoTroza = new List<clsEGrupoTroza>();
            clsEGrupoTroza entidadGrupoTroza = new clsEGrupoTroza();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM grupotroza";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                entidadGrupoTroza = recrearGrupoTroza(datos);
                coleccionGrupoTroza.Add(entidadGrupoTroza);
            }

            con.Close();

            return coleccionGrupoTroza;
        }

    //Listar un grupo de trozas particular.
        public clsEGrupoTroza listarGrupoTrozaParticular(int id)
        {
            clsEGrupoTroza entidadGrupoTroza = new clsEGrupoTroza();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM grupotroza WHERE idGrupoTroza = {id}";
            datos = ejecutarQueryLectura(consulta);

            if (datos.Read())
            {
                entidadGrupoTroza = recrearGrupoTroza(datos);
            }

            con.Close();

            return entidadGrupoTroza;
        }

    //Listar grupos de trozas por rodal.
        public List<clsEGrupoTroza> listarGruposTrozasPorRodal(int id)
        {
            List<clsEGrupoTroza> coleccionGrupoTrozas = new List<clsEGrupoTroza>();
            clsEGrupoTroza entidadGrupoTroza = new clsEGrupoTroza();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM grupotroza WHERE idRodal = {id}";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                entidadGrupoTroza = recrearGrupoTroza(datos);
                coleccionGrupoTrozas.Add(entidadGrupoTroza);
            }

            con.Close();

            return coleccionGrupoTrozas;
        }

    //Listar grupos de trozas por diámetro.
        public List<clsEGrupoTroza> listarGruposTrozasPorDiametro(int diametro)
        {
            List<clsEGrupoTroza> coleccionGrupoTrozas = new List<clsEGrupoTroza>();
            clsEGrupoTroza entidadGrupoTroza = new clsEGrupoTroza();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM grupotroza WHERE diametroGrupoTroza = {diametro}";
            datos = ejecutarQueryLectura(consulta);

            while (datos.Read())
            {
                entidadGrupoTroza = recrearGrupoTroza(datos);
                coleccionGrupoTrozas.Add(entidadGrupoTroza);
            }

            con.Close();

            return coleccionGrupoTrozas;
        }
        #endregion

    }
}
