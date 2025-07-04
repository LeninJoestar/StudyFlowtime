namespace FlowTime
{
    partial class calendarioAnimo
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
            this.flpEstadosSeleccionados = new System.Windows.Forms.FlowLayoutPanel();
            this.txtEstadosSeleccionados = new System.Windows.Forms.Label();
            this.mcResumen = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpEstadosSeleccionados
            // 
            this.flpEstadosSeleccionados.Location = new System.Drawing.Point(281, 84);
            this.flpEstadosSeleccionados.Margin = new System.Windows.Forms.Padding(2);
            this.flpEstadosSeleccionados.Name = "flpEstadosSeleccionados";
            this.flpEstadosSeleccionados.Size = new System.Drawing.Size(267, 65);
            this.flpEstadosSeleccionados.TabIndex = 13;
            // 
            // txtEstadosSeleccionados
            // 
            this.txtEstadosSeleccionados.AutoSize = true;
            this.txtEstadosSeleccionados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEstadosSeleccionados.ForeColor = System.Drawing.SystemColors.Control;
            this.txtEstadosSeleccionados.Location = new System.Drawing.Point(277, 58);
            this.txtEstadosSeleccionados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtEstadosSeleccionados.Name = "txtEstadosSeleccionados";
            this.txtEstadosSeleccionados.Size = new System.Drawing.Size(0, 18);
            this.txtEstadosSeleccionados.TabIndex = 12;
            // 
            // mcResumen
            // 
            this.mcResumen.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.mcResumen.Location = new System.Drawing.Point(19, 48);
            this.mcResumen.Margin = new System.Windows.Forms.Padding(6);
            this.mcResumen.Name = "mcResumen";
            this.mcResumen.TabIndex = 11;
            this.mcResumen.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcResumen_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(75, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registro emocional:";
            // 
            // calendarioAnimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(594, 239);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpEstadosSeleccionados);
            this.Controls.Add(this.txtEstadosSeleccionados);
            this.Controls.Add(this.mcResumen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "calendarioAnimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calendarioAnimo";
            this.Load += new System.EventHandler(this.calendarioAnimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEstadosSeleccionados;
        private System.Windows.Forms.Label txtEstadosSeleccionados;
        private System.Windows.Forms.MonthCalendar mcResumen;
        private System.Windows.Forms.Label label1;
    }
}