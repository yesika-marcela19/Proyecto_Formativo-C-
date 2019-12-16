using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Entidades
{
    public class Lote_EN
    {
        public int id_lote { get; set; }
        public int id_lote2 { get; set; }
        public int cantidad { get; set; }
        public string fecha_ingreso { get; set; }
        public string fecha_salida { get; set; }

        public int fk_estanque { get; set; }
        public int fk_tipo_especie { get; set; }
        public bool estado_lote { get; set; }
    }
}
