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
    public partial class Registrar_Estanque : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar_Bateria();
                listar_estanque();
            }
        }
        public void Listar_Bateria()
        {
            Bateria_AD bate = new Bateria_AD();
            bateria.DataSource = bate.Listado_bateria_registro_lote();
            bateria.DataTextField = "nombre_bateria";
            bateria.DataValueField = "id_bateria";

            bateria.DataBind();
        }
        public void listar_estanque()
        {
            Estanque_AD estanque_ad = new Estanque_AD();
            tabla_estanque.DataSource = estanque_ad.Listado();
            tabla_estanque.DataBind();
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Estanque_EN esta_en = new Estanque_EN();
            esta_en.latitud = int.Parse(latitud.Text);
            esta_en.longitud = int.Parse(longitud.Text);
            esta_en.area = int.Parse(area.Text);
            esta_en.capacidad = int.Parse(capacidad.Text);
            esta_en.fk_bateria = int.Parse(bateria.Text);
            esta_en.tipo_estanque = tipo_estanque.Text;
            esta_en.estado_estanque = true;

            Estanque_AD esta_ad = new Estanque_AD();
           
            int respuesta = esta_ad.Registra_Estanque(esta_en);
            
            if (respuesta > 0 )
            {
                Response.Write("<script>alert('Se registro Estanque' );</script>");
            }
            else
            {
                Response.Write("<script>alert(' No se registro Estanque' );</script>");
            }
        }

        protected void tabla_estanque_RowCommand(object sender, GridViewCommandEventArgs e)
        {
         try
           {
              int fila = Convert.ToInt32(e.CommandArgument);
              GridViewRow row = tabla_estanque.Rows[fila];
              string dato = row.Cells[1].Text;

              Estanque_EN estanque_en = new Estanque_EN();
              estanque_en.Id_estanque = int.Parse(row.Cells[1].Text);

              Estanque_AD estanque_ad = new Estanque_AD();

              DataTable dt = new DataTable();
              dt = estanque_ad.Buscar_Estanque(estanque_en);

              if (dt.Rows.Count > 0)
              {
                DataRow vs = dt.Rows[0];

                id_estanque.Text = Convert.ToString(vs["id_estanque"]);
                latitud.Text = Convert.ToString(vs["latitud"]);
                longitud.Text = Convert.ToString(vs["longitud"]);
                area.Text = Convert.ToString(vs["area"]);
                capacidad.Text = Convert.ToString(vs["capacidad"]);
                bateria.Text = Convert.ToString(vs["fk_bateria"]);
                tipo_estanque.Text = Convert.ToString(vs["tipo_estanque"]);
              }
              else
              {
                Response.Write("<script>alert(' No se encontro estanque' );</script>");
              }

           }
           catch (Exception exc)
           {
              Response.Write("<script>alert(' Ojo erro en el sistema : ');</script>");
           }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Estanque_EN estanque_en = new Estanque_EN();
                estanque_en.Id_estanque = int.Parse(id_estanque.Text);
                estanque_en.latitud = int.Parse(latitud.Text);
                estanque_en.longitud = int.Parse(longitud.Text);
                estanque_en.area = int.Parse(area.Text);
                estanque_en.capacidad = int.Parse(capacidad.Text);
                estanque_en.fk_bateria = int.Parse(bateria.Text);
                estanque_en.tipo_estanque = tipo_estanque.Text;

                Estanque_AD estanque_ad = new Estanque_AD();
                int resp = estanque_ad.Actualizar_Estanque(estanque_en);

                if (resp > 0)
                {
                    listar_estanque();
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