
namespace Tarea1Consola
{
    public class Usuario
    {
        public string Nombre { get; set; } //Propiedades
        public string Apodo { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Codigo { get; set; }                  
        public int Edad { get; set; }     
        public string Contraseña { get; set; }
        public string Email { get; set; }
        public string FechaNacimiento { get; set; }
        public string mensajeBienvenida()
        {

            return $"Bienvenido {Nombre}\nTu Apodo con el que consursaras es {Apodo}\nTu genero es {Genero}";
        }

        public string dataUsuario()
        {
            return $"Nombre del Usuario:{Nombre}\nApodo:{Apodo}\nEstadoAnimo:{Genero}\nDireccion:{Direccion}\nTelefono:{Telefono}\nCodigo:{Codigo}\nEdad{Edad}\nFehaNacimiento:{FechaNacimiento}";
        }
    }
}
