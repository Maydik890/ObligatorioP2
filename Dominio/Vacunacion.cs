using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vacunacion
    {
        public Vacuna Vacuna { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vencimiento { get; set; }
        public Vacunacion() { }

        public Vacunacion(Vacuna vacuna, DateTime fecha)
        {
            Vacuna = vacuna;
            Fecha = fecha;
            CalcularVencimiento();
           
        }
        public void CalcularVencimiento()
        {
            Vencimiento = Fecha.AddMonths(12);
            
        }
    }
}
