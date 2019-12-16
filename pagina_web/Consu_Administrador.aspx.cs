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
    public partial class Consu_Administrador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_administrador();
            }
        }
        public void listar_administrador()
        {
            Persona_AD pers_ad = new Persona_AD();
            tabla_administrador.DataSource = pers_ad.Listado_Adminstrador();
            tabla_administrador.DataBind();
        }

        protected void tabla_administrador_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = tabla_administrador.Rows[fila];
            string dato = row.Cells[1].Text;

            Persona_EN pers_en = new Persona_EN();
            pers_en.Id_persona = int.Parse(row.Cells[1].Text);
            Persona_AD pers_ad = new Persona_AD();

            int dt = pers_ad.Deshabilitar_Persona(pers_en);


            if (dt > 0)
            {
                listar_administrador();
                Response.Write("<script>alert('Se deshabilito con exito ' );</script>");
            }
            else
            {
                Response.Write("<script>alert('No se deshabilito' );</script>");
            }
        }

        protected void tabla_administrador_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            tabla_administrador.PageIndex = e.NewPageIndex;
            listar_administrador();
        }
    }
}