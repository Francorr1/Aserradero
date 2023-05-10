using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsERegistro
    {

//ATRIBUTOS DEL OBJETO clsERegistro
        public int id { get; set; }
        public string fechaSesion { get; set;}
        public clsEUsuario entidadUsuario { get; set; }
        public string descripcionRegistro { get; set; }

        //ARMADO DEL OBJETO clsERegistro
        public clsERegistro armarRegistro(int id, string fechaSesion, clsEUsuario entidadUsuario)
        {
            clsERegistro entidadRegistro = new clsERegistro();

            entidadRegistro.id = id;
            entidadRegistro.fechaSesion = fechaSesion;
            entidadRegistro.entidadUsuario = entidadUsuario;

            return entidadRegistro;
        }

//DESARMADO DEL OBJETO clsERegistro EN UN clsERegistroSimple
        public class clsERegistroSimple
        {

            //ATRIBUTOS DEL OBJETO clsERegistroSimple
            public string sesion { get; set; }
            public string usuario { get; set; }
            public string acciones { get; set; }

            //DESARMADO DEL OBJETO clsERodal
            public clsERegistroSimple[] desarmarRegistro(clsERegistro[] coleccionRegistros)
            {
                clsERegistroSimple[] coleccionRegistrosSimples = new clsERegistroSimple[coleccionRegistros.Length];
                clsERegistroSimple entidadRegistroSimple = new clsERegistroSimple();

                for(int cont = 0; cont < coleccionRegistros.Length; cont++)
                {
                    entidadRegistroSimple.sesion = coleccionRegistros[cont].fechaSesion;
                    entidadRegistroSimple.usuario = coleccionRegistros[cont].entidadUsuario.nombre;
                    entidadRegistroSimple.acciones = coleccionRegistros[cont].descripcionRegistro;

                    coleccionRegistrosSimples[cont] = entidadRegistroSimple;
                    entidadRegistroSimple = new clsERegistroSimple();
                }

                return coleccionRegistrosSimples;
            }

        }

    }
}
