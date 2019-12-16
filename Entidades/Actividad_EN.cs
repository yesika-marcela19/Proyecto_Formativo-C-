using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Entidades
{
    public class Actividad_EN
    {
        public int Id_actividad { get; set; }
        public int foto { get; set; }
        public int cantidad { get; set; }
        public string descripcion { get; set; }
        public string fecha { get; set; }

        public int fk_estanque { get; set; }
        public int fk_persona { get; set; }
        public int fk_tipo_actividad { get; set; }
        public int lote { get; set; }
        public int lote2 { get; set; }

        public String tipo { get; set; }
    }
}
