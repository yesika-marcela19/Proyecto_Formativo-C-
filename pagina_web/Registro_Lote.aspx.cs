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
    public partial class lotes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listar_lote();
                Estanques_vacios_de_lote();
               Listar_Especie();               
            }
        }
        public void listar_lote()
        {
            Lote_AD lote_ad = new Lote_AD();
            tabla_lote.DataSource = lote_ad.Listado_registro();
            tabla_lote.DataBind();
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Lote_EN lote_en = new Lote_EN();
            lote_en.cantidad = int.Parse(cantidad.Text);
            lote_en.fecha_ingreso = ingreso.Text;
            lote_en.fecha_salida = salida.Text;
            lote_en.fk_tipo_especie = int.Parse(Lista_Especie.Text);
            lote_en.fk_estanque = int.Parse(Lista_Lago.Text);
            lote_en.estado_lote = true;

            Lote_AD lote_ad = new Lote_AD();
            int repuesta = lote_ad.Registra_Lote(lote_en);

            if (repuesta > 0 )
            {
                Response.Write("<script>alert('Se registro  Lote' );</script>");
            }
            else
            {
                Response.Write("<script>alert(' No se registro Lote' );</script>");
            }
        }

        public void Estanques_vacios_de_lote()
        {
            Estanque_AD estanque = new Estanque_AD();
            Lista_Lago.DataSource = estanque.Estanques_vacios_de_lote();
            Lista_Lago.DataTextField = "id_estanque";
            Lista_Lago.DataValueField = "id_estanque";

            Lista_Lago.DataBind();
        }

        public void Listar_Especie()
        {
            Especie_AD especie = new Especie_AD();
            Lista_Especie.DataSource = especie.Listado_Especie();
            Lista_Especie.DataTextField = "nombre_especie";
            Lista_Especie.DataValueField = "id_tipo_especie";

            Lista_Especie.DataBind();
        } 

        protected void tabla_lote_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int fila = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = tabla_lote.Rows[fila];
                string dato = row.Cells[1].Text;

                Lote_EN lote_en = new Lote_EN();
                lote_en.id_lote= int.Parse(row.Cells[1].Text);

                Lote_AD lote_ad = new Lote_AD();

                DataTable dt = new DataTable();
                dt = lote_ad.Buscar_Lote(lote_en);

                if (dt.Rows.Count > 0)
                {
                    DataRow vs = dt.Rows[0];

                    id_lote.Text = Convert.ToString(vs["id_lote"]);
                    cantidad.Text = Convert.ToString(vs["cantidad"]);
                    
                    ingreso.Text =Convert.ToDateTime(vs["fecha_ingreso"]).ToString("yyyy/MM/dd");
                    salida.Text =  Convert.ToDateTime(vs["fecha_salida"]).ToString("yyyy/MM/dd");
                  //Lista_Lago.Text = Convert.ToString(vs["fk_estanque"]); No se busca por que el select solo muestra 
                 //estanque que esta estado_estanque=1 pero con lote en estado=0
                    Lista_Especie.Text = Convert.ToString(vs["fk_tipo_especie"]);
                }
                else
                {
                    Response.Write("<script>alert('No se encontro el lote' );</script>");
                }

            }
            catch (Exception exc)
            {
                Response.Write("<script>alert(' Error en el sistema' );</script>");
            }
        }

        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Lote_EN lote_en = new Lote_EN();
                lote_en.id_lote = int.Parse(id_lote.Text);
                lote_en.cantidad = int.Parse(cantidad.Text);
                lote_en.fecha_ingreso= ingreso.Text;
                lote_en.fecha_salida = salida.Text;
                //lote_en.fk_estanque = int.Parse(Lista_Lago.Text); 
                lote_en.fk_tipo_especie = int.Parse(Lista_Especie.Text);
                
                Lote_AD lote_ad = new Lote_AD();
                int resp = lote_ad.Actualizar(lote_en);

                if (resp > 0)
                {
                    listar_lote();
                    Response.Write("<script>alert('Actualizo con exito' );</script>");
                }
                else
                {
                    Response.Write("<script>alert('No actualizo' );</script>");
                }
            }
            catch (Exception exc)
            {
                Response.Write("<script>alert('Ojo erro en el sistema:');</script>");
            }
        }

        protected void tabla_lote_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int fila = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = tabla_lote.Rows[fila];
                string dato = row.Cells[1].Text;

                Lote_EN lote_en = new Lote_EN();
                lote_en.id_lote = int.Parse(row.Cells[1].Text);

                Lote_AD lote_ad = new Lote_AD();

                DataTable dt = new DataTable();
                dt = lote_ad.Buscar_Lote(lote_en);

                if (dt.Rows.Count > 0)
                {
                    DataRow vs = dt.Rows[0];

                    id_lote.Text = Convert.ToString(vs["id_lote"]);
                    cantidad.Text = Convert.ToString(vs["cantidad"]);

                    ingreso.Text = Convert.ToDateTime(vs["fecha_ingreso"]).ToString("yyyy/MM/dd");
                    salida.Text = Convert.ToDateTime(vs["fecha_salida"]).ToString("yyyy/MM/dd");
                    //Lista_Lago.Text = Convert.ToString(vs["fk_estanque"]); No se busca por que el select solo muestra 
                    //estanque que esta estado_estanque=1 pero con lote en estado=0
                    Lista_Especie.Text = Convert.ToString(vs["fk_tipo_especie"]);
                }
                else
                {
                    Response.Write("<script>alert('No se encontro el lote' );</script>");
                }

            }
            catch (Exception exc)
            {
                Response.Write("<script>alert(' Error en el sistema' );</script>");
            }
        }
    }
}