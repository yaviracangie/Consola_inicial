using System;
using System.Collections.Generic;
using static Tarea1Consola.Usuario;

namespace Tarea1Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio del video juego del Torneo de las artes marciales de Bragon ball z
            string Nombre, Apodo, Edad, Contraseña, Genero;

            Console.WriteLine("-----------------BIENVENIDOS AL TORNEO DE LAS ARTES MARCIALES----------------- ");
            Console.WriteLine("----¿Deseas participar?-----");
            Console.WriteLine("SI = 1\nNO = 0");
            int star = int.Parse(Console.ReadLine());
            if (star == 1)

                //Registro de Usuario
                Console.WriteLine("---------Procede a registrate---------- :");
           
            Console.WriteLine("-------Ingresa tu nombre de usuario:----------");
            Nombre = Console.ReadLine();

            Console.WriteLine("----------Escribe un apodo con el que quieras participar:----------");
            Apodo = Console.ReadLine();

            Console.WriteLine("--------------Escribe tu Edad:-------------");
            Edad = Console.ReadLine();

            Console.WriteLine("-----------Ingresa una contraseña:---------");
            Contraseña = Console.ReadLine();

            Console.WriteLine("-----------Escribe si eres M/F:---------");
            Genero = Console.ReadLine();
            if (Genero == "M" | Genero == "F" | Genero == "m" | Genero == "f")
            {
                Console.WriteLine("Ingresa si eres Competidor o Enemigo: ---------:");
            }
            else {
                Console.Clear();
                Console.WriteLine("Ingresaste un dato incorrecto!!");
            }
            Nombre = Console.ReadLine();
            if (Nombre == "Competidor" | Nombre == "Enemigo")
            
            {
                Console.WriteLine("---------Bienvenido al enfrentamiento");
            }
            if (args.Length > 0)
                {
                    for (var i = 0; i < args.Length; i++)
                    {
                        Console.WriteLine(args[i]);
                    }
                }
           

            var Goku= new Competidor();
                    var Frezeer = new Enemigo();
                    var Kamehamehaa = new Tecnicas();
                    var  TorneoMundial= new Torneo();

            Console.WriteLine("Ingrese el nombre  del Torneo al que quiere Consursar  ");
            TorneoMundial.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del Competidor Con el que desea participar en el Torneo ");
            Goku.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del Enemigo  ");
            Frezeer.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese La tecnica con la que quiere atacar a su oponente");
            Kamehamehaa.Gentidama = Console.ReadLine();

            Console.WriteLine("Felicidades has GANADOOOO  ");

            Console.Write("\n Digite cualquier tecla para terminar");
            Console.ReadKey();
        }
    }
}
