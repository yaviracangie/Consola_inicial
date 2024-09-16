using System;
using System.Collections.Generic;

namespace ArbolesTarea2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".....Tarea2Arboles....!");

            Nodo raiz = new Nodo()
            {
                Valor = "/",
                Hijos =
                {
                    new Nodo
                    {
                        Valor = "+",
                        Hijos =
                        {

                           new Nodo
                           {
                            Valor = "5"
                           },
                           new Nodo
                           {
                            Valor = "4"
                           }
                        }

                    },

                           new Nodo
                           {
                               Valor = "-",
                               Hijos =
                               {
                                   new Nodo
                                   {
                                       Valor = "6"
                                   },
                                   new Nodo
                                   {
                                       Valor = "8"
                                   }
                               }
                           },

                            new Nodo
                           {
                               Valor = "*",
                               Hijos =
                               {
                                   new Nodo
                                   {
                                       Valor = "9"
                                   },
                                   new Nodo
                                   {
                                       Valor = "2"
                                   }
                               }
                           },

                }

            };

            //Resultado Esperado
            //(5 + 4) * (6 - 8) 

            ManejadorArbol manejadorArbol = new ManejadorArbol();
            Console.WriteLine(manejadorArbol.ImprimirArbol(raiz));

            Console.WriteLine($"El valor de hojas es: {manejadorArbol.NumeroHojas(raiz)}");

            Console.WriteLine($"El valor nodos es:{manejadorArbol.NumeroNodos(raiz)}");

            Console.WriteLine($"El valor de niveles es {manejadorArbol.NumeroNiveles(raiz)}");
        }

    }
}