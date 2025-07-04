namespace FlowTime
{
    partial class Pomodoro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.tmrTemporizador = new System.Windows.Forms.Timer(this.components);
            this.EntradaPomo = new System.Windows.Forms.Timer(this.components);
            this.SalidaPomo = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.plNotas = new System.Windows.Forms.Panel();
            this.btnElNota = new System.Windows.Forms.Button();
            this.btnAgNota = new System.Windows.Forms.Button();
            this.listBoxNotas = new System.Windows.Forms.ListBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnCorto = new System.Windows.Forms.Button();
            this.btnLargo = new System.Windows.Forms.Button();
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.btnSaltarDescanso = new System.Windows.Forms.Button();
            this.pbCarga = new System.Windows.Forms.PictureBox();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.btnNotas = new FlowTime.BotonRedondo();
            this.panel1.SuspendLayout();
            this.plNotas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTemporizador
            // 
            this.tmrTemporizador.Interval = 1000;
            this.tmrTemporizador.Tick += new System.EventHandler(this.tmrTemporizador_Tick);
            // 
            // EntradaPomo
            // 
            this.EntradaPomo.Interval = 15;
            this.EntradaPomo.Tick += new System.EventHandler(this.EntradaPomo_Tick);
            // 
            // SalidaPomo
            // 
            this.SalidaPomo.Interval = 10;
            this.SalidaPomo.Tick += new System.EventHandler(this.SalidaPomo_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnNotas);
            this.panel1.Controls.Add(this.plNotas);
            this.panel1.Controls.Add(this.btnSalir2);
            this.panel1.Location = new System.Drawing.Point(421, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 398);
            this.panel1.TabIndex = 28;
            // 
            // plNotas
            // 
            this.plNotas.BackColor = System.Drawing.Color.White;
            this.plNotas.Controls.Add(this.btnElNota);
            this.plNotas.Controls.Add(this.btnAgNota);
            this.plNotas.Controls.Add(this.listBoxNotas);
            this.plNotas.Controls.Add(this.txtNota);
            this.plNotas.Controls.Add(this.label1);
            this.plNotas.Location = new System.Drawing.Point(29, 74);
            this.plNotas.Name = "plNotas";
            this.plNotas.Size = new System.Drawing.Size(318, 258);
            this.plNotas.TabIndex = 16;
            // 
            // btnElNota
            // 
            this.btnElNota.BackgroundImage = global::FlowTime.Properties.Resources.resta;
            this.btnElNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElNota.Location = new System.Drawing.Point(233, 10);
            this.btnElNota.Name = "btnElNota";
            this.btnElNota.Size = new System.Drawing.Size(35, 30);
            this.btnElNota.TabIndex = 36;
            this.btnElNota.UseVisualStyleBackColor = true;
            this.btnElNota.Click += new System.EventHandler(this.btnElNota_Click);
            // 
            // btnAgNota
            // 
            this.btnAgNota.BackgroundImage = global::FlowTime.Properties.Resources.suma;
            this.btnAgNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgNota.Location = new System.Drawing.Point(174, 10);
            this.btnAgNota.Name = "btnAgNota";
            this.btnAgNota.Size = new System.Drawing.Size(35, 30);
            this.btnAgNota.TabIndex = 35;
            this.btnAgNota.UseVisualStyleBackColor = true;
            this.btnAgNota.Click += new System.EventHandler(this.btnAgNota_Click);
            // 
            // listBoxNotas
            // 
            this.listBoxNotas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotas.FormattingEnabled = true;
            this.listBoxNotas.ItemHeight = 17;
            this.listBoxNotas.Location = new System.Drawing.Point(22, 75);
            this.listBoxNotas.Name = "listBoxNotas";
            this.listBoxNotas.Size = new System.Drawing.Size(278, 157);
            this.listBoxNotas.TabIndex = 34;
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(22, 47);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(278, 26);
            this.txtNota.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Agregar nota";
            // 
            // btnSalir2
            // 
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir2.Location = new System.Drawing.Point(302, 356);
            this.btnSalir2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(64, 34);
            this.btnSalir2.TabIndex = 10;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseVisualStyleBackColor = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Controls.Add(this.btnCorto);
            this.panel2.Controls.Add(this.btnLargo);
            this.panel2.Controls.Add(this.lblTimer2);
            this.panel2.Controls.Add(this.btnSaltarDescanso);
            this.panel2.Controls.Add(this.pbCarga);
            this.panel2.Location = new System.Drawing.Point(10, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 353);
            this.panel2.TabIndex = 29;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPlay.FlatAppearance.BorderSize = 2;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Location = new System.Drawing.Point(56, 283);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(122, 38);
            this.btnPlay.TabIndex = 28;
            this.btnPlay.Text = "Iniciar";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // btnCorto
            // 
            this.btnCorto.BackColor = System.Drawing.Color.Transparent;
            this.btnCorto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorto.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCorto.Location = new System.Drawing.Point(82, 226);
            this.btnCorto.Margin = new System.Windows.Forms.Padding(2);
            this.btnCorto.Name = "btnCorto";
            this.btnCorto.Size = new System.Drawing.Size(96, 34);
            this.btnCorto.TabIndex = 27;
            this.btnCorto.Text = "Corto";
            this.btnCorto.UseVisualStyleBackColor = false;
            this.btnCorto.Click += new System.EventHandler(this.btnCorto_Click);
            // 
            // btnLargo
            // 
            this.btnLargo.BackColor = System.Drawing.Color.Transparent;
            this.btnLargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLargo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLargo.Location = new System.Drawing.Point(224, 226);
            this.btnLargo.Margin = new System.Windows.Forms.Padding(2);
            this.btnLargo.Name = "btnLargo";
            this.btnLargo.Size = new System.Drawing.Size(96, 34);
            this.btnLargo.TabIndex = 26;
            this.btnLargo.Text = "Largo";
            this.btnLargo.UseVisualStyleBackColor = false;
            this.btnLargo.Click += new System.EventHandler(this.btnLargo_Click);
            // 
            // lblTimer2
            // 
            this.lblTimer2.AutoSize = true;
            this.lblTimer2.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimer2.Location = new System.Drawing.Point(143, 93);
            this.lblTimer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(118, 54);
            this.lblTimer2.TabIndex = 7;
            this.lblTimer2.Text = "Inicio";
            // 
            // btnSaltarDescanso
            // 
            this.btnSaltarDescanso.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSaltarDescanso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaltarDescanso.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaltarDescanso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaltarDescanso.Location = new System.Drawing.Point(224, 283);
            this.btnSaltarDescanso.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaltarDescanso.Name = "btnSaltarDescanso";
            this.btnSaltarDescanso.Size = new System.Drawing.Size(136, 38);
            this.btnSaltarDescanso.TabIndex = 13;
            this.btnSaltarDescanso.Text = "Saltar Descanso";
            this.btnSaltarDescanso.UseVisualStyleBackColor = true;
            this.btnSaltarDescanso.Click += new System.EventHandler(this.btnSaltarDescanso_Click);
            // 
            // pbCarga
            // 
            this.pbCarga.BackColor = System.Drawing.Color.Transparent;
            this.pbCarga.Image = ((System.Drawing.Image)(resources.GetObject("pbCarga.Image")));
            this.pbCarga.Location = new System.Drawing.Point(103, 32);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(204, 177);
            this.pbCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarga.TabIndex = 29;
            this.pbCarga.TabStop = false;
            // 
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(141, 17);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(146, 37);
            this.lblTitulo2.TabIndex = 30;
            this.lblTitulo2.Text = "Pomodoro";
            // 
            // btnNotas
            // 
            this.btnNotas.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNotas.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btnNotas.BorderColor = System.Drawing.Color.White;
            this.btnNotas.BorderRadius = 20;
            this.btnNotas.BorderSize = 0;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.Image = global::FlowTime.Properties.Resources.mas;
            this.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotas.Location = new System.Drawing.Point(113, 21);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(162, 37);
            this.btnNotas.TabIndex = 17;
            this.btnNotas.Text = "     Agregar Nota";
            this.btnNotas.TextColor = System.Drawing.Color.White;
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 443);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pomodoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.Load += new System.EventHandler(this.Pomodoro_Load);
            this.panel1.ResumeLayout(false);
            this.plNotas.ResumeLayout(false);
            this.plNotas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrTemporizador;
        private System.Windows.Forms.Timer EntradaPomo;
        private System.Windows.Forms.Timer SalidaPomo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimer2;
        private System.Windows.Forms.Button btnSaltarDescanso;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Button btnCorto;
        private System.Windows.Forms.Button btnLargo;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.PictureBox pbCarga;
        private System.Windows.Forms.Panel plNotas;
        private System.Windows.Forms.Button btnElNota;
        private System.Windows.Forms.Button btnAgNota;
        private System.Windows.Forms.ListBox listBoxNotas;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
        private BotonRedondo btnNotas;
    }
}