using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Ovino : Ganado
    {
        public double PesoEstLana {  get; set; }
        public static double PrecioKgLana { get; set; } = 10;
        public double PrecioKgEnPie { get; set; } = 4;

        public Ovino():base() { }

        public Ovino(string id, string sexo, string raza, DateTime fechaNac, double costaAdquisicion, double costeAlimentario, int pesoActual, bool hibrido,double pesoEstLana) : base(id, sexo, raza, fechaNac, costaAdquisicion, costeAlimentario, pesoActual, hibrido)
        {
            PesoEstLana = pesoEstLana;
            
        }
        

        public static void CambiarPrecioKgLana(double precio)
        {
            PrecioKgLana = precio; 
        }

        public override double CalcPrecioEst()
        {
            double precioLana = PesoEstLana * PrecioKgLana;
            double precioAnimal = PrecioKgEnPie * PesoActual;
            double precioEst = precioAnimal+precioLana;
            return precioEst;
        }
        public override string GetTipo()
        {
            return "OVINO";
        }
    }
}
