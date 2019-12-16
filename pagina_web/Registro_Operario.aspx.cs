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
    public partial class Registro_Operario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_operario();
            }
        }
        public void listar_operario()
        {
            Persona_AD pers_ad = new Persona_AD();
            tabla_usuario.DataSource = pers_ad.Listado_Operario();
            tabla_usuario.DataBind();
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Persona_EN pers_en = new Persona_EN();

            pers_en.Id_persona = int.Parse(id_persona.Text);
            pers_en.Nombre = nombre.Text;
            pers_en.Telefono = telefono.Text;
            pers_en.Rol =2;
            pers_en.Login = usuario.Text;
            pers_en.Password = contrasena.Text;
            pers_en.Estado_persona = true;

            Persona_AD pers_ad = new Persona_AD();
            int respuesta = pers_ad.Registra_Persona(pers_en);

            if (respuesta > 0)
            {
                Response.Write("<script>alert('Se registro operario' );</script>");
            }
            else
            {
                Response.Write("<script>alert(' No se registro operario' );</script>");
            }
        }

        protected void tabla_usuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = tabla_usuario.Rows[fila];
            string dato = row.Cells[1].Text;

            Persona_EN pers_en = new Persona_EN();
            pers_en.Id_persona = int.Parse(row.Cells[1].Text);

            Persona_AD pers_ad = new Persona_AD();

            DataTable dt = new DataTable();
            dt = pers_ad.Buscar_persona_Id(pers_en);

            if (dt.Rows.Count > 0)
            {
                DataRow vs = dt.Rows[0];

                id_persona.Text = Convert.ToString(vs["id_persona"]);
                nombre.Text = Convert.ToString(vs["nombre"]);
                telefono.Text = Convert.ToString(vs["telefono"]);
                usuario.Text = Convert.ToString(vs["login"]);
            }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {

                Persona_EN pers_en = new Persona_EN();

                pers_en.Id_persona = int.Parse(id_persona.Text);
                pers_en.Nombre = nombre.Text;
                pers_en.Telefono = telefono.Text;
                pers_en.Login = usuario.Text;

                Persona_AD pers_ad = new Persona_AD();
                int resp = pers_ad.Actualizar_Persona(pers_en);

                if (resp > 0)
                {
                    listar_operario();
                    Response.Write("<script>alert(' Actualizo con exito' );</script>");
                }
                else
                {

                    Response.Write("<script>alert(' No actualizo' );</script>");
                }

            }
            catch (Exception exc)
            {
                Response.Write("<script>alert(' Ojo erro en el sistema : ');</script>");

            }
        }
    }
}