using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Acceso_Datos;
using Entidades;
using System.Data;

namespace pagina_web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ingresar_Click(object sender, EventArgs e)
        {
            Persona_EN pers_EN = new Persona_EN();
            pers_EN.Login = TextBox1.Text;
            pers_EN.Password = TextBox2.Text;

            Persona_AD pers_ad = new Persona_AD();
            DataTable d = new DataTable();
            d = pers_ad.Validar_Persona(pers_EN);

            if (d.Rows.Count > 0)
            {
                DataRow row = d.Rows[0];
                Session["usuario"] = Convert.ToString(row["nombre"]);
                Session["identificacion"] = Convert.ToString(row["id_persona"]);
                Response.Redirect("~/Principal.aspx");
            }
            else
            {
                Response.Write("<script>alert('Usuario no autorizado');</script>");
            }
        }
    }
}