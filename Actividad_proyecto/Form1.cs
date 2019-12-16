using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alimentcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actividad_Alimentacion alimentacion = new Actividad_Alimentacion();
            alimentacion.Show();
        }

        private void mortalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actividad_mortalidad mortalidad = new Actividad_mortalidad();
            mortalidad.Show();
        }

        private void rotacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actividad_rotacion rotacion = new Actividad_rotacion();
            rotacion.Show();
        }

        private void pescaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actividad_pesca pesca = new Actividad_pesca();
            pesca.Show();
        }
    }
}
