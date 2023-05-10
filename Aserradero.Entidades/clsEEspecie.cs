using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aserradero.Entidades
{
    public class clsEEspecie
    {

//ATRIBUTOS DEL OBJETO clsEEspecie
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

//ARMADO DEL OBJETO clsEEspecie
        public clsEEspecie armarEspecie(int id, string nombre, string descripcion)
            {
                clsEEspecie entidadEspecie = new clsEEspecie();

                entidadEspecie.id = id;
                entidadEspecie.nombre = nombre;
                entidadEspecie.descripcion = descripcion;

                return entidadEspecie;
            }

//DESARMADO DE UN OBJETO clsEEspecie EN UN clsEEspecieSimple
        public class clsEEspecieSimple
        {

            //Atributos del objeto clsEEspecieSimple
            public bool seleccionado { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }

            //Desarmado del objeto clsEEspecie
            public clsEEspecieSimple[] desarmarEspecie(clsEEspecie[] coleccionEspecies)
            {
                clsEEspecieSimple[] coleccionEspeciesSimples = new clsEEspecieSimple[coleccionEspecies.Length];
                clsEEspecieSimple entidadEspecieSimple = new clsEEspecieSimple();

                for (int cont = 0; cont < coleccionEspecies.Length; cont++)
                {

                    entidadEspecieSimple.seleccionado = false;
                    entidadEspecieSimple.nombre = coleccionEspecies[cont].nombre;
                    entidadEspecieSimple.descripcion = coleccionEspecies[cont].descripcion;

                    coleccionEspeciesSimples[cont] = entidadEspecieSimple;
                    entidadEspecieSimple = new clsEEspecieSimple();
                }
                return coleccionEspeciesSimples;
            }

        }

    }
}
