using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLRegistro
    {
        
        // Instancia el objeto de la siguiente capa
        clsDRegistro datosRegistro = new clsDRegistro();

        //ALTA REGISTRO
        public void altaRegistro(clsERegistro inicio)
        {
            datosRegistro.altaRegistro(inicio); // Le envia a la siguiente capa el objeto entidad
        }

        //LISTAR REGISTRO
        public List<clsERegistro> listarRegistro()
        {
            List<clsERegistro> coleccionRegistros = new List<clsERegistro>(); // Declaro una lista de objetos de tipo entidad Registro
            coleccionRegistros = datosRegistro.listarRegistros(); // Se ejecuta la función y se guarda en la lista la información recibida
            return coleccionRegistros; // Devuelve la lista de entidades
        }

        //INFORME filtro por fecha
        public List<clsERegistro> informeRegistroPorFecha(string fechaSesion)
        {
            List<clsERegistro> coleccionRegistros = new List<clsERegistro>(); // Declaro una lista de objetos de tipo entidad Registro
            coleccionRegistros = datosRegistro.listarRegistroPorFecha(fechaSesion); // Se ejecuta la función y se guarda en la lista la información recibida
            return coleccionRegistros; // Devuelve la lista de entidades
        }

        //INFORME filtro por usuario
        public List<clsERegistro> informeRegistroPorUsuario(int ci)
        {
            List<clsERegistro> coleccionRegistros = new List<clsERegistro>(); // Declaro una lista de objetos de tipo entidad Registro
            coleccionRegistros = datosRegistro.listarRegistroPorUsuario(ci); // Se ejecuta la función y se guarda en la lista la información recibida
            return coleccionRegistros; // Devuelve la lista de entidades
        }

    }

}
