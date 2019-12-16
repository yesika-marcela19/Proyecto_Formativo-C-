namespace Actividad_proyecto
{
    partial class Actividad_Alimentacion
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
            this.Cbx_Lotes.Location = new System.Drawing.Point(138, 98);
            this.Cbx_Lotes.Name = "Cbx_Lotes";
            this.Cbx_Lotes.Size = new System.Drawing.Size(200, 21);
            this.Cbx_Lotes.TabIndex = 31;
            // 
            // Cxb_Persona
            // 
            this.Cxb_Persona.FormattingEnabled = true;
            this.Cxb_Persona.Location = new System.Drawing.Point(138, 138);
            this.Cxb_Persona.Name = "Cxb_Persona";
            this.Cxb_Persona.Size = new System.Drawing.Size(200, 21);
            this.Cxb_Persona.TabIndex = 30;
            // 
            // Cbx_Estanque
            // 
            this.Cbx_Estanque.FormattingEnabled = true;
            this.Cbx_Estanque.Location = new System.Drawing.Point(138, 62);
            this.Cbx_Estanque.Name = "Cbx_Estanque";
            this.Cbx_Estanque.Size = new System.Drawing.Size(200, 21);
            this.Cbx_Estanque.TabIndex = 29;
            this.Cbx_Estanque.SelectedIndexChanged += new System.EventHandler(this.Cbx_Estanque_SelectedIndexChanged);
            // 
            // Text_Descripcion
            // 
            this.Text_Descripcion.Location = new System.Drawing.Point(138, 224);
            this.Text_Descripcion.Name = "Text_Descripcion";
            this.Text_Descripcion.Size = new System.Drawing.Size(200, 20);
            this.Text_Descripcion.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Persona";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lotes activos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Estanques";
            // 
            // Tabla_Alimentacion
            // 
            this.Tabla_Alimentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla_Alimentacion.Location = new System.Drawing.Point(356, 49);
            this.Tabla_Alimentacion.Name = "Tabla_Alimentacion";
            this.Tabla_Alimentacion.Size = new System.Drawing.Size(459, 325);
            this.Tabla_Alimentacion.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "CANTIDAD ALIMENTO DIARIO";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(138, 179);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 19;
            // 
            // Text_Cantidad
            // 
            this.Text_Cantidad.Location = new System.Drawing.Point(138, 264);
            this.Text_Cantidad.Name = "Text_Cantidad";
            this.Text_Cantidad.Size = new System.Drawing.Size(200, 20);
            this.Text_Cantidad.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "FORMULARIO DE ALIMENTACION DE PECES";
            // 
            // Btn_Registrar_Alimentacion
            // 
            this.Btn_Registrar_Alimentacion.Location = new System.Drawing.Point(36, 302);
            this.Btn_Registrar_Alimentacion.Name = "Btn_Registrar_Alimentacion";
            this.Btn_Registrar_Alimentacion.Size = new System.Drawing.Size(302, 33);
            this.Btn_Registrar_Alimentacion.TabIndex = 16;
            this.Btn_Registrar_Alimentacion.Text = "Registrar alimentacion";
            this.Btn_Registrar_Alimentacion.UseVisualStyleBackColor = true;
            this.Btn_Registrar_Alimentacion.Click += new System.EventHandler(this.Btn_Registrar_Alimentacion_Click);
            // 
            // Text_Listar
            // 
            this.Text_Listar.Location = new System.Drawing.Point(36, 343);
            this.Text_Listar.Name = "Text_Listar";
            this.Text_Listar.Size = new System.Drawing.Size(302, 31);
            this.Text_Listar.TabIndex = 66;
            this.Text_Listar.Text = "Listar";
            this.Text_Listar.UseVisualStyleBackColor = true;
            // 
            // Actividad_Alimentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 386);
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
            this.Name = "Actividad_Alimentacion";
            this.Text = "Actividad_Alimentacion";
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