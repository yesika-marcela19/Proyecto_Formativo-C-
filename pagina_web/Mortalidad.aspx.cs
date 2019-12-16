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
    public partial class Mortalidad : System.Web.UI.Page
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
        public void listar_mortalidad()
        {
            Actividad_AD acti_ad = new Actividad_AD();
          int lt=  int.Parse(Lista_Lote.SelectedValue.ToString());
            tabla_mortalidad.DataSource = acti_ad.Listado_Mortalidad_Lote(lt);
            tabla_mortalidad.DataBind();
        }

        protected void Lista_Lago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lote_AD lote = new Lote_AD();

            int id = int.Parse(Lista_Lago.SelectedValue.ToString());
            Lista_Lote.DataSource = lote.Listado_Activos(id);
            Lista_Lote.DataTextField = "id_lote";
            Lista_Lote.DataValueField = "id_lote";

            Lista_Lote.DataBind();

            try{

                listar_mortalidad();

            } catch { }
           


        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Actividad_EN act_en = new Actividad_EN();
            Lote_EN lote_en = new Lote_EN();
            act_en.fk_estanque = int.Parse(Lista_Lago.SelectedValue.ToString());
            act_en.fecha = txt_fecha.Text;
            act_en.fk_tipo_actividad = 3;
            act_en.cantidad = int.Parse(txt_cantidad.Text);
            lote_en.cantidad = int.Parse(txt_cantidad.Text);
            lote_en.id_lote= int.Parse(Lista_Lote.SelectedValue.ToString());
            act_en.descripcion = text_descripcion.Text;
            act_en.fk_persona = int.Parse(Session["identificacion"].ToString());
            act_en.lote = int.Parse(Lista_Lote.SelectedValue.ToString());

            Actividad_AD act_ad = new Actividad_AD();
            Lote_AD lote_ad = new Lote_AD();
            int respuesta = act_ad.Registra_Actividad(act_en);
            int repuesta1 = lote_ad.Actualizar_Cantidad(lote_en);

            if (respuesta > 0 && repuesta1 > 0)
            {
                Response.Write("<script>alert('Se registro  Mortalidad' );</script>");
            }
            else
            {
                Response.Write("<script>alert(' No se registro Mortalidad' );</script>");
            }
        }

        protected void Lista_Lote_SelectedIndexChanged(object sender, EventArgs e)
        {


            
        }

        protected void tabla_mortalidad_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tabla_mortalidad.PageIndex = e.NewPageIndex;
            listar_mortalidad();
        }
    }
}