using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        List<Empleado> _empleados = new List<Empleado>();
        List<Ganado> _ganado = new List<Ganado>();
        List<Potrero> _potreros = new List<Potrero>();
        List<Vacuna> _vacunas = new List<Vacuna>();
        private static Sistema instancia = null;
        public List<Empleado> GetEmpleados() { return _empleados; }
        public List<Ganado> GetGanados() { return _ganado; }
        public List<Potrero> GetPotreros() { return _potreros; }
        public List<Vacuna> GetVacunas() { return _vacunas; }

        private Sistema()
        {
            Precarga();
        }
        public static Sistema GetInstancia()
        {

            if (instancia == null)
            {

                instancia = new Sistema();
            }
            return instancia;

        }
        #region precarga
        private void Precarga()
        {
            Empleado empleado1 = new Peon("jose12@gmail.com","Josesito12","Jose Carrasco",new DateTime(2022,12,5),true);AltaEmpleado(empleado1);
            Empleado empleado2 = new Peon("maria.lopez@empresa.com", "María456", "María López", new DateTime(2020, 06, 15), false); AltaEmpleado(empleado2);
            Empleado empleado3 = new Peon("pedro.garcia@empresa.com", "Pedro777", "Pedro García", new DateTime(2019, 12, 01), true); AltaEmpleado(empleado3);
            Empleado empleado4 = new Peon("ana.rodriguez@empresa.com", "Anaro222", "Ana Rodríguez", new DateTime(2021, 03, 15), false); AltaEmpleado(empleado4);
            Empleado empleado5 = new Peon("luis.gonzalez@empresa.com", "LuisGGG", "Luis González", new DateTime(2020, 02, 01), true); AltaEmpleado(empleado5);
            Empleado empleado6 = new Peon("carla.gomez@empresa.com", "Carla123", "Carla Gómez", new DateTime(2021, 07, 10), false); AltaEmpleado(empleado6);
            Empleado empleado7 = new Peon("miguel.martinez@empresa.com", "MiguelMM", "Miguel Martínez", new DateTime(2019, 11, 15), true); AltaEmpleado(empleado7);
            Empleado empleado8 = new Peon("laura.fernandez@empresa.com", "Laura666", "Laura Fernández", new DateTime(2020, 05, 01), false); AltaEmpleado(empleado8);
            Empleado empleado9 = new Peon("jorge.sanchez@empresa.com", "JorgeAAA", "Jorge Sánchez", new DateTime(2021, 09, 01), true); AltaEmpleado(empleado9);
            Empleado empleado10 = new Peon("sandra.hernandez@empresa.com", "Sandra999", "Sandra Hernández", new DateTime(2020, 04, 15), false); AltaEmpleado(empleado10);
            Empleado empleado11 = new Peon("david.torres@empresa.com", "David444", "David Torres", new DateTime(2019, 10, 01), true); AltaEmpleado(empleado11);
            Empleado empleado12 = new Peon("patricia.diaz@empresa.com", "PatriciaBBB", "Patricia Díaz", new DateTime(2021, 02, 10), false); AltaEmpleado(empleado12);
            Empleado empleado13 = new Peon("alberto.castro@empresa.com", "Alberto555", "Alberto Castro", new DateTime(2020, 11, 15), true); AltaEmpleado(empleado13);
            Empleado empleado14 = new Peon("susana.gimenez@empresa.com", "SusanaCCC", "Susana Giménez", new DateTime(2019, 09, 01), false); AltaEmpleado(empleado14);
            Empleado empleado15 = new Peon("francisco.ruiz@empresa.com", "Francisco111", "Francisco Ruiz", new DateTime(2021, 05, 10), true); AltaEmpleado(empleado15);
            Empleado empleado16 = new Peon("juan.perez@empresa.com", "Juan123", "Juan Pérez", new DateTime(2021, 01, 01), true); AltaEmpleado(empleado16);

            Empleado empleado17 = new Capataz("pablo43@gmail.com", "Pablo33", "Pablo Gonzales", new DateTime(2020, 02, 25), 12);AltaEmpleado(empleado17);
            Empleado empleado18 = new Capataz("marcos_2@gmail.com", "MarcosG2", "Marcos Platzi", new DateTime(2017, 06, 12), 12); AltaEmpleado(empleado18);

            Ganado ganado1 = new Bovino("A3G1AS40", "Macho", "Angus", new DateTime(2020, 10, 23), 500, 700, 150, false, "Forraje"); AltaGanado(ganado1);
            Ganado ganado2 = new Bovino("E5F6G7H8", "Hembra", "Hereford", new DateTime(2018, 05, 05), 1200, 40, 400, false, "Grano");AltaGanado(ganado2);
            Ganado ganado3 = new Bovino("I9J0K1L2", "Macho", "Brangus", new DateTime(2020, 03, 10), 1800, 60, 500, true, "Pastura");AltaGanado(ganado3);
            Ganado ganado4 = new Bovino("M3N4O5P6", "Hembra", "Santa Gertrudis", new DateTime(2019, 02, 14), 1100, 35, 380, false, "Grano");AltaGanado(ganado4);
            Ganado ganado5 = new Bovino("Q7R8S9T0", "Macho", "Charolais", new DateTime(2018, 11, 01), 2000, 70, 600, true, "Pastura");AltaGanado(ganado5);
            Ganado ganado6 = new Bovino("U1V2W3X4", "Hembra", "Limousin", new DateTime(2020, 01, 20), 1400, 50, 420, false, "Grano");AltaGanado(ganado6);
            Ganado ganado7 = new Bovino("Y5Z6A7B8", "Macho", "Simmental", new DateTime(2019, 09, 05), 1600, 60, 550, true, "Pastura"); AltaGanado(ganado7);
            Ganado ganado8 = new Bovino("C9D0E1F2", "Hembra", "Brahman", new DateTime(2018, 07, 15), 1300, 45, 410, false, "Grano"); AltaGanado(ganado8);
            Ganado ganado9 = new Bovino("G3H4I5J6", "Macho", "Beefmaster", new DateTime(2020, 06, 01), 1700, 65, 520, true, "Pastura"); AltaGanado(ganado9);
            Ganado ganado10 = new Bovino("K7L8M9N0", "Hembra", "Gelbvieh", new DateTime(2019, 05, 25), 1250, 40, 390, false, "Grano"); AltaGanado(ganado10);
            Ganado ganado11 = new Bovino("P1Q2R3S4", "Macho", "Shorthorn", new DateTime(2018, 04, 10), 1450, 55, 460, true, "Pastura"); AltaGanado(ganado11);
            Ganado ganado12 = new Bovino("T5U6V7W8", "Hembra", "Red Angus", new DateTime(2020, 03, 03), 1300, 45, 410, false, "Grano"); AltaGanado(ganado12);
            Ganado ganado13 = new Bovino("X9Y0Z1A2", "Macho", "Maine Anjou", new DateTime(2019, 02, 20), 1900, 65, 580, true, "Pastura"); AltaGanado(ganado13);
            Ganado ganado14 = new Bovino("B3C4D5E6", "Hembra", "Chianina", new DateTime(2018, 12, 01), 2100, 70, 620, false, "Grano"); AltaGanado(ganado14);
            Ganado ganado15 = new Bovino("F7G8H9I0", "Macho", "Braford", new DateTime(2020, 01, 15), 1600, 50, 530, true, "Pastura"); AltaGanado(ganado15);
            Ganado ganado16 = new Bovino("J1K2L3M4", "Hembra", "Simbrah", new DateTime(2019, 10, 10), 1200, 40, 370, false, "Grano"); AltaGanado(ganado16);
            Ganado ganado17 = new Bovino("N5O6P7Q8", "Macho", "Salers", new DateTime(2018, 08, 25), 1500, 60, 500, true, "Pastura"); AltaGanado(ganado17);
            Ganado ganado18 = new Bovino("A1B2C3D4", "Macho", "Angus", new DateTime(2019, 04, 12), 1500, 50, 450, true, "Pastura"); AltaGanado(ganado18);

            Ganado ganado19 = new Ovino("A6G2C3D4", "Macho", "Merino", new DateTime(2019, 03, 15), 200, 50, 60, true, 8);AltaGanado(ganado19);
            Ganado ganado20 = new Ovino("E2WRG7H8", "Hembra", "Suffolk", new DateTime(2018, 10, 01), 180, 40, 70, false, 6); AltaGanado(ganado20);
            Ganado ganado21 = new Ovino("ISJ1K5L2", "Macho", "Dorper", new DateTime(2020, 02, 20), 250, 60, 80, true, 4); AltaGanado(ganado21);
            Ganado ganado22 = new Ovino("F3N4O2EA", "Hembra", "Corriedale", new DateTime(2019, 04, 12), 160, 35, 55, false, 5); AltaGanado(ganado22);
            Ganado ganado23 = new Ovino("A458S9T0", "Macho", "Hampshire", new DateTime(2018, 09, 05), 220, 55, 90, true, 7); AltaGanado(ganado23);
            Ganado ganado24 = new Ovino("ASW2W3X4", "Hembra", "Romney", new DateTime(2020, 01, 25), 210, 45, 65, false, 9); AltaGanado(ganado24);
            Ganado ganado25= new Ovino("Y55SA7B8", "Macho", "Southdown", new DateTime(2019, 06, 10), 150, 30, 50, true, 6); AltaGanado(ganado25);
            Ganado ganado26 = new Ovino("C1S0E1F2", "Hembra", "Texel", new DateTime(2018, 12, 01), 240, 60, 85, false, 10); AltaGanado(ganado26);
            Ganado ganado27 = new Ovino("G3H2I5J6", "Macho", "Rambouillet", new DateTime(2020, 05, 05), 270, 70, 95, true, 12); AltaGanado(ganado27);
            Ganado ganado28 = new Ovino("K7AWM9N0", "Hembra", "Polypay", new DateTime(2019, 02, 22), 190, 40, 68, false, 7); AltaGanado(ganado28);
            Ganado ganado29 = new Ovino("P14SR3S4", "Macho", "Cheviot", new DateTime(2018, 11, 15), 230, 50, 75, true, 9); AltaGanado(ganado29);
            Ganado ganado30 = new Ovino("T5A2V7W8", "Hembra", "East Friesian", new DateTime(2020, 03, 08), 300, 80, 100, false, 15); AltaGanado(ganado30);
            Ganado ganado31 = new Ovino("X9A9Z1A2", "Macho", "Border Leicester", new DateTime(2019, 05, 01), 350, 90, 110, true, 11); AltaGanado(ganado31);
            Ganado ganado32 = new Ovino("N3S1D5E6", "Hembra", "Dorset", new DateTime(2018, 07, 20), 260, 65, 88, false, 8); AltaGanado(ganado32);
            Tarea tarea1 =new Tarea("Trabajo de campo", new DateTime(2024, 4, 12));
            Tarea tarea2 =new Tarea("Limpiar el galpón", new DateTime(2023, 03, 15));
            Tarea tarea3 = new Tarea("Arreglar el alambrado del potrero", new DateTime(2023, 03, 20));
            Tarea tarea4 = new Tarea("Vacunar a los terneros", new DateTime(2023, 03, 22));
            Tarea tarea5 = new Tarea("Cortar el pasto del sector sur", new DateTime(2023, 03, 25));
            Tarea tarea6 = new Tarea("Reparar el tractor", new DateTime(2023, 03, 28));
            Tarea tarea7 = new Tarea("Alimentar a las ovejas", new DateTime(2023, 03, 30));
            Tarea tarea8 = new Tarea("Clasificar la lana", new DateTime(2023, 04, 02));
            Tarea tarea9 = new Tarea("Marcar los corderos", new DateTime(2023, 04, 05));
            Tarea tarea10 = new Tarea("Reponer las vacunas", new DateTime(2023, 04, 07));
            Tarea tarea11 = new Tarea("Pintar las instalaciones", new DateTime(2023, 04, 10));
            Tarea tarea12 = new Tarea("Cosechar la alfalfa", new DateTime(2023, 04, 15));
            Tarea tarea13 = new Tarea("Reparar el tanque de agua", new DateTime(2023, 04, 18));
            Tarea tarea14 = new Tarea("Cortar el pasto del sector norte", new DateTime(2023, 04, 22));
            Tarea tarea15 = new Tarea("Armar el nuevo galpón", new DateTime(2023, 04, 25));
            Tarea tarea16 = new Tarea("Realizar la desparasitación de los animales", new DateTime(2023, 04, 30));
            tarea1.CompletarTarea("Reabastecimiento de comida de grano");
            tarea3.CompletarTarea("Alambrado reparado con éxito");
            tarea5.CompletarTarea("Pasto cortado y recogido");
            tarea15.CompletarTarea("Galpón armado y listo para usar");
            tarea13.CompletarTarea("Tanque reparado y lleno de agua");
            tarea11.CompletarTarea("Instalaciones pintadas en su totalidad");
            tarea9.CompletarTarea("Todos los corderos marcados correctamente");
            tarea7.CompletarTarea("Alimentación completa");
            empleado1.AltaTarea(tarea1);
            empleado2.AltaTarea(tarea2);
            empleado3.AltaTarea(tarea3);
            empleado3.AltaTarea(tarea4);
            empleado4.AltaTarea(tarea5);
            empleado1.AltaTarea(tarea6);
            empleado2.AltaTarea(tarea7);
            empleado2.AltaTarea(tarea8);
            empleado15.AltaTarea(tarea9);
            empleado12.AltaTarea(tarea10);
            empleado13.AltaTarea(tarea11);
            empleado12.AltaTarea(tarea12);
            empleado10.AltaTarea(tarea13);
            empleado8.AltaTarea(tarea14);
            empleado12.AltaTarea(tarea15);
            empleado6.AltaTarea(tarea16);
      
            Vacuna vacuna1 = new Vacuna("Triangle 10", "Vacuna contra clostridios y leptospiras", "Clostridium y Leptospira");
            AltaVacuna(vacuna1);

            Vacuna vacuna2 = new Vacuna("Bovilis MH + IBR", "Vacuna contra la enfermedad de Aujeszky y la rinotraqueitis infecciosa bovina", "Herpesvirus bovino 1 y virus de la enfermedad de Aujeszky");
            AltaVacuna(vacuna2);

            Vacuna vacuna3 = new Vacuna("Ovipast RSP", "Vacuna contra la enfermedad respiratoria sincicial ovina", "Virus respiratorio sincicial ovino");
            AltaVacuna(vacuna3);

            Vacuna vacuna4 = new Vacuna("Ultravac 7", "Vacuna contra clostridios y campylobacteriosis", "Clostridium y Campylobacter");
            AltaVacuna(vacuna4);

            Vacuna vacuna5 = new Vacuna("Covexin 8", "Vacuna contra clostridios y pasteurella", "Clostridium y Pasteurella");
            AltaVacuna(vacuna5);

            Vacuna vacuna6 = new Vacuna("Progressis", "Vacuna contra la fiebre Q", "Coxiella burnetii");
            AltaVacuna(vacuna6);

            Vacuna vacuna7 = new Vacuna("Glanvac 6", "Vacuna contra clostridios y salmonela", "Clostridium y Salmonella");
            AltaVacuna(vacuna7);

            Vacuna vacuna8 = new Vacuna("Bovilis Rotavec Corona", "Vacuna contra la diarrea vírica bovina", "Rotavirus y coronavirus bovinos");
            AltaVacuna(vacuna8);

            Vacuna vacuna9 = new Vacuna("Ovilis Pulpyvax", "Vacuna contra la pulmonía pasteurelosa ovina", "Pasteurella multocida y Mannheimia haemolytica");
            AltaVacuna(vacuna9);

            Vacuna vacuna10 = new Vacuna("Bovilis BVD", "Vacuna contra la diarrea viral bovina", "Virus de la diarrea viral bovina");
            AltaVacuna(vacuna10);
            
            ganado1.AltaVacunacion(vacuna9, new DateTime(2024, 01, 10));
            ganado1.AltaVacunacion(vacuna1, new DateTime(2024, 03, 21));
            ganado2.AltaVacunacion(vacuna3, new DateTime(2023, 09, 21));
            ganado3.AltaVacunacion(vacuna4, new DateTime(2023, 08, 14));
            ganado5.AltaVacunacion(vacuna4, new DateTime(2023, 12, 09));
            ganado5.AltaVacunacion(vacuna5, new DateTime(2024, 04, 30));
            ganado7.AltaVacunacion(vacuna10, new DateTime(2023, 03, 31));
            ganado7.AltaVacunacion(vacuna4, new DateTime(2023, 07, 12));
            ganado12.AltaVacunacion(vacuna10, new DateTime(2023, 08, 16));
            ganado20.AltaVacunacion(vacuna5, new DateTime(2023, 09, 20));
            ganado25.AltaVacunacion(vacuna6, new DateTime(2024, 04, 25));
            ganado20.AltaVacunacion(vacuna1, new DateTime(2023, 10, 03));
            ganado30.AltaVacunacion(vacuna10, new DateTime(2023, 11, 15));
            ganado32.AltaVacunacion(vacuna7, new DateTime(2023, 11, 01));
            ganado32.AltaVacunacion(vacuna4, new DateTime(2023, 12, 05));
            ganado15.AltaVacunacion(vacuna10, new DateTime(2023, 07, 10));
            ganado9.AltaVacunacion(vacuna2, new DateTime(2023, 06, 23));

            Potrero potrero1 = new Potrero("Potrero Norte", 50, 90);AltaPotrero(potrero1);
            Potrero potrero2 = new Potrero("Potrero Sur", 80, 144); AltaPotrero(potrero2);
            Potrero potrero3 = new Potrero("Potrero Este", 30, 45); AltaPotrero(potrero3);
            Potrero potrero4 = new Potrero("Potrero Oeste", 60, 108); AltaPotrero(potrero4);
            Potrero potrero5 = new Potrero("Potrero Central", 100, 180); AltaPotrero(potrero5);
            Potrero potrero6 = new Potrero("Potrero El Molino", 70, 126); AltaPotrero(potrero6);
            Potrero potrero7 = new Potrero("Potrero Los Alamos", 40, 72); AltaPotrero(potrero7);
            Potrero potrero8 = new Potrero("Potrero Las Vacas", 120, 216); AltaPotrero(potrero8);
            Potrero potrero9 = new Potrero("Potrero Las Ovejas", 25, 45); AltaPotrero(potrero9);
            Potrero potrero10 = new Potrero("Potrero Los Caballos", 35, 63); AltaPotrero(potrero10);
            potrero1.AgregarGanado(ganado32);
            potrero2.AgregarGanado(ganado31);
            potrero3.AgregarGanado(ganado29);
            potrero4.AgregarGanado(ganado30);
            potrero2.AgregarGanado(ganado20);
            potrero1.AgregarGanado(ganado2);
            potrero3.AgregarGanado(ganado1);
            potrero2.AgregarGanado(ganado3);
            potrero1.AgregarGanado(ganado4);
            potrero2.AgregarGanado(ganado5);
            potrero3.AgregarGanado(ganado23);
            potrero6.AgregarGanado(ganado26);
            potrero6.AgregarGanado(ganado17);
            potrero6.AgregarGanado(ganado18);
            potrero3.AgregarGanado(ganado19);
            potrero7.AgregarGanado(ganado7);
            potrero7.AgregarGanado(ganado6);
            potrero2.AgregarGanado(ganado8);
            potrero3.AgregarGanado(ganado9);
            potrero5.AgregarGanado(ganado10);
            potrero4.AgregarGanado(ganado12);
            potrero5.AgregarGanado(ganado11);
            potrero3.AgregarGanado(ganado13);
            potrero6.AgregarGanado(ganado14);
            potrero10.AgregarGanado(ganado15);
            potrero10.AgregarGanado(ganado16);
            potrero10.AgregarGanado(ganado24);
            potrero10.AgregarGanado(ganado25);
            potrero8.AgregarGanado(ganado27);
            potrero9.AgregarGanado(ganado28);
            potrero9.AgregarGanado(ganado21);
            potrero2.AgregarGanado(ganado22);
           

        }
        #endregion
        public List<Capataz> GetCapataz()
        {
            List<Capataz> ret = new List<Capataz>();
            foreach(Empleado e in _empleados)
            {
                if(e is Capataz)
                {
                    ret.Add((Capataz)e);
                }
            }
            return ret;
        }
        
        public List<Peon> GetPeones()
        {
            List<Peon> ret = new List<Peon>();
            foreach (Empleado e in _empleados)
            {
                if (e is Peon)
                {
                    ret.Add((Peon)e);
                }
            }
            return ret;
        }
        public Peon GetPeonXId(int? id)
        {
            foreach(Peon p in _empleados)
            {
                if (p.Id.Equals(id))
                {
                    return p;
                }
            }
            return null;
        }
        public List<Ovino> GetOvinos()
        {
            List<Ovino> ret = new List<Ovino>();
            foreach(Ganado g in _ganado)
            {
                if(g is Ovino)
                {
                    ret.Add((Ovino)g);
                }
            }
            return ret;
        }
        public List<Bovino> GetBovinos()
        {
            List<Bovino> ret = new List<Bovino>();
            foreach (Ganado g in _ganado)
            {
                if (g is Bovino)
                {
                    ret.Add((Bovino)g);
                }
            }
            return ret;
        }
        public void AltaEmpleado(Empleado e)
        {
            
            try { 
            e.EsValido();
            _empleados.Add(e);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        public void AltaGanado(Ganado g)
        {
            try { 
            g.EsValido();
            _ganado.Add(g);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public void AltaPotrero(Potrero p)
        {
            try
            {
                p.EsValido();
                _potreros.Add(p);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
        public void AltaVacuna(Vacuna v)
        {
            try
            {
                v.EsValido();
                _vacunas.Add(v);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        

        public List<Potrero> GetPotreroPorCapYHect(int hect,int cap)
        {
            List<Potrero> ret = new List<Potrero>();
            foreach (Potrero p in _potreros)
            {
                if (p.CantHectareas>hect && p.CapacidadMax>cap)
                {

                    ret.Add(p);

                }
            }
            return ret;
        }
        public List<Potrero> GetPotreroOrdenado()
        {
            _potreros.Sort();
            return _potreros;
        }

        public Empleado Login(string ema, string contra)
        {
            foreach(Empleado e in _empleados)
            {
                if(e.Email == ema && e.Contra == contra)
                {
                    return e;
                }
            }

            return null;
        }

        public Ganado GetGanadoXId(string id)
        {
            foreach (Ganado g in _ganado)
            {
                if (g.Id.Equals(id))
                {
                    return g;
                }
            }
            throw new Exception("Ganado no encontrado");
        }

        public Vacuna GetVaunaXNombre(string nombre)
        {
            foreach(Vacuna v in _vacunas)
            {
                if(v.Nombre == nombre) { return v; }
            }

            throw new Exception("Vacuna no valida");
        }

        public Potrero GetPotreroXId(int Id)
        {
            foreach (Potrero p in _potreros)
            {
                if (p.Id.Equals(Id))
                {
                    return p;
                }
            }
            throw new Exception("Potrero no valido");
        }

        public List<Ganado> GetGanadosXPesoTipo(int peso, string tipo)
        {
            List<Ganado> ret = new List<Ganado>();
            foreach(Ganado g in _ganado)
            {
                if(g.PesoActual>peso && g.GetTipo() == tipo)
                {
                    ret.Add(g);
                }
                else if(g.PesoActual > peso && tipo =="TODOS")
                {
                    ret.Add(g);
                }
            }
            return ret;
        }
    }
}
