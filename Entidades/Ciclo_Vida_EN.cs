using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Entidades
{
    public class Ciclo_Vida_EN
    {
        public int id_ciclo_vida { get; set; }
        public int semana { get; set; }
        public float consumo_diario { get; set; }
        public float consumo_semanal { get; set; }
        public float biomasa { get; set; }
        public float peso_min { get; set; }
        public float peso_max { get; set; }
        public int tipo_especie { get; set; }
        public int tipo_alimentacion { get; set; }
    }
}
