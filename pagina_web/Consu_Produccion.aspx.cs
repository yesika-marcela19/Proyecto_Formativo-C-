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
    public partial class Consu_Produccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_produccion();
            }
        }
        public void listar_produccion()
        {
            Actividad_AD acti_ad = new Actividad_AD();
            tabla_Produccion.DataSource = acti_ad.Listado_Produccion();
            tabla_Produccion.DataBind();
        }

        protected void tabla_Produccion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tabla_Produccion.PageIndex = e.NewPageIndex;
            listar_produccion();
        }
    }
}