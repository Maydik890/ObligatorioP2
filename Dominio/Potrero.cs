using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Potrero:IComparable<Potrero>
    {
        public static int UltimoId {  get; set; }
        public int Id {  get; set; }
        public string Descripcion {  get; set; }
        public int CantHectareas {  get; set; }
        public int CapacidadMax { get; set; }
        public List<Ganado> Animales { get; set; }=new List<Ganado>();
        public double PrecioEstimado {  get; set; }

        public Potrero() 
        {
            Id = UltimoId++;
        }

        public Potrero( string descripcion, int cantHectareas, int capacidadMax)
        {
            Id = UltimoId++;
            Descripcion = descripcion;
            CantHectareas = cantHectareas;
            CapacidadMax = capacidadMax;
           
            
        }
        public void AgregarGanado(Ganado g)
        {
            if (!Animales.Contains(g))
            {
                Animales.Add(g);
                CalcPrecioPosible();
            }
            else
            {
                throw new Exception("El animal ya esta en un potrero");
            }
           
        }
        public void EsValido() 
        { 
            //TO DO VALIDATION
        }
        public void CalcPrecioPosible()
        {
            double valor = 0;
            double costo = 0;
            foreach(Ganado g in Animales)
            {
                valor += g.PrecioEst;
                costo += g.CosteCrianza;
            }
            PrecioEstimado = valor - costo;
        }
        public int CompareTo(Potrero? other)
        {
            if (CapacidadMax.CompareTo(other.CapacidadMax) > 0)
            {
                return 1;
            }else if(CapacidadMax.CompareTo(other.CapacidadMax) < 0)
            {
                return -1;
            }
            else
            {
                if(Animales.Count.CompareTo(other.Animales.Count) > 0)
                {
                    return -1;
                }else if (Animales.Count.CompareTo(other.Animales.Count) < 0) 
                {
                    return 1;
                }else
                {
                    return 0;
                }
            }
        }
        
    }
}
