using System;
using System.Linq;

namespace ArbolesTarea2
{
    public class ManejadorArbol
    {

        private int nivelActual;

        //Metodo Recursivo
        public string ImprimirArbol(Nodo nodo)
        {
            //Analiza el comportaminiento de una Hoja
            if (!nodo.Hijos.Any())
                return nodo.Valor;
            //Analizo cuando no soy hoja  { ImprimirArbol(nodo.Hijo[1])} )"; //Funsion 
            return $"({ ImprimirArbol(nodo.Hijos[0])} {nodo.Valor}{ ImprimirArbol(nodo.Hijos[1])})";

        }

        internal int NumeroHojas(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalHojas = 0;
            foreach (var hijoActual in nodo.Hijos)
            {
                totalHojas += NumeroHojas(hijoActual);
            }

            return totalHojas;

            //var hojasHijo1 = NumeroHojas(nodo.Hijos[0]); 
            //var hojasHijo2 = NumeroHojas(nodo.Hijos[1]);
            //var hojasHijo3 = NumeroHojas(nodo.Hijos[2]);
            //var hojasHijo4 = NumeroHojas(nodo.Hijos[3]);
            //var hojasHijoFinal = NumeroHojas(nodo.Hijos[nodo.Hijos.Count - 1]); //n => lengt/count, cantidad de elementos totales

            //return hojasHijo1 + hojasHijo2 + hojasHijo3 + hojasHijo4 + hojasHijoFinal;

        }

        private static bool SoyHoja(Nodo nodo)
        {
            return !nodo.Hijos.Any();
        }

        internal int NumeroNodos(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 1;

            int totalNodos = 0;
            foreach (var nodoActual in nodo.Hijos)
            {
                totalNodos += NumeroNodos(nodoActual);
            }

            return totalNodos + 1;
        }

        internal int NumeroNiveles(Nodo nodo)
        {
            if (SoyHoja(nodo))
                return 0;

            int totalNiveles = 0;
            foreach (var Nodo in nodo.Hijos)
            {
                totalNiveles = NumeroNiveles(Nodo);
            }

            return totalNiveles + 2;
        }
    }
}

