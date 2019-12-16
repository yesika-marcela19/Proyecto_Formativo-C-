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
    public partial class Consu_Mortalidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_mortalidad();
            }
        }
        public void listar_mortalidad()
        {
            Actividad_AD acti_ad = new Actividad_AD();
            tabla_mortalidad.DataSource = acti_ad.Listado_Mortalidad();
            tabla_mortalidad.DataBind();
        }

        protected void tabla_mortalidad_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tabla_mortalidad.PageIndex = e.NewPageIndex;
            listar_mortalidad();
        }
    }
}