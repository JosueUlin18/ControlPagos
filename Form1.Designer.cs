
namespace ControlPagos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cuota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dpiDue = new System.Windows.Forms.TextBox();
            this.txt_numCasa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_propetarioDatos = new System.Windows.Forms.Button();
            this.btn_ingresarPropiedad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(411, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de pagos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(593, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(720, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datos del cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "DPI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(905, 154);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(334, 27);
            this.txt_dpi.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(905, 196);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(334, 27);
            this.txt_nombre.TabIndex = 7;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(905, 240);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(334, 27);
            this.txt_apellido.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(720, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Propiedades";
            // 
            // txt_cuota
            // 
            this.txt_cuota.Location = new System.Drawing.Point(905, 474);
            this.txt_cuota.Name = "txt_cuota";
            this.txt_cuota.Size = new System.Drawing.Size(334, 27);
            this.txt_cuota.TabIndex = 17;
            this.txt_cuota.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(720, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cuota de mantenimiento";
            // 
            // txt_dpiDue
            // 
            this.txt_dpiDue.Location = new System.Drawing.Point(905, 423);
            this.txt_dpiDue.Name = "txt_dpiDue";
            this.txt_dpiDue.Size = new System.Drawing.Size(334, 27);
            this.txt_dpiDue.TabIndex = 15;
            // 
            // txt_numCasa
            // 
            this.txt_numCasa.Location = new System.Drawing.Point(905, 381);
            this.txt_numCasa.Name = "txt_numCasa";
            this.txt_numCasa.Size = new System.Drawing.Size(334, 27);
            this.txt_numCasa.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(720, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "DPI del Dueño";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(720, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Número de Casa";
            // 
            // btn_propetarioDatos
            // 
            this.btn_propetarioDatos.Location = new System.Drawing.Point(982, 292);
            this.btn_propetarioDatos.Name = "btn_propetarioDatos";
            this.btn_propetarioDatos.Size = new System.Drawing.Size(238, 32);
            this.btn_propetarioDatos.TabIndex = 18;
            this.btn_propetarioDatos.Text = "Ingresar datos del propetario";
            this.btn_propetarioDatos.UseVisualStyleBackColor = true;
            this.btn_propetarioDatos.Click += new System.EventHandler(this.btn_propetarioDatos_Click);
            // 
            // btn_ingresarPropiedad
            // 
            this.btn_ingresarPropiedad.Location = new System.Drawing.Point(982, 532);
            this.btn_ingresarPropiedad.Name = "btn_ingresarPropiedad";
            this.btn_ingresarPropiedad.Size = new System.Drawing.Size(229, 29);
            this.btn_ingresarPropiedad.TabIndex = 19;
            this.btn_ingresarPropiedad.Text = "Ingresar propiedad";
            this.btn_ingresarPropiedad.UseVisualStyleBackColor = true;
            this.btn_ingresarPropiedad.Click += new System.EventHandler(this.btn_ingresarPropiedad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 765);
            this.Controls.Add(this.btn_ingresarPropiedad);
            this.Controls.Add(this.btn_propetarioDatos);
            this.Controls.Add(this.txt_cuota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_dpiDue);
            this.Controls.Add(this.txt_numCasa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_dpi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cuota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dpiDue;
        private System.Windows.Forms.TextBox txt_numCasa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_propetarioDatos;
        private System.Windows.Forms.Button btn_ingresarPropiedad;
    }
}

