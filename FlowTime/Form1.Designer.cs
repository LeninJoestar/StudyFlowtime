namespace FlowTime
{
    partial class frmInicioSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.pbMostrar = new System.Windows.Forms.PictureBox();
            this.pbOcultar = new System.Windows.Forms.PictureBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Desvanecido = new System.Windows.Forms.Timer(this.components);
            this.gbregistrarse = new System.Windows.Forms.GroupBox();
            this.lblAdvertencia = new System.Windows.Forms.Label();
            this.btnRegistrarNuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasenaNueva = new System.Windows.Forms.TextBox();
            this.txtUsuarioNuevo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnregirtarse = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).BeginInit();
            this.gbregistrarse.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInicio
            // 
            this.gbInicio.BackColor = System.Drawing.Color.Transparent;
            this.gbInicio.Controls.Add(this.pbMostrar);
            this.gbInicio.Controls.Add(this.pbOcultar);
            this.gbInicio.Controls.Add(this.btnInicioSesion);
            this.gbInicio.Controls.Add(this.txtContraseña);
            this.gbInicio.Controls.Add(this.txtUsuario);
            this.gbInicio.Controls.Add(this.label2);
            this.gbInicio.Controls.Add(this.label1);
            this.gbInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.gbInicio.Location = new System.Drawing.Point(281, -10);
            this.gbInicio.Margin = new System.Windows.Forms.Padding(0);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Padding = new System.Windows.Forms.Padding(2);
            this.gbInicio.Size = new System.Drawing.Size(421, 434);
            this.gbInicio.TabIndex = 1;
            this.gbInicio.TabStop = false;
            // 
            // pbMostrar
            // 
            this.pbMostrar.Image = global::FlowTime.Properties.Resources.ojo;
            this.pbMostrar.Location = new System.Drawing.Point(315, 171);
            this.pbMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.pbMostrar.Name = "pbMostrar";
            this.pbMostrar.Size = new System.Drawing.Size(37, 31);
            this.pbMostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMostrar.TabIndex = 6;
            this.pbMostrar.TabStop = false;
            this.pbMostrar.Click += new System.EventHandler(this.pbMostrar_Click);
            // 
            // pbOcultar
            // 
            this.pbOcultar.Image = global::FlowTime.Properties.Resources.ojo_cruzado;
            this.pbOcultar.Location = new System.Drawing.Point(314, 171);
            this.pbOcultar.Margin = new System.Windows.Forms.Padding(2);
            this.pbOcultar.Name = "pbOcultar";
            this.pbOcultar.Size = new System.Drawing.Size(40, 31);
            this.pbOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOcultar.TabIndex = 5;
            this.pbOcultar.TabStop = false;
            this.pbOcultar.Click += new System.EventHandler(this.pbOcultar_Click);
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnInicioSesion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInicioSesion.Location = new System.Drawing.Point(91, 224);
            this.btnInicioSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(212, 29);
            this.btnInicioSesion.TabIndex = 4;
            this.btnInicioSesion.Text = "Iniciar sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.Silver;
            this.txtContraseña.Location = new System.Drawing.Point(91, 176);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(213, 26);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuario.Location = new System.Drawing.Point(91, 109);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(213, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Desvanecido
            // 
            this.Desvanecido.Interval = 30;
            this.Desvanecido.Tick += new System.EventHandler(this.Desvanecido_Tick);
            // 
            // gbregistrarse
            // 
            this.gbregistrarse.BackColor = System.Drawing.Color.Transparent;
            this.gbregistrarse.Controls.Add(this.lblAdvertencia);
            this.gbregistrarse.Controls.Add(this.btnRegistrarNuevo);
            this.gbregistrarse.Controls.Add(this.label4);
            this.gbregistrarse.Controls.Add(this.label5);
            this.gbregistrarse.Controls.Add(this.label6);
            this.gbregistrarse.Controls.Add(this.txtContrasenaNueva);
            this.gbregistrarse.Controls.Add(this.txtUsuarioNuevo);
            this.gbregistrarse.Controls.Add(this.txtNombre);
            this.gbregistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbregistrarse.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbregistrarse.ForeColor = System.Drawing.SystemColors.Control;
            this.gbregistrarse.Location = new System.Drawing.Point(265, 3);
            this.gbregistrarse.Margin = new System.Windows.Forms.Padding(2);
            this.gbregistrarse.Name = "gbregistrarse";
            this.gbregistrarse.Padding = new System.Windows.Forms.Padding(2);
            this.gbregistrarse.Size = new System.Drawing.Size(740, 482);
            this.gbregistrarse.TabIndex = 9;
            this.gbregistrarse.TabStop = false;
            this.gbregistrarse.Visible = false;
            this.gbregistrarse.Paint += new System.Windows.Forms.PaintEventHandler(this.gbregistrarse_Paint);
            // 
            // lblAdvertencia
            // 
            this.lblAdvertencia.AutoSize = true;
            this.lblAdvertencia.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9F, System.Drawing.FontStyle.Italic);
            this.lblAdvertencia.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAdvertencia.Image = global::FlowTime.Properties.Resources.Advertencia;
            this.lblAdvertencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdvertencia.Location = new System.Drawing.Point(105, 239);
            this.lblAdvertencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdvertencia.Name = "lblAdvertencia";
            this.lblAdvertencia.Padding = new System.Windows.Forms.Padding(1);
            this.lblAdvertencia.Size = new System.Drawing.Size(138, 14);
            this.lblAdvertencia.TabIndex = 16;
            this.lblAdvertencia.Text = "    Rellene todos los campos.";
            this.lblAdvertencia.Visible = false;
            // 
            // btnRegistrarNuevo
            // 
            this.btnRegistrarNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.btnRegistrarNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnRegistrarNuevo.Location = new System.Drawing.Point(103, 261);
            this.btnRegistrarNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarNuevo.Name = "btnRegistrarNuevo";
            this.btnRegistrarNuevo.Size = new System.Drawing.Size(213, 29);
            this.btnRegistrarNuevo.TabIndex = 15;
            this.btnRegistrarNuevo.Text = "Registrarse";
            this.btnRegistrarNuevo.UseVisualStyleBackColor = false;
            this.btnRegistrarNuevo.Click += new System.EventHandler(this.btnRegistrarNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(102, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(104, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(102, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // txtContrasenaNueva
            // 
            this.txtContrasenaNueva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtContrasenaNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContrasenaNueva.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.txtContrasenaNueva.ForeColor = System.Drawing.Color.Silver;
            this.txtContrasenaNueva.Location = new System.Drawing.Point(103, 203);
            this.txtContrasenaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenaNueva.Name = "txtContrasenaNueva";
            this.txtContrasenaNueva.Size = new System.Drawing.Size(213, 26);
            this.txtContrasenaNueva.TabIndex = 11;
            // 
            // txtUsuarioNuevo
            // 
            this.txtUsuarioNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtUsuarioNuevo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuarioNuevo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.txtUsuarioNuevo.ForeColor = System.Drawing.Color.Silver;
            this.txtUsuarioNuevo.Location = new System.Drawing.Point(103, 142);
            this.txtUsuarioNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuarioNuevo.Name = "txtUsuarioNuevo";
            this.txtUsuarioNuevo.Size = new System.Drawing.Size(213, 26);
            this.txtUsuarioNuevo.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.Silver;
            this.txtNombre.Location = new System.Drawing.Point(103, 84);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 26);
            this.txtNombre.TabIndex = 9;
            // 
            // btnregirtarse
            // 
            this.btnregirtarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btnregirtarse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btnregirtarse.FlatAppearance.BorderSize = 0;
            this.btnregirtarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.btnregirtarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregirtarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregirtarse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnregirtarse.Location = new System.Drawing.Point(375, 5);
            this.btnregirtarse.Margin = new System.Windows.Forms.Padding(2);
            this.btnregirtarse.Name = "btnregirtarse";
            this.btnregirtarse.Size = new System.Drawing.Size(77, 27);
            this.btnregirtarse.TabIndex = 10;
            this.btnregirtarse.Text = "Registrarse";
            this.btnregirtarse.UseVisualStyleBackColor = false;
            this.btnregirtarse.Click += new System.EventHandler(this.btnregirtarse_Click);
            this.btnregirtarse.DragOver += new System.Windows.Forms.DragEventHandler(this.btnregirtarse_DragOver);
            this.btnregirtarse.Paint += new System.Windows.Forms.PaintEventHandler(this.btnregirtarse_Paint);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(51)))), ((int)(((byte)(54)))));
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInicio.Location = new System.Drawing.Point(300, 5);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(77, 27);
            this.btnInicio.TabIndex = 11;
            this.btnInicio.Text = "Iniciar sesión";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnregirtarse);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Location = new System.Drawing.Point(184, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 44);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlowTime.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(650, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbregistrarse);
            this.Controls.Add(this.gbInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOcultar)).EndInit();
            this.gbregistrarse.ResumeLayout(false);
            this.gbregistrarse.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.PictureBox pbOcultar;
        private System.Windows.Forms.PictureBox pbMostrar;
        private System.Windows.Forms.Timer Desvanecido;
        private System.Windows.Forms.GroupBox gbregistrarse;
        private System.Windows.Forms.Button btnRegistrarNuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasenaNueva;
        private System.Windows.Forms.TextBox txtUsuarioNuevo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnregirtarse;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdvertencia;
    }
}

