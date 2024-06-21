using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tarea:IComparable<Tarea>
    {
        public static int UltimoId {  get; set; }
        public int Id {  get; set; }
        public string Descripcion {  get; set; }
        public DateTime FechaPactada { get; set; }
        public bool Finalizada { get; set; }
        public DateTime? FechaCierre {  get; set; }
        public string Comentario {  get; set; }

        public Tarea() {
            Id = UltimoId++;
        }

        public Tarea(string descripcion, DateTime fechaPactada)
        {
            Id = UltimoId++;
            Descripcion = descripcion;
            FechaPactada = fechaPactada;
            Finalizada = false;
           
            
        }

        public void CompletarTarea(string? comentario)
        {
            Comentario = comentario;
            FechaCierre = DateTime.Now;
            Finalizada = true;
        }
        public int CompareTo(Tarea? other)
        {
            if(FechaPactada.CompareTo(other.FechaPactada) > 0)
            {
                return 1;
            }else if(FechaPactada.CompareTo(other.FechaPactada) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
       
    }
}
