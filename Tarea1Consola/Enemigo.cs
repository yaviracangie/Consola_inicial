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
        public string Carsimas { get; set; }
        public string Edad { get; set; }
        public string Habilidades { get; set; }
        public string Fusiones { get; set; }
        public string Poder { get; set; }
        public string Transformaciones { get; set; }
    }
}
