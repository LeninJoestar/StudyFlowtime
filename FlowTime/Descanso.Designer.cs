namespace FlowTime
{
    partial class Descanso
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
            this.lblTiempoDescanso = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tmrDescanso = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTiempoDescanso
            // 
            this.lblTiempoDescanso.AutoSize = true;
            this.lblTiempoDescanso.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoDescanso.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTiempoDescanso.Location = new System.Drawing.Point(141, 107);
            this.lblTiempoDescanso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiempoDescanso.Name = "lblTiempoDescanso";
            this.lblTiempoDescanso.Size = new System.Drawing.Size(11, 16);
            this.lblTiempoDescanso.TabIndex = 0;
            this.lblTiempoDescanso.Text = ".";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.Location = new System.Drawing.Point(176, 183);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 46);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Tomar descanso";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tmrDescanso
            // 
            this.tmrDescanso.Tick += new System.EventHandler(this.tmrDescanso_Tick);
            // 
            // Descanso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(498, 366);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTiempoDescanso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Descanso";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descanso";
            this.Load += new System.EventHandler(this.Descanso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempoDescanso;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Timer tmrDescanso;
    }
}