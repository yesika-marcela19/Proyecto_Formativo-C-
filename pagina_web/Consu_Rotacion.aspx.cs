using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Acceso_Datos;
using Entidades;

namespace pagina_web
{
    public partial class Consu_Rotacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_rotacion();
            }
        }
        public void listar_rotacion()
        {
            Actividad_AD acti_ad = new Actividad_AD();
            tabla_rotacion.DataSource = acti_ad.Listado_Rotacion();
            tabla_rotacion.DataBind();
        }

        protected void tabla_rotacion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tabla_rotacion.PageIndex = e.NewPageIndex;
            listar_rotacion();
        }
    }
}