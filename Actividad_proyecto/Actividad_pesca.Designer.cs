namespace Actividad_proyecto
{
    partial class Actividad_pesca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cbx_Lotes = new System.Windows.Forms.ComboBox();
            this.Cxb_Persona = new System.Windows.Forms.ComboBox();
            this.Cbx_Estanque = new System.Windows.Forms.ComboBox();
            this.Text_Descripcion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tabla_Alimentacion = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.Text_Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Registrar_Alimentacion = new System.Windows.Forms.Button();
            this.Text_Listar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Alimentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // Cbx_Lotes
            // 
            this.Cbx_Lotes.FormattingEnabled = true;
            this.Cbx_Lotes.Location = new System.Drawing.Point(142, 130);
            this.Cbx_Lotes.Name = "Cbx_Lotes";
            this.Cbx_Lotes.Size = new System.Drawing.Size(200, 21);
            this.Cbx_Lotes.TabIndex = 63;
            // 
            // Cxb_Persona
            // 
            this.Cxb_Persona.FormattingEnabled = true;
            this.Cxb_Persona.Location = new System.Drawing.Point(142, 170);
            this.Cxb_Persona.Name = "Cxb_Persona";
            this.Cxb_Persona.Size = new System.Drawing.Size(200, 21);
            this.Cxb_Persona.TabIndex = 62;
            // 
            // Cbx_Estanque
            // 
            this.Cbx_Estanque.FormattingEnabled = true;
            this.Cbx_Estanque.Location = new System.Drawing.Point(142, 94);
            this.Cbx_Estanque.Name = "Cbx_Estanque";
            this.Cbx_Estanque.Size = new System.Drawing.Size(200, 21);
            this.Cbx_Estanque.TabIndex = 61;
            this.Cbx_Estanque.SelectedIndexChanged += new System.EventHandler(this.Cbx_Estanque_SelectedIndexChanged);
            // 
            // Text_Descripcion
            // 
            this.Text_Descripcion.Location = new System.Drawing.Point(142, 256);
            this.Text_Descripcion.Name = "Text_Descripcion";
            this.Text_Descripcion.Size = new System.Drawing.Size(200, 20);
            this.Text_Descripcion.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 58;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "Lotes activos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Estanques";
            // 
            // Tabla_Alimentacion
            // 
            this.Tabla_Alimentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Alimentacion.Location = new System.Drawing.Point(374, 81);
            this.Tabla_Alimentacion.Name = "Tabla_Alimentacion";
            this.Tabla_Alimentacion.Size = new System.Drawing.Size(437, 295);
            this.Tabla_Alimentacion.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "ACTIVIDAD";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(142, 211);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 51;
            // 
            // Text_Cantidad
            // 
            this.Text_Cantidad.Location = new System.Drawing.Point(142, 296);
            this.Text_Cantidad.Name = "Text_Cantidad";
            this.Text_Cantidad.Size = new System.Drawing.Size(200, 20);
            this.Text_Cantidad.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "FORMULARIO PESCA";
            // 
            // Btn_Registrar_Alimentacion
            // 
            this.Btn_Registrar_Alimentacion.Location = new System.Drawing.Point(40, 331);
            this.Btn_Registrar_Alimentacion.Name = "Btn_Registrar_Alimentacion";
            this.Btn_Registrar_Alimentacion.Size = new System.Drawing.Size(302, 33);
            this.Btn_Registrar_Alimentacion.TabIndex = 48;
            this.Btn_Registrar_Alimentacion.Text = "Registrar pesca";
            this.Btn_Registrar_Alimentacion.UseVisualStyleBackColor = true;
            this.Btn_Registrar_Alimentacion.Click += new System.EventHandler(this.Btn_Registrar_Alimentacion_Click);
            // 
            // Text_Listar
            // 
            this.Text_Listar.Location = new System.Drawing.Point(40, 370);
            this.Text_Listar.Name = "Text_Listar";
            this.Text_Listar.Size = new System.Drawing.Size(302, 31);
            this.Text_Listar.TabIndex = 64;
            this.Text_Listar.Text = "Listar";
            this.Text_Listar.UseVisualStyleBackColor = true;
            this.Text_Listar.Click += new System.EventHandler(this.Text_Listar_Click);
            // 
            // Actividad_pesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 425);
            this.Controls.Add(this.Text_Listar);
            this.Controls.Add(this.Cbx_Lotes);
            this.Controls.Add(this.Cxb_Persona);
            this.Controls.Add(this.Cbx_Estanque);
            this.Controls.Add(this.Text_Descripcion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tabla_Alimentacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.Text_Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Registrar_Alimentacion);
            this.Name = "Actividad_pesca";
            this.Text = "Actividad_pesca";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla_Alimentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbx_Lotes;
        private System.Windows.Forms.ComboBox Cxb_Persona;
        private System.Windows.Forms.ComboBox Cbx_Estanque;
        private System.Windows.Forms.TextBox Text_Descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Tabla_Alimentacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox Text_Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Registrar_Alimentacion;
        private System.Windows.Forms.Button Text_Listar;
    }
}