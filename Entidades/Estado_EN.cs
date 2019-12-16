using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Entidades
{
    public class Estado_EN
    {

        public int id { get; set; }
        public string fecha { get; set; }
        public decimal temperatura { get; set; }
        public decimal turbiedad { get; set; }
        public decimal lluvia { get; set; }
        public int estanque { get; set; }


    }
}
