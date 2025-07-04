using System.Drawing;

namespace FlowTime
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTermiar = new System.Windows.Forms.Button();
            this.EntradaFlow = new System.Windows.Forms.Timer(this.components);
            this.SalidaFlow = new System.Windows.Forms.Timer(this.components);
            this.tmrDescanso = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFlow = new System.Windows.Forms.Button();
            this.pbCarga = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNotas = new FlowTime.BotonRedondo();
            this.plNotas = new System.Windows.Forms.Panel();
            this.btnElNota = new System.Windows.Forms.Button();
            this.btnAgNota = new System.Windows.Forms.Button();
            this.listBoxNotas = new System.Windows.Forms.ListBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarga)).BeginInit();
            this.panel1.SuspendLayout();
            this.plNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrCronometro
            // 
            this.tmrCronometro.Interval = 1;
            this.tmrCronometro.Tick += new System.EventHandler(this.tmrCronometro_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTimer.Location = new System.Drawing.Point(129, 95);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(118, 54);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "Inicio";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Location = new System.Drawing.Point(302, 356);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 34);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTermiar
            // 
            this.btnTermiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermiar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTermiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTermiar.Location = new System.Drawing.Point(232, 250);
            this.btnTermiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnTermiar.Name = "btnTermiar";
            this.btnTermiar.Size = new System.Drawing.Size(138, 27);
            this.btnTermiar.TabIndex = 11;
            this.btnTermiar.Text = "Terminar estudio";
            this.btnTermiar.UseVisualStyleBackColor = true;
            this.btnTermiar.Click += new System.EventHandler(this.btnTermiar_Click);
            // 
            // EntradaFlow
            // 
            this.EntradaFlow.Interval = 15;
            this.EntradaFlow.Tick += new System.EventHandler(this.EntradaFlow_Tick);
            // 
            // SalidaFlow
            // 
            this.SalidaFlow.Interval = 10;
            this.SalidaFlow.Tick += new System.EventHandler(this.SalidaFlow_Tick);
            // 
            // tmrDescanso
            // 
            this.tmrDescanso.Tick += new System.EventHandler(this.tmrDescanso_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.lblTimer);
            this.panel2.Controls.Add(this.btnFlow);
            this.panel2.Controls.Add(this.pbCarga);
            this.panel2.Controls.Add(this.btnTermiar);
            this.panel2.Location = new System.Drawing.Point(10, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 353);
            this.panel2.TabIndex = 19;
            // 
            // btnFlow
            // 
            this.btnFlow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlow.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFlow.Location = new System.Drawing.Point(79, 250);
            this.btnFlow.Margin = new System.Windows.Forms.Padding(2);
            this.btnFlow.Name = "btnFlow";
            this.btnFlow.Size = new System.Drawing.Size(94, 28);
            this.btnFlow.TabIndex = 21;
            this.btnFlow.Text = "Inicio";
            this.btnFlow.UseVisualStyleBackColor = true;
            this.btnFlow.Click += new System.EventHandler(this.btnFlow_Click);
            // 
            // pbCarga
            // 
            this.pbCarga.BackColor = System.Drawing.Color.Transparent;
            this.pbCarga.Image = ((System.Drawing.Image)(resources.GetObject("pbCarga.Image")));
            this.pbCarga.Location = new System.Drawing.Point(61, 3);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(286, 232);
            this.pbCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCarga.TabIndex = 20;
            this.pbCarga.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnNotas);
            this.panel1.Controls.Add(this.plNotas);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(421, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 398);
            this.panel1.TabIndex = 29;
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
            this.btnNotas.TabIndex = 16;
            this.btnNotas.Text = "     Agregar Nota";
            this.btnNotas.TextColor = System.Drawing.Color.White;
            this.btnNotas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotas.UseVisualStyleBackColor = false;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
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
            this.plNotas.TabIndex = 15;
            // 
            // btnElNota
            // 
            this.btnElNota.BackColor = System.Drawing.Color.Transparent;
            this.btnElNota.BackgroundImage = global::FlowTime.Properties.Resources.resta;
            this.btnElNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElNota.Location = new System.Drawing.Point(233, 10);
            this.btnElNota.Name = "btnElNota";
            this.btnElNota.Size = new System.Drawing.Size(35, 30);
            this.btnElNota.TabIndex = 36;
            this.btnElNota.UseVisualStyleBackColor = false;
            this.btnElNota.Click += new System.EventHandler(this.btnElNota_Click);
            // 
            // btnAgNota
            // 
            this.btnAgNota.BackColor = System.Drawing.Color.Transparent;
            this.btnAgNota.BackgroundImage = global::FlowTime.Properties.Resources.suma;
            this.btnAgNota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgNota.Location = new System.Drawing.Point(174, 10);
            this.btnAgNota.Name = "btnAgNota";
            this.btnAgNota.Size = new System.Drawing.Size(35, 30);
            this.btnAgNota.TabIndex = 35;
            this.btnAgNota.UseVisualStyleBackColor = false;
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
            // lblTitulo2
            // 
            this.lblTitulo2.AutoSize = true;
            this.lblTitulo2.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo2.ForeColor = System.Drawing.Color.White;
            this.lblTitulo2.Location = new System.Drawing.Point(141, 17);
            this.lblTitulo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo2.Name = "lblTitulo2";
            this.lblTitulo2.Size = new System.Drawing.Size(134, 37);
            this.lblTitulo2.TabIndex = 31;
            this.lblTitulo2.Text = "FlowTime";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 443);
            this.Controls.Add(this.lblTitulo2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flowtime";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarga)).EndInit();
            this.panel1.ResumeLayout(false);
            this.plNotas.ResumeLayout(false);
            this.plNotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrCronometro;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnTermiar;
        private System.Windows.Forms.Timer EntradaFlow;
        private System.Windows.Forms.Timer SalidaFlow;
        private System.Windows.Forms.Timer tmrDescanso;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbCarga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFlow;
        private System.Windows.Forms.Label lblTitulo2;
        private System.Windows.Forms.Panel plNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ListBox listBoxNotas;
        private System.Windows.Forms.Button btnAgNota;
        private System.Windows.Forms.Button btnElNota;
        private BotonRedondo btnNotas;
    }
}