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
    public partial class Consu_Inactivo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_inactivo();
            }
        }
        public void listar_inactivo()
        {
            Persona_AD pers_ad = new Persona_AD();
            tabla_inactivo.DataSource = pers_ad.Listado_Inactivo();
            tabla_inactivo.DataBind();
        }

        protected void tabla_inactivo_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = tabla_inactivo.Rows[fila];
            string dato = row.Cells[1].Text;

            Persona_EN pers_en = new Persona_EN();
            pers_en.Id_persona = int.Parse(row.Cells[1].Text);
            Persona_AD pers_ad = new Persona_AD();

            int dt = pers_ad.Habilitar_Persona(pers_en);


            if (dt > 0)
            {
                listar_inactivo();
                Response.Write("<script>alert('Se habilito con exito ' );</script>");
            }
            else
            {
                Response.Write("<script>alert('No se habilito' );</script>");
            }
        }
    }
}