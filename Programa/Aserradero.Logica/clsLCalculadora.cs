using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aserradero.Entidades;

namespace Aserradero.Logica
{
    public class clsLCalculadora
    {

        public Double[] resultado { get; set;} //variable de tipo entero que representa el valor de la cantidad de productos resultantes

        //Calculos para los diferentes productos resultantes
        public double[] calcularproductoResultante(clsEGrupoTroza troza) //, clsEProducto producto)
        {
            //switch (producto.id)
            //{}

            //calculo para piques
            resultado[1] = Math.Pow((troza.diametro / 5), 2); //número estimado
            resultado[0] = resultado[1] * 0.8; //número estimado mínimo, es el 20% menos de margen de error
            resultado[2] = resultado[1] * 1.2; //número estimado máximo, es el 20% más de margen de error
            return resultado;
        }
    }
}
