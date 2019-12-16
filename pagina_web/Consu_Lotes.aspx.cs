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
    public partial class Consu_Lotes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_lotes();
            }
        }
        public void listar_lotes()
        {
            Lote_AD lote_ad = new Lote_AD();
            tabla_lotes.DataSource = lote_ad.Listado_Lote_Activo();
            tabla_lotes.DataBind();
        }
    }
}