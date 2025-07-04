namespace FlowTime
{
    partial class Tutorial
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
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pbImagenes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackColor = System.Drawing.Color.Transparent;
            this.btnDerecha.BackgroundImage = global::FlowTime.Properties.Resources.flechaderecha;
            this.btnDerecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDerecha.Location = new System.Drawing.Point(325, 420);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(56, 49);
            this.btnDerecha.TabIndex = 14;
            this.btnDerecha.UseVisualStyleBackColor = false;
            this.btnDerecha.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackColor = System.Drawing.Color.Transparent;
            this.btnIzquierda.BackgroundImage = global::FlowTime.Properties.Resources.flechaizquierda;
            this.btnIzquierda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIzquierda.Location = new System.Drawing.Point(202, 420);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(56, 49);
            this.btnIzquierda.TabIndex = 13;
            this.btnIzquierda.UseVisualStyleBackColor = false;
            this.btnIzquierda.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImage = global::FlowTime.Properties.Resources.salir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(513, 457);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(48, 43);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pbImagenes
            // 
            this.pbImagenes.Location = new System.Drawing.Point(4, 24);
            this.pbImagenes.Name = "pbImagenes";
            this.pbImagenes.Size = new System.Drawing.Size(565, 380);
            this.pbImagenes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenes.TabIndex = 9;
            this.pbImagenes.TabStop = false;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(573, 512);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnIzquierda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pbImagenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.Tutorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagenes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
    }
}