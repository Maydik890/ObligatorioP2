using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Bovino : Ganado
    {
        public string TipoAlimentacion {  get; set; }
        public double PrecioKgEnPie { get; set; } = 10;

        public Bovino() : base() { }

        public Bovino(string id, string sexo, string raza, DateTime fechaNac, double costaAdquisicion, double costeAlimentario, int pesoActual, bool hibrido, string tipoAlimentacion) : base(id, sexo, raza, fechaNac, costaAdquisicion, costeAlimentario, pesoActual, hibrido)
        {
            TipoAlimentacion = tipoAlimentacion;
           
        }
        public override void EsValido()
        {
            base.EsValido();
        }
        public override double CalcPrecioEst()
        {
            string sexo = Sexo.ToUpper();
            double precioAnimal = PrecioKgEnPie * PesoActual;
            double precioEst = precioAnimal;
           // string alimentacion = TipoAlimentacion.ToUpper();
            //if(alimentacion == "GRANO")
            //{
            //    precioEst *= 1.3;
            //}
            if(sexo =="HEMBRA") 
            { 
                precioEst *= 1.1; 
            
            }
            return precioEst;
        }
        public override string GetTipo()
        {
            return "BOVINO";
        }
    }
}
