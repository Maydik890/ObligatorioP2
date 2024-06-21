using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Empleado:IValidacion
    {
        public static int UltimoId { get; set; }
        public int Id {  get; set; }
        public string Email { get; set; }
        public string Contra {get; set; }
        public string Nombre { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Empleado() { 
            Id = UltimoId++;
        }

        public Empleado(string email, string contra, string nombre, DateTime fechaIngreso)
        {
            Id = UltimoId++;
            Email = email;
            Contra = contra;
            Nombre = nombre;
            FechaIngreso = fechaIngreso;
        }
        public virtual void EsValido()
        {
            string patron = @"^[a-zA-Z0-9._-]{3,}@[a-zA-Z0-9.-]{3,}\.[a-zA-Z]{2,7}$";
            if (string.IsNullOrEmpty(Email) || !Regex.IsMatch(Email, patron))
            {
                throw new Exception("Email invalido");
            }
            if (string.IsNullOrEmpty(Contra))
            {
                throw new Exception("Contraseña invalida");
            }
            if (string.IsNullOrEmpty(Nombre))
            {
                throw new Exception("Nombre invalido");
            }
        }
        public virtual void AltaTarea(Tarea t) { }
        
        
    }
}
