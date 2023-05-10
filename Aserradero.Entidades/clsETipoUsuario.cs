using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsETipoUsuario
    {

//ATRIBTOS DEL OBJETO clsETipoUsuario
        public int idTipo { get; set; }
        public string nombreTipo { get; set; }
        public string descripcionTipo { get; set; }

//ARMADO DEL OBJETO clsETipoUsuario
        public clsETipoUsuario armarTipoUsuario(int idTipo, string nombreTipo, string descripcion)
        {
            clsETipoUsuario entidadTipoUsuario = new clsETipoUsuario();

            entidadTipoUsuario.idTipo = idTipo;
            entidadTipoUsuario.nombreTipo = nombreTipo;
            entidadTipoUsuario.descripcionTipo = descripcion;

            return entidadTipoUsuario;
        }

//DESARMADO DE UN clsETipoUsuario EN UN clsETipoUsuarioSimple
        public class clsETipoUsuarioSimple
        {

            //ATRIBUTOS DEL OBJETO clsETipoUsuarioSimple
            public string tipos { get; set; }
            public string descripcion { get; set; }

            //DESARMADO DEL OBJETO clsETipoUsuario
            public clsETipoUsuarioSimple[] desarmarTipoUsuario(clsETipoUsuario[] coleccionTiposUsuario)
            {
                clsETipoUsuarioSimple[] coleccionTiposUsuarioSimples = new clsETipoUsuarioSimple[coleccionTiposUsuario.Length];
                clsETipoUsuarioSimple entidadTipoUsuarioSimple = new clsETipoUsuarioSimple();

                for (int cont = 0; cont < coleccionTiposUsuarioSimples.Length; cont++)
                {
                    entidadTipoUsuarioSimple.tipos = coleccionTiposUsuario[cont].nombreTipo;
                    entidadTipoUsuarioSimple.descripcion = coleccionTiposUsuario[cont].descripcionTipo;

                    coleccionTiposUsuarioSimples[cont] = entidadTipoUsuarioSimple;
                    entidadTipoUsuarioSimple = new clsETipoUsuarioSimple();
                }

                return coleccionTiposUsuarioSimples;
            }

        }

    }
}
