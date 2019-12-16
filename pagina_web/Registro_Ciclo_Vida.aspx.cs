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
    public partial class Ciclo_vida : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Listar_Especie();
                Listar_Alimentacion();
                listar_ciclo_vida();
            }
        }

        public void Listar_Especie()
        {
            Especie_AD especie = new Especie_AD();
            Lista_Especie.DataSource = especie.Listado_Especie();
            Lista_Especie.DataTextField = "nombre_especie";
            Lista_Especie.DataValueField = "id_tipo_especie";

            Lista_Especie.DataBind();
        }

        public void Listar_Alimentacion()
        {
            Tipo_Alimentacion_AD estanque = new Tipo_Alimentacion_AD();
            Lista_Alimentacion.DataSource = estanque.Listado_Alimentacion();
            Lista_Alimentacion.DataTextField = "nombre_alimentacion";
            Lista_Alimentacion.DataValueField = "id_tipo_alimentacion";

            Lista_Alimentacion.DataBind();
        }
        public void listar_ciclo_vida()
        {
            Ciclo_Vida_AD ciclo_ad = new Ciclo_Vida_AD();
            tabla_ciclo.DataSource = ciclo_ad.Listado_Ciclo_Vida();
            tabla_ciclo.DataBind();
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            Ciclo_Vida_EN ciclo_en = new Ciclo_Vida_EN();
            ciclo_en.semana = int.Parse(semana.Text);
            ciclo_en.consumo_diario = float.Parse(diario.Text);
            ciclo_en.consumo_semanal = float.Parse(semanal.Text);
            ciclo_en.biomasa = float.Parse(biomasa.Text);
            ciclo_en.peso_min = float.Parse(minimo.Text);
            ciclo_en.peso_max = float.Parse(maximo.Text);
            ciclo_en.tipo_especie= int.Parse(Lista_Especie.Text);
            ciclo_en.tipo_alimentacion = int.Parse(Lista_Alimentacion.Text);


            Ciclo_Vida_AD ciclo_ad = new Ciclo_Vida_AD();
            int respuesta = ciclo_ad.Registra_Ciclo_Vida(ciclo_en);
            

            if (respuesta > 0 )
            {
                listar_ciclo_vida();
                Response.Write("<script>alert('Se registro con exito' );</script>");
            }
            else
            {
                Response.Write("<script>alert(' No se registro' );</script>");
            }
        }



        protected void tabla_ciclo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int fila = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = tabla_ciclo.Rows[fila];
            string dato = row.Cells[1].Text;

            Ciclo_Vida_EN ciclo_en = new Ciclo_Vida_EN();
            ciclo_en.id_ciclo_vida = int.Parse(row.Cells[1].Text);

            Ciclo_Vida_AD ciclo_ad = new Ciclo_Vida_AD();

            DataTable dt = new DataTable();
            dt = ciclo_ad.Buscar_Ciclo_Vida(ciclo_en);

            if (dt.Rows.Count > 0)
            {
                DataRow vs = dt.Rows[0];

                id_ciclo_vida.Text = Convert.ToString(vs["id_ciclo_vida"]);
                semana.Text = Convert.ToString(vs["semana"]);
                diario.Text = Convert.ToString(vs["consumo_diario"]);
                semanal.Text = Convert.ToString(vs["consumo_semanal"]);
                biomasa.Text = Convert.ToString(vs["biomasa"]);
                minimo.Text = Convert.ToString(vs["peso_min"]);
                maximo.Text = Convert.ToString(vs["peso_max"]);
                Lista_Especie.Text = Convert.ToString(vs["fk_tipo_especie"]);
                Lista_Alimentacion.Text = Convert.ToString(vs["fk_tipo_alimentacion"]);
            }
        }

        protected void btn_actualizar_Click1(object sender, EventArgs e)
        {
            Ciclo_Vida_EN ciclo_en = new Ciclo_Vida_EN();
            ciclo_en.id_ciclo_vida = int.Parse(id_ciclo_vida.Text);
            ciclo_en.semana = int.Parse(semana.Text);
            ciclo_en.consumo_diario = float.Parse(diario.Text);
            ciclo_en.consumo_semanal = float.Parse(semanal.Text);
            ciclo_en.biomasa = float.Parse(biomasa.Text);
            ciclo_en.peso_min = float.Parse(minimo.Text);
            ciclo_en.peso_max = float.Parse(maximo.Text);
            ciclo_en.tipo_especie = int.Parse(Lista_Especie.Text);
            ciclo_en.tipo_alimentacion = int.Parse(Lista_Alimentacion.Text);


            Ciclo_Vida_AD ciclo_ad = new Ciclo_Vida_AD();
            int respuesta = ciclo_ad.Actualizar_Ciclo_Vida(ciclo_en);


            if (respuesta > 0)
            {
                listar_ciclo_vida();
                Response.Write("<script>alert('Actualizo con exito' );</script>");
            }
            else
            {
                Response.Write("<script>alert(' No actualizo' );</script>");
            }
        }
    }
}