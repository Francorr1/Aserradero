using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLEspecie
    {
        
        // Instancia el objeto de la siguiente capa
        clsDEspecie datosEspecie = new clsDEspecie();

        //ALTA ESPECIE
        public void altaEspecie(clsEEspecie ingresadoEspecie)
        {
            datosEspecie.altaEspecie(ingresadoEspecie); // Le envia a la siguiente capa el objeto entidad
        }

        //MODIFICAR ESPECIE    
        public void modificarEspecie(clsEEspecie ingresadoEspecie)
        {
            datosEspecie.modificarEspecie(ingresadoEspecie); // Le envia a la siguiente capa el objeto entidad
        }

        //LISTAR TODOS LAS ESPECIES
        public List<clsEEspecie> listarEspecies()
        {
            List<clsEEspecie> coleccionEspecies = new List<clsEEspecie>(); // Declaro una lista de objetos de tipo entidad especie
            coleccionEspecies = datosEspecie.listarEspecies(); // Se ejecuta la función y se guarda en la lista la información recibida
            return coleccionEspecies; // Devuelve la lista de entidades
        }
        //INFORME ESPECIE ESPECIFICO
        public clsEEspecie informeEspecie(int idEspecie)
        {
            clsEEspecie especieParticular = new clsEEspecie(); // Instancio un objeto de tipo entidad Especie
            especieParticular = datosEspecie.listarEspecieParticular(idEspecie); // Se ejecuta la función y se guarda en el objeto la información recibida
            return especieParticular; //Devuelve la Especie
        }

    }

}