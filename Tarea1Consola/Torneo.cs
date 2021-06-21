using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1Consola
{
   public  class Torneo
    {
        public string Nombre{ get; set; }
        public string Reglas { get; set; }
        public string Tiempo { get; set; }
        public List<Competidor> Competidores  { get; set; }
        public List<Enemigo>Enemigos { get; set; }
        public string Fecha { get; set; }
        public string Mes { get; set; }
        public string Lugar { get; set; }
        public string Localizacion { get; set; }
        public string Hora { get; set; }

    }
}
