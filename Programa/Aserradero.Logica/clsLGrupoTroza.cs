using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLGrupoTroza
    {

        // Instancia el objeto de la siguiente capa
        clsDGrupoTroza datosGrupoTroza = new clsDGrupoTroza();

        //ALTA Grupo de Trozas
        public void altaGrupoTroza(clsEGrupoTroza ingresadoGrupoTroza)
        {
            datosGrupoTroza.altaGrupoTroza(ingresadoGrupoTroza); // Le envia a la siguiente capa el objeto entidad
        }

        //MODIFICAR Grupo de Trozas        
        public void modificarGrupoTroza(clsEGrupoTroza ingresadoGrupoTroza)
        {
            datosGrupoTroza.modificarGrupoTroza(ingresadoGrupoTroza); // Le envia a la siguiente capa el objeto entidad
        }

        //SUMAR TROZAS A UN Grupo de Trozas
        public void sumarTrozas(clsEGrupoTroza ingresadoGrupoTrozas)
        {
            datosGrupoTroza.sumarTrozas(ingresadoGrupoTrozas);
        }

//LISTAR TODOS LOS GRUPOS DE TROZAS
        public List<clsEGrupoTroza> listarGrupoTroza()
        {
            List<clsEGrupoTroza> coleccionGruposTroza = new List<clsEGrupoTroza>(); // Declaro una lista de objetos de tipo entidad grupo troza
            coleccionGruposTroza = datosGrupoTroza.listarGruposTrozas(); // Se ejecuta la función y se guarda en la lista la información recibida

            if (coleccionGruposTroza == null)
            {
                return null;
            }

            return coleccionGruposTroza; // Devuelve la lista de entidades
        }

        //INFORME filtro por rodal
        public List<clsEGrupoTroza> informeGrupoTrozaPorRodal(int idRodal)
        {
            List<clsEGrupoTroza> coleccionGruposTroza = new List<clsEGrupoTroza>(); // Declaro una lista de objetos de tipo entidad grupo troza
            coleccionGruposTroza = datosGrupoTroza.listarGruposTrozasPorRodal(idRodal); // Se ejecuta la función y se guarda en la lista la información recibida

            if (coleccionGruposTroza == null)
            {
                return null;
            }

            return coleccionGruposTroza; // Devuelve la lista de entidades
        }

        //INFORME filtro por diámetro
        public List<clsEGrupoTroza> informeGrupoTrozaPorDiametro(int diametro)
        {
            List<clsEGrupoTroza> coleccionGruposTroza = new List<clsEGrupoTroza>(); // Declaro una lista de objetos de tipo entidad grupo troza
            coleccionGruposTroza = datosGrupoTroza.listarGruposTrozasPorDiametro(diametro); // Se ejecuta la función y se guarda en la lista la información recibida

            if (coleccionGruposTroza == null)
            {
                return null;
            }

            return coleccionGruposTroza; // Devuelve la lista de entidades
        }

        //Verificar cantidad
        public bool confirmarCantidad(clsEGrupoTroza entidadgrupotroza, int cantidadNesesaria)
        {
            bool resultado = false;
            if (entidadgrupotroza.cantidad >= cantidadNesesaria)
            {
                resultado = true;
            }
            return resultado;
        }

        //INFORME GRUPO DE TROZA ESPECIFICO
        public clsEGrupoTroza informeGrupoTroza(int idGrupoTroza)
        {
            clsEGrupoTroza grupoTrozaParticular = new clsEGrupoTroza(); // Instancio un objeto de tipo entidad Especie
            grupoTrozaParticular = datosGrupoTroza.listarGrupoTrozaParticular(idGrupoTroza); // Se ejecuta la función y se guarda en el objeto la información recibida

            if (grupoTrozaParticular == null)
            {
                return null;
            }

            return grupoTrozaParticular; //Devuelve la Especie
        }
    }

}