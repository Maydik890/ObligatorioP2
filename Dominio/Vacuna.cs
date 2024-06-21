using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vacuna:IValidacion
    {
        public string Nombre {  get; set; }
        public string Descripcion {  get; set; }
        public string Patogeno {  get; set; }

        public Vacuna() { }

        public Vacuna(string nombre, string descripcion, string patogeno)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Patogeno = patogeno;
        }
        public void EsValido()
        {

        }
    }
}
