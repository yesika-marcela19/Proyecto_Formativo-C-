using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Entidades
{
    public class Estanque_EN
    {
        public int Id_estanque { get; set; }
        public int latitud { get; set; }
        public int longitud { get; set; }
        public int area { get; set; }

        public int capacidad { get; set; }
        public int fk_bateria { get; set; }
        public string tipo_estanque { get; set; }
        public bool estado_estanque { get; set; }
    }
}