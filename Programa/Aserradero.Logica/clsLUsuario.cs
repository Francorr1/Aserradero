using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLUsuario
    {
        
        // Instanciamos el usuario
        public clsEUsuario usuario = new clsEUsuario();

        // Instancia el objeto de la siguiente capa
        clsDUsuario datosUsuario = new clsDUsuario();

        //INICIAR SESIÓN
        public clsEUsuario iniciarSesion(clsEUsuario ingresadoUsuario)
        {
            if (ingresadoUsuario.ci == 0 || ingresadoUsuario.clave == "") // Si cualquier dato está vacio
            {
                return null; // Devuelve null
            }
            
            usuario = datosUsuario.iniciarSesion(ingresadoUsuario); // Se ejecuta la función y se guarda en el objeto la información recibida
            
            if (usuario.nombre != null) // Si el usuario tiene nombre, es porque existe
            {
                return usuario; // Devolvemos el usuario
            }

            return null; // Devuelve un valor nulo
        }

        //ALTA USUARIO
        public void altaUsuario(clsEUsuario ingresadoUsuario)
        {
            datosUsuario.altaUsuario(ingresadoUsuario); // Le envia a la siguiente capa el objeto entidad
        }

        //BAJA USUARIO
        public void bajaUsuario(int ciUsuario)
        {
            datosUsuario.bajaUsuario(ciUsuario); // Le envia a la siguiente capa el objeto entidad
        }

        //MODIFICAR USUARIO        
        public void modificarUsuario(clsEUsuario ingresadoUsuario)
        {
            datosUsuario.modificarUsuario(ingresadoUsuario); // Le envia a la siguiente capa el objeto entidad
        }

        //LISTAR TODOS LOS USUARIOS
        public List<clsEUsuario> listarUsuarios()
        {
            List<clsEUsuario> coleccionUsuarios = new List<clsEUsuario>(); // Declaro una lista de objetos de tipo entidad usuario
            coleccionUsuarios = datosUsuario.listarUsuarios(); // Se ejecuta la función y se guarda en la lista la información recibida

            if (coleccionUsuarios == null)
            {
                return null;
            }

            return coleccionUsuarios; // Devuelve la lista de entidades
        }

        //INFORME USUARIO ESPECIFICO
        public clsEUsuario informeUsuario(int ciUsuario)
        {
            clsEUsuario usuarioParticular = new clsEUsuario(); // Instancio un objeto de tipo entidad usuario
            usuarioParticular = datosUsuario.listarUsuarioParticular(ciUsuario); // Se ejecuta la función y se guarda en el objeto la información recibida

            if (usuarioParticular == null)
            {
                return null;
            }

            return usuarioParticular; //Devuelve el Usuario
        }

        //VERIFICAR EXISTENCIA DE UN USUARIO
        public bool verificarUsuario(int cedula)
        {
            bool existe = datosUsuario.verificarUsuario(cedula); //Instancio un objeto de tipo bool y lo igualo al resultado de la información recibida por la función
            return existe; //Devuelve el resultado de la función anterior
        }

    }

}
