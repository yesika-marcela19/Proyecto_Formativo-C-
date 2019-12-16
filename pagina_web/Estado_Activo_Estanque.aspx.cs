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
    public partial class Estado_Estanque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_estanque();
            }
        }
        public void listar_estanque()
        {
            Estanque_AD acti_ad = new Estanque_AD();
            tabla_estanques.DataSource = acti_ad.Listado();
            tabla_estanques.DataBind();
        }

        protected void tabla_estanques_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = tabla_estanques.Rows[fila];
            string dato = row.Cells[1].Text;

            Estanque_EN estanque_en = new Estanque_EN();
            estanque_en.Id_estanque = int.Parse(row.Cells[1].Text);
            Estanque_AD estanque_ad = new Estanque_AD();

            int dt = estanque_ad.Deshabilitar(estanque_en);


            if (dt > 0)
            {
                listar_estanque();
                Response.Write("<script>alert('Se deshabilito con exito ' );</script>");
            }
            else
            {
                Response.Write("<script>alert('No se deshabilito' );</script>");
            }
        }
    }
}