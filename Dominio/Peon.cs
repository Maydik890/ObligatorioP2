using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Peon : Empleado
    {
        public bool Residente {  get; set; }
        public List<Tarea> Tareas { get; set; } = new List<Tarea>();

        public Peon() : base() 
        { }

        public Peon(string email, string contra, string nombre, DateTime fechaIngreso, bool residente) : base(email, contra, nombre, fechaIngreso)
        {
            Residente = residente;
        }
        public override void EsValido()
        {
            base.EsValido();
        }
        public override void AltaTarea(Tarea t)
        {
            
            Tareas.Add(t);

        }

        public List<Tarea> GetTareas()
        {
            return Tareas;
        }
        public List<Tarea> GetTareasPorFechaPactada()
        {
            Tareas.Sort();
            return Tareas;
        }
        public Tarea GetTareaXId(int id)
        {
            foreach(Tarea t in Tareas)
            {
                if (t.Id.Equals(id))
                {
                    return t;
                }
                
            }
            throw new Exception("Tarea Invalida");
        }
        public int TareasIncompletas()
        {
            int contador = 0;
            foreach (Tarea t in Tareas)
            {
                if(t.Finalizada is not true)
                {
                    contador++;
                }
            }
            return contador;
        }
    }
}
