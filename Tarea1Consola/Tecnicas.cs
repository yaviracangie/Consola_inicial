

namespace Tarea1Consola
{
    public class Tecnicas
    {
        public string  Kamekamehaaaa { get; set; }
        public string Gentidama{ get; set; }
        public string AtaqueSaiyan { get; set; }
        public string Habilidades { get; set; }
        public string GolpeDragon { get; set; }
        public string AtaqueBigBang { get; set; }
        public string BolaEncarcelamiento { get; set; }
        public string Masenco { get; set; }
        public string Siensay { get; set; }
        public string AtaqueMistico { get; set; }

        public string Ataques()
        {
            var Siensay =  10;
                Masenco= "costillas";
                Habilidades = "GolpeDargon";
            var reduccionEnergia =  Siensay -5;
            return $"Tengo {Habilidades}, Me ataco en las costillas con el actaque de:{Masenco}";

        }

        public string Habilidad(string Habilidades)
        {
            return $"Mi Habilidad mas fuertees de :{Habilidades} con una tecnica de:{BolaEncarcelamiento}";
        }

        
    }
}
