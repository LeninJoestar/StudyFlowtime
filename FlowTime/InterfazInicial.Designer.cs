namespace FlowTime
{
    partial class InterfazInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazInicial));
            this.Entrada = new System.Windows.Forms.Timer(this.components);
            this.Salida = new System.Windows.Forms.Timer(this.components);
            this.Salida2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrBarraOpcionesTransicion = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalidaEstadisticas = new System.Windows.Forms.Timer(this.components);
            this.plOpciones = new System.Windows.Forms.Panel();
            this.btnEmocional = new System.Windows.Forms.Button();
            this.plTemas = new System.Windows.Forms.Panel();
            this.btnDefecto = new System.Windows.Forms.PictureBox();
            this.btnAmarillo = new System.Windows.Forms.PictureBox();
            this.btnAzul = new System.Windows.Forms.PictureBox();
            this.btnRojo = new System.Windows.Forms.PictureBox();
            this.btnVerde = new System.Windows.Forms.PictureBox();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnTutorial = new System.Windows.Forms.Button();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnFlowTime = new System.Windows.Forms.Button();
            this.plOpciones.SuspendLayout();
            this.plTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDefecto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerde)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrada
            // 
            this.Entrada.Interval = 15;
            this.Entrada.Tick += new System.EventHandler(this.Entrada_Tick);
            // 
            // Salida
            // 
            this.Salida.Interval = 12;
            // 
            // Salida2
            // 
            this.Salida2.Interval = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(256, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 59);
            this.label1.TabIndex = 12;
            this.label1.Text = "Study with FlowTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(262, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 45);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estudia, analiza y cocentrate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(277, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Aumenta tu concentracion y tu conocimiento bajo tiempo controlado";
            // 
            // tmrBarraOpcionesTransicion
            // 
            this.tmrBarraOpcionesTransicion.Interval = 10;
            this.tmrBarraOpcionesTransicion.Tick += new System.EventHandler(this.tmrBarraOpcionesTransicion_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(312, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 17;
            this.label4.Text = "Flowtime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(635, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 32);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pomodoro";
            // 
            // SalidaEstadisticas
            // 
            this.SalidaEstadisticas.Interval = 12;
            // 
            // plOpciones
            // 
            this.plOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.plOpciones.Controls.Add(this.btnEmocional);
            this.plOpciones.Controls.Add(this.plTemas);
            this.plOpciones.Controls.Add(this.btnEstadisticas);
            this.plOpciones.Controls.Add(this.btnConfiguracion);
            this.plOpciones.Controls.Add(this.btnCerrarSesion);
            this.plOpciones.Controls.Add(this.btnTutorial);
            this.plOpciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.plOpciones.Location = new System.Drawing.Point(0, 0);
            this.plOpciones.Name = "plOpciones";
            this.plOpciones.Size = new System.Drawing.Size(210, 475);
            this.plOpciones.TabIndex = 20;
            // 
            // btnEmocional
            // 
            this.btnEmocional.BackColor = System.Drawing.Color.Transparent;
            this.btnEmocional.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmocional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmocional.Font = new System.Drawing.Font("HP Simplified Jpan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmocional.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEmocional.Image = global::FlowTime.Properties.Resources.calendarioIcono;
            this.btnEmocional.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmocional.Location = new System.Drawing.Point(0, 33);
            this.btnEmocional.Name = "btnEmocional";
            this.btnEmocional.Size = new System.Drawing.Size(209, 39);
            this.btnEmocional.TabIndex = 22;
            this.btnEmocional.Text = "Registro emocional";
            this.btnEmocional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmocional.UseVisualStyleBackColor = false;
            this.btnEmocional.Click += new System.EventHandler(this.btnEmocional_Click);
            this.btnEmocional.MouseEnter += new System.EventHandler(this.btnEmocional_MouseEnter);
            this.btnEmocional.MouseLeave += new System.EventHandler(this.btnEmocional_MouseLeave);
            // 
            // plTemas
            // 
            this.plTemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.plTemas.Controls.Add(this.btnDefecto);
            this.plTemas.Controls.Add(this.btnAmarillo);
            this.plTemas.Controls.Add(this.btnAzul);
            this.plTemas.Controls.Add(this.btnRojo);
            this.plTemas.Controls.Add(this.btnVerde);
            this.plTemas.Location = new System.Drawing.Point(0, 184);
            this.plTemas.Name = "plTemas";
            this.plTemas.Size = new System.Drawing.Size(210, 105);
            this.plTemas.TabIndex = 21;
            // 
            // btnDefecto
            // 
            this.btnDefecto.Image = ((System.Drawing.Image)(resources.GetObject("btnDefecto.Image")));
            this.btnDefecto.Location = new System.Drawing.Point(22, 63);
            this.btnDefecto.Name = "btnDefecto";
            this.btnDefecto.Size = new System.Drawing.Size(30, 31);
            this.btnDefecto.TabIndex = 25;
            this.btnDefecto.TabStop = false;
            this.btnDefecto.Click += new System.EventHandler(this.btnDefecto_Click);
            this.btnDefecto.MouseEnter += new System.EventHandler(this.btnDefecto_MouseEnter);
            this.btnDefecto.MouseLeave += new System.EventHandler(this.btnDefecto_MouseLeave);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.Image = ((System.Drawing.Image)(resources.GetObject("btnAmarillo.Image")));
            this.btnAmarillo.Location = new System.Drawing.Point(156, 21);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(30, 31);
            this.btnAmarillo.TabIndex = 24;
            this.btnAmarillo.TabStop = false;
            this.btnAmarillo.Click += new System.EventHandler(this.btnAmarillo_Click);
            this.btnAmarillo.MouseEnter += new System.EventHandler(this.btnAmarillo_MouseEnter);
            this.btnAmarillo.MouseLeave += new System.EventHandler(this.btnAmarillo_MouseLeave);
            // 
            // btnAzul
            // 
            this.btnAzul.Image = ((System.Drawing.Image)(resources.GetObject("btnAzul.Image")));
            this.btnAzul.Location = new System.Drawing.Point(111, 21);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(30, 31);
            this.btnAzul.TabIndex = 23;
            this.btnAzul.TabStop = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            this.btnAzul.MouseEnter += new System.EventHandler(this.btnAzul_MouseEnter);
            this.btnAzul.MouseLeave += new System.EventHandler(this.btnAzul_MouseLeave);
            // 
            // btnRojo
            // 
            this.btnRojo.Image = ((System.Drawing.Image)(resources.GetObject("btnRojo.Image")));
            this.btnRojo.Location = new System.Drawing.Point(66, 21);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(30, 31);
            this.btnRojo.TabIndex = 22;
            this.btnRojo.TabStop = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            this.btnRojo.MouseEnter += new System.EventHandler(this.btnRojo_MouseEnter);
            this.btnRojo.MouseLeave += new System.EventHandler(this.btnRojo_MouseLeave);
            // 
            // btnVerde
            // 
            this.btnVerde.Image = ((System.Drawing.Image)(resources.GetObject("btnVerde.Image")));
            this.btnVerde.Location = new System.Drawing.Point(22, 21);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(30, 31);
            this.btnVerde.TabIndex = 21;
            this.btnVerde.TabStop = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            this.btnVerde.MouseEnter += new System.EventHandler(this.btnVerde_MouseEnter);
            this.btnVerde.MouseLeave += new System.EventHandler(this.btnVerde_MouseLeave);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.btnEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("HP Simplified Jpan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstadisticas.Image = global::FlowTime.Properties.Resources.estadisticasIcono;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 89);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(209, 39);
            this.btnEstadisticas.TabIndex = 9;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            this.btnEstadisticas.MouseEnter += new System.EventHandler(this.btnEstadisticas_MouseEnter);
            this.btnEstadisticas.MouseLeave += new System.EventHandler(this.btnEstadisticas_MouseLeave);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("HP Simplified Jpan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfiguracion.Image = global::FlowTime.Properties.Resources.temacolorIcono;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfiguracion.Location = new System.Drawing.Point(0, 144);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(209, 39);
            this.btnConfiguracion.TabIndex = 10;
            this.btnConfiguracion.Text = "Temas";
            this.btnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            this.btnConfiguracion.MouseEnter += new System.EventHandler(this.btnConfiguracion_MouseEnter);
            this.btnConfiguracion.MouseLeave += new System.EventHandler(this.btnConfiguracion_MouseLeave);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("HP Simplified Jpan", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrarSesion.Image = global::FlowTime.Properties.Resources.cerrarSesionIcono;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 382);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(209, 39);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            this.btnCerrarSesion.MouseEnter += new System.EventHandler(this.btnCerrarSesion_MouseEnter);
            this.btnCerrarSesion.MouseLeave += new System.EventHandler(this.btnCerrarSesion_MouseLeave);
            // 
            // btnTutorial
            // 
            this.btnTutorial.BackColor = System.Drawing.Color.Transparent;
            this.btnTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutorial.Font = new System.Drawing.Font("HP Simplified Jpan", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutorial.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTutorial.Image = global::FlowTime.Properties.Resources.tutorialIcono;
            this.btnTutorial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTutorial.Location = new System.Drawing.Point(0, 269);
            this.btnTutorial.Name = "btnTutorial";
            this.btnTutorial.Size = new System.Drawing.Size(209, 39);
            this.btnTutorial.TabIndex = 11;
            this.btnTutorial.Text = "Tutorial";
            this.btnTutorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTutorial.UseVisualStyleBackColor = false;
            this.btnTutorial.Click += new System.EventHandler(this.btnTutorial_Click);
            this.btnTutorial.MouseEnter += new System.EventHandler(this.btnTutorial_MouseEnter);
            this.btnTutorial.MouseLeave += new System.EventHandler(this.btnTutorial_MouseLeave);
            // 
            // btnOpciones
            // 
            this.btnOpciones.BackColor = System.Drawing.Color.Transparent;
            this.btnOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpciones.BackgroundImage")));
            this.btnOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpciones.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpciones.Location = new System.Drawing.Point(892, 420);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(44, 43);
            this.btnOpciones.TabIndex = 15;
            this.btnOpciones.UseVisualStyleBackColor = false;
            this.btnOpciones.Click += new System.EventHandler(this.btnOpciones_Click);
            // 
            // btnPomodoro
            // 
            this.btnPomodoro.BackColor = System.Drawing.Color.Transparent;
            this.btnPomodoro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPomodoro.BackgroundImage")));
            this.btnPomodoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPomodoro.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomodoro.ForeColor = System.Drawing.Color.Transparent;
            this.btnPomodoro.Location = new System.Drawing.Point(579, 354);
            this.btnPomodoro.Margin = new System.Windows.Forms.Padding(2);
            this.btnPomodoro.Name = "btnPomodoro";
            this.btnPomodoro.Size = new System.Drawing.Size(51, 48);
            this.btnPomodoro.TabIndex = 0;
            this.btnPomodoro.UseVisualStyleBackColor = false;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnFlowTime
            // 
            this.btnFlowTime.BackColor = System.Drawing.Color.Transparent;
            this.btnFlowTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFlowTime.BackgroundImage")));
            this.btnFlowTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlowTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlowTime.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlowTime.ForeColor = System.Drawing.Color.Transparent;
            this.btnFlowTime.Location = new System.Drawing.Point(256, 354);
            this.btnFlowTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnFlowTime.Name = "btnFlowTime";
            this.btnFlowTime.Size = new System.Drawing.Size(51, 48);
            this.btnFlowTime.TabIndex = 0;
            this.btnFlowTime.UseVisualStyleBackColor = false;
            this.btnFlowTime.Click += new System.EventHandler(this.btnFlowTime_Click);
            // 
            // InterfazInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 475);
            this.Controls.Add(this.plOpciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPomodoro);
            this.Controls.Add(this.btnFlowTime);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterfazInicial";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfazInicial";
            this.Load += new System.EventHandler(this.InterfazInicial_Load);
            this.Click += new System.EventHandler(this.InterfazInicial_Click);
            this.plOpciones.ResumeLayout(false);
            this.plTemas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDefecto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFlowTime;
        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnTutorial;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Timer Entrada;
        private System.Windows.Forms.Timer Salida;
        private System.Windows.Forms.Timer Salida2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Timer tmrBarraOpcionesTransicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer SalidaEstadisticas;
        private System.Windows.Forms.Panel plOpciones;
        private System.Windows.Forms.Panel plTemas;
        private System.Windows.Forms.PictureBox btnAmarillo;
        private System.Windows.Forms.PictureBox btnAzul;
        private System.Windows.Forms.PictureBox btnRojo;
        private System.Windows.Forms.PictureBox btnVerde;
        private System.Windows.Forms.PictureBox btnDefecto;
        private System.Windows.Forms.Button btnEmocional;
    }
}