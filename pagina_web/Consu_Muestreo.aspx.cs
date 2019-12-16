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
    public partial class Consu_Muestreo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_muestro();
            }
        }
        public void listar_muestro()
        {
            Actividad_AD acti_ad = new Actividad_AD();
            tabla_muestro.DataSource = acti_ad.Listado_Muestreo();
            tabla_muestro.DataBind();
        }

        protected void tabla_muestro_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tabla_muestro.PageIndex = e.NewPageIndex;
            listar_muestro();
        }
    }
}