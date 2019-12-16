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
    public partial class Consu_Alimentacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_alimentacion();
            }
        }
        public void listar_alimentacion()
        {
            Actividad_AD acti_ad = new Actividad_AD();
            tabla_alimentacion.DataSource = acti_ad.Listado_Alimentacion();
            tabla_alimentacion.DataBind();
        }

        protected void tabla_alimentacion_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tabla_alimentacion.PageIndex = e.NewPageIndex;
            listar_alimentacion();
        }
    }
}