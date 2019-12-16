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
    public partial class Consu_Pesca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_pesca();
            }
        }
        public void listar_pesca()
        {
            Actividad_AD acti_ad = new Actividad_AD();
            tabla_Pesca.DataSource = acti_ad.Listado_Pesca();
            tabla_Pesca.DataBind();
        }

        protected void tabla_Pesca_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tabla_Pesca.PageIndex = e.NewPageIndex;
            listar_pesca();
        }
    }
}