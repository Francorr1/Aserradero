using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;
using MySql.Data.MySqlClient;

namespace Aserradero.Datos
{
    public class clsDLote : clsHerramientasBD
    {

//RECREAR LOTE
        private clsELote recrearLote(MySqlDataReader fila)
        {
            clsELote entidadLote = new clsELote();
            clsDGrupoTroza datosGrupoTroza = new clsDGrupoTroza();
            clsDUsuario datosUsuario = new clsDUsuario();
            clsDProducto datosProducto = new clsDProducto();
            clsEGrupoTroza entidadGrupoTroza;
            clsEUsuario entidadUsuario;
            clsEProducto entidadProducto;

            entidadLote.id = fila.GetInt32("idLote");
            entidadLote.cantidadProducto = fila.GetInt32("cantidadProducto");
            
            entidadLote.fechaIngreso = desarmarDate(fila.GetString("fechaIngresoLote"));

            entidadLote.cantidadTroza = fila.GetInt32("cantidadTroza");

            //Se debe listar el grupo de trozas correspondiente al id recibido, con el fin de recrear ese grupo de trozas y asignarlo a este lote.
            entidadGrupoTroza = datosGrupoTroza.listarGrupoTrozaParticular(fila.GetInt32("idGrupoTroza"));
            entidadLote.entidadGrupoTroza = entidadGrupoTroza;

            //Se debe listar el usuario correspondiente al id recibido, con el fin de recrear ese usuario y asignarlo a este lote.
            entidadUsuario = datosUsuario.listarUsuarioParticular(fila.GetInt32("ciUsuario"));
            entidadLote.entidadUsuario = entidadUsuario;

            //Se debe listar el producto correspondiente al id recibido, con el fin de recrear ese producto y asignarlo a este lote.
            entidadProducto = datosProducto.listarProductoParticular(fila.GetInt32("idProducto"));
            entidadLote.entidadProducto = entidadProducto;

            return entidadLote;
        }

//ALTA LOTE
        public void altaLote(clsELote entidadLote)
        {
            string consulta;
            clsDGrupoTroza entidadGrupoTroza = new clsDGrupoTroza();

            consulta = $"INSERT INTO lote (cantidadProducto, cantidadTroza, idGrupoTroza, ciUsuario, idProducto) VALUES({entidadLote.cantidadProducto}, {entidadLote.cantidadTroza}, {entidadLote.entidadGrupoTroza.id}, {entidadLote.entidadUsuario.ci}, {entidadLote.entidadProducto.id})";
            ejecutarQuery(consulta);

            con.Close();

            entidadGrupoTroza.restarTrozas(entidadLote);

            return;
        }

//BAJA LOTE
        public void bajaLote(clsELote entidadLote)
        {
            string consulta;

            consulta = $"DELETE FROM lote WHERE idLote = {entidadLote.id}";
            ejecutarQuery(consulta);

            return;
        }

#region LISTAR LOTES

    //Listar todos los lotes.
        public List<clsELote> listarLotes()
        {
            List<clsELote> coleccionLotes = new List<clsELote>();
            clsELote entidadLote = new clsELote();
            MySqlDataReader datos;
            string consulta;

            consulta = "SELECT * FROM lote";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadLote = recrearLote(datos);
                coleccionLotes.Add(entidadLote);
            }

            con.Close();

            return coleccionLotes;
        }

    //Listar lotes por fecha.
        public List<clsELote> listarLotesPorFecha(string fecha)
        {
            List<clsELote> coleccionLotes = new List<clsELote>();
            clsELote entidadLote = new clsELote();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM lote WHERE fechaIngresoLote = '{fecha}'";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadLote = recrearLote(datos);
                coleccionLotes.Add(entidadLote);
            }

            con.Close();

            return coleccionLotes;
        }

    //Listar lotes por usuario.
        public List<clsELote> listarLotesPorUsuario(int ci)
        {
            List<clsELote> coleccionLotes = new List<clsELote>();
            clsELote entidadLote = new clsELote();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM lote WHERE ciUsuario = {ci}";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadLote = recrearLote(datos);
                coleccionLotes.Add(entidadLote);
            }

            con.Close();

            return coleccionLotes;
        }

    //Listar lotes por producto.
        public List<clsELote> listarLotesPorProducto(int id)
        {
            List<clsELote> coleccionLotes = new List<clsELote>();
            clsELote entidadLote = new clsELote();
            MySqlDataReader datos;
            string consulta;

            consulta = $"SELECT * FROM lote WHERE idProducto = {id}";
            datos = ejecutarQueryLectura(consulta);

            if (datos == null)
            {
                return null;
            }

            while (datos.Read())
            {
                entidadLote = recrearLote(datos);
                coleccionLotes.Add(entidadLote);
            }

            con.Close();

            return coleccionLotes;
        }
        #endregion
        
        
    }
}
