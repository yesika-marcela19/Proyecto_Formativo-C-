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
    public partial class Muestreo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar_Estanque();
            }
        }
        public void Listar_Estanque()
        {
            Estanque_AD estanque = new Estanque_AD();
            Lista_Lago.DataSource = estanque.Listado_Estanque();
            Lista_Lago.DataTextField = "id_estanque";
            Lista_Lago.DataValueField = "id_estanque";

            Lista_Lago.DataBind();
        }
        protected void Lista_Lago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lote_AD lote = new Lote_AD();

            int id = int.Parse(Lista_Lago.SelectedValue.ToString());
            Lista_Lote.DataSource = lote.Listado_Activos(id);
            Lista_Lote.DataTextField = "id_lote";
            Lista_Lote.DataValueField = "id_lote";

            Lista_Lote.DataBind();
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Actividad_EN act_en = new Actividad_EN();

            act_en.cantidad = int.Parse(txt_cantidad.Text);
            act_en.descripcion = text_descripcion.Text;
            act_en.fecha = txt_fecha.Text;
            act_en.fk_estanque = int.Parse(Lista_Lago.SelectedValue.ToString());
            act_en.fk_persona = int.Parse(Session["identificacion"].ToString());
            act_en.fk_tipo_actividad = 1;
            act_en.lote = int.Parse(Lista_Lote.SelectedValue.ToString());

            Actividad_AD act_ad = new Actividad_AD();
            int respuesta = act_ad.Registra_Actividad(act_en);

            if (respuesta > 0)
            {
                Response.Write("<script>alert('Se registro muestro' );</script>");
            }
            else
            {
                Response.Write("<script>alert(' No se registro muestro' );</script>");
            }
        }
    }
}