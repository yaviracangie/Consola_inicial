using System.Collections.Generic;

namespace Tarea1Consola
{
    public class Competidor
    {
        public List<Enemigo> Enemigo { get; set; } // listas
        public List<Tecnicas> Tecnicas { get; set; }
        public string Nombre { get; set; }   //Propiedades
        public string Apodo { get; set; }
        public string Defensa { get; set; }
        public string Debilididades { get; set; }
        public string Habilidades { get; set; }
        public string Fusiones { get; set; }
        public string Poder { get; set; }
        public string Transformaciones { get; set; }
        public string Trofeo { get; set; }
        public string Recompensa { get; set; }

        public string Saludo ()
        {
            return $"Hola mi nombre es:{Nombre},mi apodo es:{Apodo}";
        }
        public string Ataque()
        {
            return $"MiHabilidad para atacar a mi oponente es: {Habilidades}";
        }       
            public string Proteger()
        {
            return $"Soy un gerrero sayaying llamado:{Nombre},tengo que Proteger de la tierra de su invasores con mis tecnicas:{Tecnicas} y mis super poderes:{Poder}";
        }
       }
                    
    }

