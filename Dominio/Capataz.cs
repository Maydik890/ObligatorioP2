using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Capataz : Empleado
    {
        public int CantPers {  get; set; }

        public Capataz():base()
        { }

        public Capataz(string email, string contra, string nombre, DateTime fechaIngreso, int cantPers) : base(email, contra, nombre, fechaIngreso)
        {
            CantPers = cantPers;
        }
        public override void EsValido()
        {
            base.EsValido();
        }
       
     
    }
}
