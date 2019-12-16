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
    public partial class Rotacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar_Estanque();
                Listar_Estanque2();
                listar_rotacion();

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

        
        public void Listar_Estanque2()
        {        
                Estanque_AD estanque = new Estanque_AD();
                Lista_Lago2.DataSource = estanque.Listado_Estanque();
                Lista_Lago2.DataTextField = "id_estanque";
                Lista_Lago2.DataValueField = "id_estanque";

                Lista_Lago2.DataBind();              
        }
        public void listar_rotacion()
        {
            Actividad_AD acti_ad = new Actividad_AD();
            tabla_rotacion.DataSource = acti_ad.Listado_Rotacion();
            tabla_rotacion.DataBind();
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
            Lote_EN lote_en = new Lote_EN();
            act_en.fk_estanque = int.Parse(Lista_Lago.SelectedValue.ToString());
            act_en.fecha = txt_fecha.Text;
            act_en.fk_tipo_actividad = 2;
            act_en.cantidad = int.Parse(txt_cantidad.Text);
            lote_en.cantidad = int.Parse(txt_cantidad.Text);
            lote_en.id_lote = int.Parse(Lista_Lote.SelectedValue.ToString());
            lote_en.id_lote2 = int.Parse(Lista_Lote2.SelectedValue.ToString());
            act_en.descripcion =text_descripcion.Text;
            act_en.fk_persona = int.Parse(Session["identificacion"].ToString());
            act_en.lote = int.Parse(Lista_Lote.SelectedValue.ToString());
            act_en.lote2 = int.Parse(Lista_Lote2.SelectedValue.ToString());

            Actividad_AD act_ad = new Actividad_AD();
            Lote_AD lote_ad = new Lote_AD();

            int respu1 = act_ad.Registra_Actividad(act_en);
            int repu2 = act_ad.Registra_Actividad2(act_en);
            int respu3 = lote_ad.Actualizar_Cantidad(lote_en);
            int respu4 = lote_ad.Actualizar_Cantidad_Rotacion(lote_en);

            if (respu1 > 0 && repu2 > 0 && respu3>0 && respu4 > 0)
            {
                Response.Write("<script>alert('Se registro  Rotación' );</script>");
            }
            else
            {
                Response.Write("<script>alert(' No se registro Rotación' );</script>");
            }
        }

        protected void Lista_Lago2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lote_AD lote = new Lote_AD();

            int id = int.Parse(Lista_Lago2.SelectedValue.ToString());
            Lista_Lote2.DataSource = lote.Listado_Activos(id);
            Lista_Lote2.DataTextField = "id_lote";
            Lista_Lote2.DataValueField = "id_lote";

            Lista_Lote2.DataBind();
        }
    }
}