namespace FlowTime
{
    partial class estadosDeAnimo
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.flpEstados = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFeliz = new System.Windows.Forms.Button();
            this.btnEnojado = new System.Windows.Forms.Button();
            this.btnTriste = new System.Windows.Forms.Button();
            this.btnNeutral = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.txtSeleccion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(36, 92);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(135, 20);
            this.dtpFecha.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(405, 111);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 40);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // flpEstados
            // 
            this.flpEstados.Controls.Add(this.btnFeliz);
            this.flpEstados.Controls.Add(this.btnEnojado);
            this.flpEstados.Controls.Add(this.btnTriste);
            this.flpEstados.Controls.Add(this.btnNeutral);
            this.flpEstados.Location = new System.Drawing.Point(21, 68);
            this.flpEstados.Margin = new System.Windows.Forms.Padding(2);
            this.flpEstados.Name = "flpEstados";
            this.flpEstados.Size = new System.Drawing.Size(350, 83);
            this.flpEstados.TabIndex = 8;
            // 
            // btnFeliz
            // 
            this.btnFeliz.Image = global::FlowTime.Properties.Resources.feliz_3_;
            this.btnFeliz.Location = new System.Drawing.Point(2, 2);
            this.btnFeliz.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeliz.Name = "btnFeliz";
            this.btnFeliz.Size = new System.Drawing.Size(81, 81);
            this.btnFeliz.TabIndex = 0;
            this.btnFeliz.Tag = "Feliz";
            this.btnFeliz.UseVisualStyleBackColor = true;
            // 
            // btnEnojado
            // 
            this.btnEnojado.Image = global::FlowTime.Properties.Resources.cara_enojada;
            this.btnEnojado.Location = new System.Drawing.Point(87, 2);
            this.btnEnojado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnojado.Name = "btnEnojado";
            this.btnEnojado.Size = new System.Drawing.Size(81, 81);
            this.btnEnojado.TabIndex = 1;
            this.btnEnojado.Tag = "Enojado";
            this.btnEnojado.UseVisualStyleBackColor = true;
            // 
            // btnTriste
            // 
            this.btnTriste.Image = global::FlowTime.Properties.Resources.triste_2_;
            this.btnTriste.Location = new System.Drawing.Point(172, 2);
            this.btnTriste.Margin = new System.Windows.Forms.Padding(2);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(84, 81);
            this.btnTriste.TabIndex = 2;
            this.btnTriste.Tag = "Triste";
            this.btnTriste.UseVisualStyleBackColor = true;
            // 
            // btnNeutral
            // 
            this.btnNeutral.Image = global::FlowTime.Properties.Resources.neutral_1_;
            this.btnNeutral.Location = new System.Drawing.Point(260, 2);
            this.btnNeutral.Margin = new System.Windows.Forms.Padding(2);
            this.btnNeutral.Name = "btnNeutral";
            this.btnNeutral.Size = new System.Drawing.Size(85, 81);
            this.btnNeutral.TabIndex = 3;
            this.btnNeutral.Tag = "Neutral";
            this.btnNeutral.UseVisualStyleBackColor = true;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // txtSeleccion
            // 
            this.txtSeleccion.AutoSize = true;
            this.txtSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSeleccion.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSeleccion.Location = new System.Drawing.Point(20, 24);
            this.txtSeleccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSeleccion.Name = "txtSeleccion";
            this.txtSeleccion.Size = new System.Drawing.Size(320, 18);
            this.txtSeleccion.TabIndex = 13;
            this.txtSeleccion.Text = "¿Cual es tu estado de animo durante la sesion?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlowTime.Properties.Resources.emoticon;
            this.pictureBox1.Location = new System.Drawing.Point(345, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // estadosDeAnimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(565, 170);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSeleccion);
            this.Controls.Add(this.flpEstados);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "estadosDeAnimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estados_de_animo";
            this.Load += new System.EventHandler(this.estadosDeAnimo_Load);
            this.flpEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.FlowLayoutPanel flpEstados;
        private System.Windows.Forms.Button btnFeliz;
        private System.Windows.Forms.Button btnEnojado;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.Button btnNeutral;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label txtSeleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}