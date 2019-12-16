using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Acceso_Datos;
using Entidades;

namespace pagina_web
{
    public partial class Principal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<Actividad_EN> Mostrar_notificacion()
        {
            Actividad_AD act = new Actividad_AD();
            return act.Listar_mortalidad_fecha();
        }

    }
}