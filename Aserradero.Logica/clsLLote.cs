using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Datos;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLLote
    {

        // Instancia el objeto de la siguiente capa
        clsDLote datosLote = new clsDLote();

        //ALTA LOTE
        public void altaLote(clsELote ingresadoLote)
        {
            datosLote.altaLote(ingresadoLote); // Le envia a la siguiente capa el objeto entidad
        }

        //BAJA LOTE
        public void bajaLote(clsELote ingresadoLote)
        {
            datosLote.bajaLote(ingresadoLote); // Le envia a la siguiente capa el objeto entidad
        }

        //LISTAR TODOS LOS LOTES
        public List<clsELote> listarLotes()
        {
            List<clsELote> coleccionLotes = new List<clsELote>(); // Declaro una lista de objetos de tipo entidad lote
            coleccionLotes = datosLote.listarLotes(); // Se ejecuta la función y se guarda en la lista la información recibida
            return coleccionLotes; // Devuelve la lista de entidades
        }

        //INFORME filtro por usuario
        public List<clsELote> informeRegistroPorUsuario(int ciUsuario)
        {
            List<clsELote> coleccionLotes = new List<clsELote>(); // Declaro una lista de objetos de tipo entidad Lote
            coleccionLotes = datosLote.listarLotesPorUsuario(ciUsuario); // Se ejecuta la función y se guarda en la lista la información recibida
            return coleccionLotes; // Devuelve la lista de entidades
        }

        //INFORME filtro por producto
        public List<clsELote> informeRegistroPorProducto(int idProducto)
        {
            List<clsELote> coleccionLotes = new List<clsELote>(); // Declaro una lista de objetos de tipo entidad Lote
            coleccionLotes = datosLote.listarLotesPorProducto(idProducto); // Se ejecuta la función y se guarda en la lista la información recibida
            return coleccionLotes; // Devuelve la lista de entidades
        }

    }

}