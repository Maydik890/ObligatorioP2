using Dominio;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObligatorioUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema s = Sistema.GetInstancia();
            int op = -1;
            while (op != 0) 
            {
                ArmarMenu();
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    List<Ganado>lf = s.GetGanados();
                    foreach (Ganado g in lf)
                    {
                        Console.WriteLine(g.Id+" "+g.Raza+" "+g.PesoActual+" "+g.Sexo);
                        Console.WriteLine("----------------------");
                    }
                }
                else if (op == 2)
                {

                    try { 
                        Console.WriteLine("Ingrese cantidad de hectáreas minima:");
                        int cantHect = int.Parse(Console.ReadLine());
                    



                    Console.WriteLine("Ingrese capacidad maxima minima:");
                    int capMax = int.Parse(Console.ReadLine());
                    List<Potrero> lf = s.GetPotreroPorCapYHect(cantHect, capMax);
                    foreach(Potrero p in lf)
                    {
                        Console.WriteLine(p.Id + " " + p.Descripcion + " " + p.CantHectareas + " " + p.CapacidadMax);
                        Console.WriteLine("------------------------------");
                    }
                    }catch(Exception ex)
                    {
                        Console.WriteLine("ingrese un numero valido");
                    }
                }
                else if (op == 3)
                {
                    try { 
                    Console.WriteLine("Ingrese el precio por kilo de lana:");
                    double precio = int.Parse(Console.ReadLine());
                    Ovino.CambiarPrecioKgLana(precio);
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Ingrese un numero valido");
                    }

                }
                else if (op == 4)
                {
                    Console.WriteLine("Ingrese el codigo alfanumerico de la caravana");
                    string id = Console.ReadLine().ToUpper();
                    Console.WriteLine("Ingrese el sexo del animal");
                    string sexo = Console.ReadLine();
                    Console.WriteLine("Ingrese la raza del animal") ;
                    string raza = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de nacimiento con el formato YYYY/MM/DD");
                    DateTime fechaNac = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el costo de adquicision del animal");
                    double costoAdq = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el costo aproximado de alimentacion");
                    double costoAlim = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el peso actual del animal");
                    int pesoActual = int.Parse(Console.ReadLine());
                    Console.WriteLine("Es hibrido? si/no");
                    string hibrido = Console.ReadLine();
                    bool esHibrido = false;
                    
                    if(hibrido == "si")
                    {
                        esHibrido = true;
                    }

                    Console.WriteLine("Ingrese el tipo de alimentacion para el animal");
                    string tipoAlimentacion = Console.ReadLine();
                  
                    Ganado nuevo = new Bovino(id,sexo,raza,fechaNac,costoAdq,costoAlim,pesoActual,esHibrido,tipoAlimentacion);
                    try
                    {
                        s.AltaGanado(nuevo);
                        Console.WriteLine("Alta correcta");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                
                
                Console.ReadKey();
            }
        }
        private static void ArmarMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Listar Animales");
            Console.WriteLine("2 - Potreros Segun la capacidad y hectareas");
            Console.WriteLine("3 - Establecer precio por kilogramo de lana");
            Console.WriteLine("4 - Alta de Bovino");
            Console.WriteLine("0 - Salir");
        }
    }
}
