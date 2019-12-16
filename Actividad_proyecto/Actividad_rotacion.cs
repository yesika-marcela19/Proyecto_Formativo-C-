using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Acceso_Datos;
using Entidades;

namespace Actividad_proyecto
{
    public partial class Actividad_rotacion : Form
    {
        public Actividad_rotacion()
        {
            InitializeComponent();          
            Listar_Estanques();
            Listar_Estanques2();
            Listar_persona();
            Listar_lote();
        }
        public void Listar_lote()
        {
            Lote_AD lote_ad = new Lote_AD();
            Tabla_Alimentacion.DataSource = lote_ad.Listado_Activos_Normal();
        }

        public void Listar_Estanques()
        {
            Estanque_AD est_ad = new Estanque_AD();
            Cbx_Estanque.DisplayMember = "id_estanque";
            Cbx_Estanque.ValueMember = "id_estanque";
            
            Cbx_Estanque.DataSource = est_ad.Listado_Estanque();
        }
        public void Listar_Estanques2()
        {
            Estanque_AD est_ad = new Estanque_AD();
            Cbx_Estanque2.DisplayMember = "id_estanque";
            Cbx_Estanque2.ValueMember = "id_estanque";

            Cbx_Estanque2.DataSource = est_ad.Listado_Estanque();
        }


        public void Listar_persona()
        {
            Conexion_AD con = new Conexion_AD();
            DataTable dt = new DataTable();
            string sql = "select *From piscicola.persona";
            dt = con.Ejecutar_Consuta(sql);

            Cxb_Persona.DisplayMember = "nombre";
            Cxb_Persona.ValueMember = "id_persona";
            Cxb_Persona.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Cbx_Lotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cbx_Estanque_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_estanque = int.Parse(Cbx_Estanque.SelectedValue.ToString());
             Listar_Lote(id_estanque);
        }

        private void Cbx_Estanque2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_estanque = int.Parse(Cbx_Estanque2.SelectedValue.ToString());
            Listar_Lote2(id_estanque);
        }
        public void Listar_Lote(int id_estanque)
        {
            Lote_AD lote = new Lote_AD();
            Cbx_Lotes.DisplayMember = "id_lote";
            Cbx_Lotes.ValueMember = "id_lote";
            Cbx_Lotes.DataSource = lote.Listado_Activos(id_estanque);
        }

        public void Listar_Lote2(int id_estanque)
        {
            Lote_AD lote = new Lote_AD();
            Cbx_Lotes2.DisplayMember = "id_lote";
            Cbx_Lotes2.ValueMember = "id_lote";
            Cbx_Lotes2.DataSource = lote.Listado_Activos(id_estanque);
        }
        private void Text_Listar_Click(object sender, EventArgs e)
        {
            Lote_AD lote_ad = new Lote_AD();
            Tabla_Alimentacion.DataSource = lote_ad.Listado_Activos_Normal();
        }

        private void Btn_Registrar_Alimentacion_Click(object sender, EventArgs e)
        {
            try
            {
                Actividad_AD acti_ad = new Actividad_AD();
                Actividad_EN acti_en = new Actividad_EN();
                Lote_AD lote_ad = new Lote_AD();
                Lote_EN lote_en = new Lote_EN();
                acti_en.cantidad = int.Parse(Text_Cantidad.Text);
                lote_en.cantidad = int.Parse(Text_Cantidad.Text);
                lote_en.id_lote = int.Parse(Cbx_Lotes.SelectedValue.ToString());
                lote_en.id_lote2 = int.Parse(Cbx_Lotes2.SelectedValue.ToString());

                acti_en.descripcion = Text_Descripcion.Text;
                acti_en.fecha = fecha.Value.ToString("yyyy/MM/dd");
                acti_en.lote = int.Parse(Cbx_Lotes.SelectedValue.ToString());
                acti_en.fk_estanque = int.Parse(Cbx_Estanque.SelectedValue.ToString());
                acti_en.fk_persona = int.Parse(Cxb_Persona.SelectedValue.ToString());
                acti_en.fk_tipo_actividad = 3;


                int resp = acti_ad.Registra_Actividad(acti_en);
                int respu = lote_ad.Actualizar_Cantidad(lote_en);
                int respue = lote_ad.Actualizar_Cantidad_Rotacion(lote_en);

                if (resp > 0 && respu > 0 && respue > 0)
                {
                    MessageBox.Show("Se registro actividad");

                }
                else
                {

                    MessageBox.Show("No se registro actividad");
                }

            }
            catch (Exception exc)
            {

                MessageBox.Show("Ojo erro en el sistema : " + exc.Message);
            }
        }

        private void Text_Listar_Click_1(object sender, EventArgs e)
        {
            Lote_AD lote_ad = new Lote_AD();
            Tabla_Alimentacion.DataSource = lote_ad.Listado_Activos_Normal();
        }
    }
}
