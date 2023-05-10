using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLTipoUsuario
    {
        
        // Instancia el objeto de la siguiente capa
        clsDTipoUsuario datosTipoUsuario = new clsDTipoUsuario();

        //LISTAR TODOS LOS TIPOS USUARIOS
        public List<clsETipoUsuario> listarTiposUsuario()
        {
            List<clsETipoUsuario> coleccionTiposUsuarios = new List<clsETipoUsuario>(); // Declaro una lista de objetos de tipo entidad tipos de usuario
            coleccionTiposUsuarios = datosTipoUsuario.listarTiposUsuario(); // Se ejecuta la función y se guarda en la lista la información recibida

            if (coleccionTiposUsuarios == null)
            {
                return null;
            }

            return coleccionTiposUsuarios; // Devuelve la lista de entidades
        }
        
        //INFORME TIPOS USUARIOS ESPECIFICO
        public clsETipoUsuario informeTipoUsuarioParticular(int idTipo)
        {
            clsETipoUsuario tipoUsuarioParticular = new clsETipoUsuario(); // Instancio un objeto de tipo entidad tipo de usuario
            tipoUsuarioParticular = datosTipoUsuario.listarTipoUsuarioParticular(idTipo); // Se ejecuta la función y se guarda en el objeto la información recibida

            if (tipoUsuarioParticular == null)
            {
                return null;
            }

            return tipoUsuarioParticular; //Devuelve el tipo Usuario
        }

    }

}
