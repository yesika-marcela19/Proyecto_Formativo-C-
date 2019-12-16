using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Entidades
{
    public class Persona_EN
    {
        public int Id_persona { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Login { get; set; }

        public string Password { get; set; }
        public int Rol { get; set; }
        public bool Estado_persona { get; set; }
    }
}
