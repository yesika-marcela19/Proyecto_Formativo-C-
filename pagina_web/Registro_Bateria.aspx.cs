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
    public partial class Registro_Bateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_bateria();           
            }
        }

        public void listar_bateria()
        {
            Bateria_AD bate_ad = new Bateria_AD();
            tabla_bateria.DataSource = bate_ad.Listado_bateria();
            tabla_bateria.DataBind();
        }
        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            { 
               Bateria_EN bateria_en = new Bateria_EN();
               bateria_en.Nombre = bateria.Text;
               Bateria_AD bateria_ad = new Bateria_AD();
               int respuesta = bateria_ad.Registra_bateria(bateria_en);
                if (respuesta >0 )
                {
                    Response.Write("<script>alert('Registro de bateria' );</script>");
                }
                else
                {
                    Response.Write("<script>alert('No registro de bateria' );</script>");
                }
            }
            catch (Exception exc)
            {
                Response.Write("<script>alert('Ojo en el sistema' );</script>");
            }
        }
    }
}