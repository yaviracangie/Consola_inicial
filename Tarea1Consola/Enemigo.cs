using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Consola
{
    public class Enemigo
    {
        public List<Competidor> Competidores { get; set; }
        public List<Tecnicas>Tecnicas { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Debilidad { get; set; }
        public string Defensa { get; set; }
        public string Habilidades { get; set; }
        public string Fusiones { get; set; }
        public string Poder { get; set; }
        public string Transformaciones { get; set; }

        public string Saludo()
        {
            return $"Hola mi nombre es:{Nombre},Y mi apodo es:{Apodo}";
        }
        public string Saludo(string apodoCompetidor)
        {
            return $"Hola{apodoCompetidor}tu seras mi oponente en el torneo de las artes marciales";
        }
        public string MaximoPoder()
        {
            return $"Mi Poder es al maximo es:{Poder},con una gran tecnicas de furia del mal:{Tecnicas}";
        }
         public string MenorPoder()
        {
            return $"Mis devilidades son:{Debilidad} ";
        }
    }
}
