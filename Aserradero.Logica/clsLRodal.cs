using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLRodal
    {
        
        // Instancia el objeto de la siguiente capa
        clsDRodal datosRodal = new clsDRodal();

        //ALTA RODAL
        public void altaRodal(clsERodal ingresadoRodal)
        {
            datosRodal.altaRodal(ingresadoRodal); // Le envia a la siguiente capa el objeto entidad
        }

        //BAJA RODAL
        public void bajaRodal(clsERodal ingresadoRodal)
        {
            datosRodal.bajaRodal(ingresadoRodal); // Le envia a la siguiente capa el objeto entidad
        }

        //MODIFICAR RODAL        
        public void modificarRodal(clsERodal ingresadoRodal)
        {
            datosRodal.modificarRodal(ingresadoRodal); // Le envia a la siguiente capa el objeto entidad
        }

        //LISTAR TODOS LOS RODALES
        public List<clsERodal> listarRodales()
        {
            List<clsERodal> coleccionRodales = new List<clsERodal>(); // Declaro una lista de objetos de tipo entidad rodal
            coleccionRodales = datosRodal.listarRodales(); // Se ejecuta la función y se guarda en la lista la información recibida
            return coleccionRodales; // Devuelve la lista de entidades
        }

        //INFORME RODAL ESPECIFICO
        public clsERodal informeRodal(int idRodal)
        {
            clsERodal rodalParticular = new clsERodal(); // Instancio un objeto de tipo entidad Rodal
            rodalParticular = datosRodal.listarRodalParticular(idRodal); // Se ejecuta la función y se guarda en el objeto la información recibida
            return rodalParticular; //Devuelve la Especie
        }

        //INFORME RODAL POR ESPECIE
        public clsERodal informeRodalPorEspecie(clsEEspecie entidadEspecie)
        {
            clsERodal rodalParticular = new clsERodal(); // Instancio un objeto de tipo entidad Rodal
            rodalParticular = datosRodal.informeRodalPorEspecie(entidadEspecie); // Se ejecuta la función y se guarda en el objeto la información recibida
            return rodalParticular; //Devuelve la Especie
        }
    }

}