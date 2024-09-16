﻿using System;
using System.Collections.Generic;

namespace ArbolesTarea2
{
    public class Nodo
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public Nodo Izquierdo { get; set; }
        public Nodo Derecho { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
    }
}

