using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace pagina_web
{
    public partial class Plantilla : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                id_usuario.Text = Session["usuario"].ToString();
            }
            catch
            {
                Response.Redirect("~/index.aspx");
            }
            
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/index.aspx");
        }
    }
}