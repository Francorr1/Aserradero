using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsEUsuario
    {

//ATRIBUTOS DEL OBJETO clsEUsuario
        public int ci { get; set; }
        public string nombre { get; set; } = null;  // Se deja null por defecto para comprobar si hay un usuario
        public string clave { get; set; }
        public int telefono { get; set; }
        public string correo { get; set; }
        public clsETipoUsuario entidadTipoUsuario { get; set; }

//ARMADO DEL OBJETO clsEUsuario
    public clsEUsuario armarUsuario(int ci, string nombre, string clave, int telefono, string correo, clsETipoUsuario entidadTipoUsuario)
        {
            clsEUsuario entidadUsuario = new clsEUsuario();

            entidadUsuario.ci = ci;
            entidadUsuario.clave = clave;
            entidadUsuario.correo = correo;
            entidadUsuario.nombre = nombre;
            entidadUsuario.telefono = telefono;
            entidadUsuario.entidadTipoUsuario = entidadTipoUsuario;

            return entidadUsuario;
        }

//DESARMADO DEL OBJETO clsEUsuario EN UN clsEUsuarioSimple
        public class clsEUsuarioSimple
        {

            //ATRIBUTOS DEL OBJETO clsEUsuarioSimple
            public bool seleccionado { get; set; }
            public string documento { get; set; }
            public string nombre { get; set; }
            public string clave { get; set; }
            public string contacto { get; set; }
            public string correo { get; set; }
            public string tipo { get; set; }

            //DESARMADO DEL OBJETO clsEUsuario
            public clsEUsuarioSimple[] desarmarUsuario(clsEUsuario[] coleccionUsuarios)
            {
                
                clsEUsuarioSimple[] coleccionUsuariosSimples = new clsEUsuarioSimple[coleccionUsuarios.Length];
                clsEUsuarioSimple entidadUsuarioSimple = new clsEUsuarioSimple();

                for (int cont = 0; cont < coleccionUsuarios.Length; cont++)
                {
                    entidadUsuarioSimple.documento = Convert.ToString(coleccionUsuarios[cont].ci);
                    entidadUsuarioSimple.nombre = coleccionUsuarios[cont].nombre;
                    entidadUsuarioSimple.clave = coleccionUsuarios[cont].clave;
                    entidadUsuarioSimple.contacto = Convert.ToString(coleccionUsuarios[cont].telefono);
                    entidadUsuarioSimple.correo = coleccionUsuarios[cont].correo;
                    entidadUsuarioSimple.tipo = coleccionUsuarios[cont].entidadTipoUsuario.nombreTipo;
                    entidadUsuarioSimple.seleccionado = false;

                    coleccionUsuariosSimples[cont] = entidadUsuarioSimple;
                    entidadUsuarioSimple = new clsEUsuarioSimple();

                }

                return coleccionUsuariosSimples;
            }

        }

    }
}
