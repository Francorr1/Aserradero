using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsEGrupoTroza
    {

//ATRIBUTOS DEL OBJETO clsEGrupoTroza
        public int id { get; set; }
        public int diametro { get; set; }
        public int cantidad { get; set; }
        public clsERodal entidadRodal { get; set; }

//ARMADO DEL OBJETO clsEGrupoTroza
    public clsEGrupoTroza armarGrupoTroza(int id, int diametro, int cantidad, clsERodal entidadRodal)
        {
            clsEGrupoTroza entidadGrupoTroza = new clsEGrupoTroza();

            entidadGrupoTroza.id = id;
            entidadGrupoTroza.diametro = diametro;
            entidadGrupoTroza.cantidad = cantidad;
            entidadGrupoTroza.entidadRodal = entidadRodal;

            return entidadGrupoTroza;
        }

//DESARMAR OBJETO clsEGrupoTroza EN UN clsEGrupoTrozaSimple
        public class clsEGrupoTrozaSimple
        {

            //ATRIBUTOS DEL OBJETO clsEGrupoTrozaSimple
            public bool seleccionado { get; set; }
            public string diametro { get; set; }
            public string cantidad { get; set; }
            public string rodal { get; set; }

            //DESARMAR OBJETO clsEGrupoTroza
            public clsEGrupoTrozaSimple[] desarmarGrupoTroza(clsEGrupoTroza[] coleccionGrupoTroza)
            {
                clsEGrupoTrozaSimple[] coleccionGrupoTrozasSimples = new clsEGrupoTrozaSimple[coleccionGrupoTroza.Length];
                clsEGrupoTrozaSimple entidadGrupoTrozaSimple = new clsEGrupoTrozaSimple();

                for (int cont = 0; cont < coleccionGrupoTroza.Length; cont++)
                {
                    entidadGrupoTrozaSimple.seleccionado = false;
                    entidadGrupoTrozaSimple.diametro = Convert.ToString(coleccionGrupoTroza[cont].diametro);
                    entidadGrupoTrozaSimple.cantidad = Convert.ToString(coleccionGrupoTroza[cont].cantidad);
                    entidadGrupoTrozaSimple.rodal = coleccionGrupoTroza[cont].entidadRodal.entidadEspecie.nombre;

                    coleccionGrupoTrozasSimples[cont] = entidadGrupoTrozaSimple;
                    entidadGrupoTrozaSimple = new clsEGrupoTrozaSimple();
                }

                return coleccionGrupoTrozasSimples;
            }

        }

    }

}
