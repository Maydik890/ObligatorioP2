using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Ganado:IValidacion
    {
        public static List<string> idsUtilizados = new List<string>();
        public string Id {  get; set; }
        public string Sexo {  get; set; }
        public string Raza { get; set; }
        public DateTime FechaNac {  get; set; }
        public double CostaAdquisicion {  get; set; }
        public double CosteAlimentario { get; set; }
        public int PesoActual {  get; set; }
        public bool Hibrido { get; set; }
        public List<Vacunacion> Vacunas { get; set; } = new List<Vacunacion>();
        public double CosteCrianza { get; set; }
        public double PrecioEst { get; set; }

        public Ganado() { }
        bool tiene = false;
        public Ganado(string id, string sexo, string raza, DateTime fechaNac, double costaAdquisicion, double costeAlimentario, int pesoActual, bool hibrido)
        {
            if (idsUtilizados.Contains(id))
            {
                tiene = true;
            }
            Id = id;
            Sexo = sexo;
            Raza = raza;
            FechaNac = fechaNac;
            CostaAdquisicion = costaAdquisicion;
            CosteAlimentario = costeAlimentario;
            PesoActual = pesoActual;
            Hibrido = hibrido;
            idsUtilizados.Add(id);
            CosteCrianza = CalcCosteCrianza();
            PrecioEst = CalcPrecioEst();

        }
       
        public virtual void EsValido()
        {
            if(Id == null || Id.Length<8 || tiene ) {
                throw new Exception("Id no valido o ya esta en uso");
            }
            if(string.IsNullOrEmpty(Sexo))
            {
                throw new Exception("El sexo no puede estar vacio");
            }
            if (string.IsNullOrEmpty(Raza))
            {
                throw new Exception("La raza no puede estar vacia");
            }
            
        }
        public void AltaVacunacion(Vacuna v, DateTime fecha)
        {
            Vacunacion v1 = new Vacunacion(v,fecha);
            Vacunas.Add(v1);
        }
        public double CalcCosteCrianza()
        {
            int costovacunas=Vacunas.Count()*200;
            double costeCrianza = CosteAlimentario + CostaAdquisicion + costovacunas;
            return costeCrianza;
        }
        public abstract double CalcPrecioEst(); 
        public List<Vacunacion> GetVacunacions()
        {
            List<Vacunacion> ret = Vacunas;
            return(ret);
        }
        public abstract string GetTipo();
        
    }
}
