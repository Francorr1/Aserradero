using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsELote
    {

//ATRIBUTOS DEL OBJETO clsELote
        public int id { get; set; }
        public int cantidadProducto { get; set; }
        public string fechaIngreso { get; set; }
        public int cantidadTroza { get; set; }
        public clsEGrupoTroza entidadGrupoTroza { get; set; }
        public clsEUsuario entidadUsuario { get; set; }
        public clsEProducto entidadProducto { get; set; }
        
//ARMADO DEL OBJETO clsELote
        public clsELote armarLote(int id, int cantidadProducto, string fechaIngreso, int cantidadTroza, clsEGrupoTroza entidadGrupoTroza, clsEUsuario entidadUsuario, clsEProducto entidadProducto)
        {
            clsELote entidadLote = new clsELote();

            entidadLote.id = id;
            entidadLote.cantidadProducto = cantidadProducto;
            entidadLote.fechaIngreso = fechaIngreso;
            entidadLote.cantidadTroza = cantidadTroza;
            entidadLote.entidadGrupoTroza = entidadGrupoTroza;
            entidadLote.entidadUsuario = entidadUsuario;
            entidadLote.entidadProducto = entidadProducto;

            return entidadLote;
        }

//DESARMAR UN OBJETO clsELote EN UN clsELoteSimple
        public class clsELoteSimple
        {

            //ATRIBUTOS DEL OBJETO clsELoteSimple
            public bool seleccionado { get; set; }
            public string producto { get; set; }
            public string producido { get; set; }
            public string ingresado { get; set; }
            public string trozas { get; set; }
            public string diametroTroza { get; set; }
            public string usuario { get; set; }

            //DESARMAR OBJETO clsELote
            public clsELoteSimple[] desarmarLote(clsELote[] coleccionLotes)
            {
                clsELoteSimple[] coleccionLotesSimples = new clsELoteSimple[coleccionLotes.Length];
                clsELoteSimple entidadLoteSimple = new clsELoteSimple();

                for (int cont = 0; cont < coleccionLotes.Length; cont++)
                {
                    entidadLoteSimple.producido = Convert.ToString(coleccionLotes[cont].cantidadProducto);
                    entidadLoteSimple.ingresado = coleccionLotes[cont].fechaIngreso;
                    entidadLoteSimple.trozas = Convert.ToString(coleccionLotes[cont].cantidadTroza);
                    entidadLoteSimple.diametroTroza = Convert.ToString(coleccionLotes[cont].entidadGrupoTroza.diametro);
                    entidadLoteSimple.usuario = coleccionLotes[cont].entidadUsuario.nombre;
                    entidadLoteSimple.producto = coleccionLotes[cont].entidadProducto.tipo;
                    entidadLoteSimple.seleccionado = false;

                    coleccionLotesSimples[cont] = entidadLoteSimple;
                    entidadLoteSimple = new clsELoteSimple();
                }

                return coleccionLotesSimples;
            }

        }
    }

}
