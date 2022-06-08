namespace BerberiaVacana
{
    partial class Form1
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
            this.BarberoTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.correoTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrupoCaja = new System.Windows.Forms.GroupBox();
            this.listabarbero = new System.Windows.Forms.ComboBox();
            this.ListaHora = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CedulaTexto = new System.Windows.Forms.TextBox();
            this.TelefonoTexto = new System.Windows.Forms.TextBox();
            this.CorreoTexto = new System.Windows.Forms.TextBox();
            this.ClienteTexto = new System.Windows.Forms.TextBox();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonCancelarCita = new System.Windows.Forms.Button();
            this.BotonCrearCita = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrupoCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarberoTitulo
            // 
            this.BarberoTitulo.AutoSize = true;
            this.BarberoTitulo.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarberoTitulo.Location = new System.Drawing.Point(162, 20);
            this.BarberoTitulo.Name = "BarberoTitulo";
            this.BarberoTitulo.Size = new System.Drawing.Size(506, 44);
            this.BarberoTitulo.TabIndex = 0;
            this.BarberoTitulo.Text = "Welcome to El Barbero ma Vacano";
            this.BarberoTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // correoTitulo
            // 
            this.correoTitulo.AutoSize = true;
            this.correoTitulo.Location = new System.Drawing.Point(45, 109);
            this.correoTitulo.Name = "correoTitulo";
            this.correoTitulo.Size = new System.Drawing.Size(38, 13);
            this.correoTitulo.TabIndex = 2;
            this.correoTitulo.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cedula";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // GrupoCaja
            // 
            this.GrupoCaja.Controls.Add(this.listabarbero);
            this.GrupoCaja.Controls.Add(this.ListaHora);
            this.GrupoCaja.Controls.Add(this.dateTimePicker1);
            this.GrupoCaja.Controls.Add(this.label6);
            this.GrupoCaja.Controls.Add(this.CedulaTexto);
            this.GrupoCaja.Controls.Add(this.TelefonoTexto);
            this.GrupoCaja.Controls.Add(this.CorreoTexto);
            this.GrupoCaja.Controls.Add(this.ClienteTexto);
            this.GrupoCaja.Controls.Add(this.BotonGuardar);
            this.GrupoCaja.Controls.Add(this.BotonCancelarCita);
            this.GrupoCaja.Controls.Add(this.BotonCrearCita);
            this.GrupoCaja.Controls.Add(this.label5);
            this.GrupoCaja.Controls.Add(this.correoTitulo);
            this.GrupoCaja.Controls.Add(this.label4);
            this.GrupoCaja.Controls.Add(this.label1);
            this.GrupoCaja.Controls.Add(this.label3);
            this.GrupoCaja.Location = new System.Drawing.Point(12, 81);
            this.GrupoCaja.Name = "GrupoCaja";
            this.GrupoCaja.Size = new System.Drawing.Size(761, 314);
            this.GrupoCaja.TabIndex = 5;
            this.GrupoCaja.TabStop = false;
            this.GrupoCaja.Text = "groupBox1";
            this.GrupoCaja.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listabarbero
            // 
            this.listabarbero.FormattingEnabled = true;
            this.listabarbero.Location = new System.Drawing.Point(360, 86);
            this.listabarbero.Name = "listabarbero";
            this.listabarbero.Size = new System.Drawing.Size(121, 21);
            this.listabarbero.TabIndex = 17;
            // 
            // ListaHora
            // 
            this.ListaHora.FormattingEnabled = true;
            this.ListaHora.Location = new System.Drawing.Point(268, 275);
            this.ListaHora.Name = "ListaHora";
            this.ListaHora.Size = new System.Drawing.Size(121, 21);
            this.ListaHora.TabIndex = 16;
            this.ListaHora.SelectedIndexChanged += new System.EventHandler(this.ListaHora_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(48, 276);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Los Barberos";
            // 
            // CedulaTexto
            // 
            this.CedulaTexto.Location = new System.Drawing.Point(48, 228);
            this.CedulaTexto.Name = "CedulaTexto";
            this.CedulaTexto.Size = new System.Drawing.Size(100, 20);
            this.CedulaTexto.TabIndex = 13;
            // 
            // TelefonoTexto
            // 
            this.TelefonoTexto.Location = new System.Drawing.Point(48, 182);
            this.TelefonoTexto.Name = "TelefonoTexto";
            this.TelefonoTexto.Size = new System.Drawing.Size(100, 20);
            this.TelefonoTexto.TabIndex = 12;
            // 
            // CorreoTexto
            // 
            this.CorreoTexto.Location = new System.Drawing.Point(48, 127);
            this.CorreoTexto.Name = "CorreoTexto";
            this.CorreoTexto.Size = new System.Drawing.Size(100, 20);
            this.CorreoTexto.TabIndex = 11;
            // 
            // ClienteTexto
            // 
            this.ClienteTexto.Location = new System.Drawing.Point(48, 76);
            this.ClienteTexto.Name = "ClienteTexto";
            this.ClienteTexto.Size = new System.Drawing.Size(100, 20);
            this.ClienteTexto.TabIndex = 10;
            this.ClienteTexto.TextChanged += new System.EventHandler(this.ClienteTexto_TextChanged);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(611, 182);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(75, 43);
            this.BotonGuardar.TabIndex = 8;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonCancelarCita
            // 
            this.BotonCancelarCita.Location = new System.Drawing.Point(611, 127);
            this.BotonCancelarCita.Name = "BotonCancelarCita";
            this.BotonCancelarCita.Size = new System.Drawing.Size(75, 45);
            this.BotonCancelarCita.TabIndex = 7;
            this.BotonCancelarCita.Text = "Cancelar Cita";
            this.BotonCancelarCita.UseVisualStyleBackColor = true;
            this.BotonCancelarCita.Click += new System.EventHandler(this.BotonCancelarCita_Click);
            // 
            // BotonCrearCita
            // 
            this.BotonCrearCita.Location = new System.Drawing.Point(611, 64);
            this.BotonCrearCita.Name = "BotonCrearCita";
            this.BotonCrearCita.Size = new System.Drawing.Size(75, 44);
            this.BotonCrearCita.TabIndex = 6;
            this.BotonCrearCita.Text = "Crear Cita";
            this.BotonCrearCita.UseVisualStyleBackColor = true;
            this.BotonCrearCita.Click += new System.EventHandler(this.BotonCrearCita_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 401);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(761, 106);
            this.dataGridView1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GrupoCaja);
            this.Controls.Add(this.BarberoTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GrupoCaja.ResumeLayout(false);
            this.GrupoCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BarberoTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label correoTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrupoCaja;
        private System.Windows.Forms.ComboBox ListaHora;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CedulaTexto;
        private System.Windows.Forms.TextBox TelefonoTexto;
        private System.Windows.Forms.TextBox CorreoTexto;
        private System.Windows.Forms.TextBox ClienteTexto;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonCancelarCita;
        private System.Windows.Forms.Button BotonCrearCita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listabarbero;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

