using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsERodal
    {

//ATRIBUTOS DEL OBJETO clsERodal
        public int id { get; set; }
        public int dimensiones { get; set; }
        public clsEEspecie entidadEspecie { get; set; }
        public clsEUsuario entidadUsuario { get; set; }

//ARMADO DEL OBJETO clsERodal
        public clsERodal armarRodal(int id, int dimensiones, clsEEspecie entidadEspecie, clsEUsuario entidadUsuario)
        {
            clsERodal entidadRodal = new clsERodal();

            entidadRodal.id = id;
            entidadRodal.dimensiones = dimensiones;
            entidadRodal.entidadEspecie = entidadEspecie;
            entidadRodal.entidadUsuario = entidadUsuario;

            return entidadRodal;
        }

//DEARMADO DEL OBJETO clsERodal EN UN clsERodalSimplificado
        public class clsERodalSimple
        {

            //ATRIBUTOS DEL OBJETO clsERodalSimple
            public bool seleccionado { get; set; }
            public string dimensiones { get; set; }
            public string especie { get; set; }
            public string usuario { get; set; }

            //DESARMADO DEL OBJETO clsERodal
            public clsERodalSimple[] desarmarRodal(clsERodal[] coleccionRodales)
            {
                clsERodalSimple[] coleccionRodalesSimples = new clsERodalSimple[coleccionRodales.Length];
                clsERodalSimple entidadRodalSimple = new clsERodalSimple();

                for(int cont = 0; cont < coleccionRodales.Length; cont++)
                {
                    entidadRodalSimple.seleccionado = false;
                    entidadRodalSimple.dimensiones = Convert.ToString(coleccionRodales[cont].dimensiones);
                    entidadRodalSimple.especie = coleccionRodales[cont].entidadEspecie.nombre;
                    entidadRodalSimple.usuario = coleccionRodales[cont].entidadUsuario.nombre;
                    entidadRodalSimple.seleccionado = false;

                    coleccionRodalesSimples[cont] = entidadRodalSimple;
                    entidadRodalSimple = new clsERodalSimple();
                }

                return coleccionRodalesSimples;
            }

        }

    }
}
