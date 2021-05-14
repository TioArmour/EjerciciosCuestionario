
namespace Presentacion
{
    partial class RegistroNotas
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
            this.gbDatosEstudiantes = new System.Windows.Forms.GroupBox();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbNotas = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSAGA = new System.Windows.Forms.TextBox();
            this.txtEvaluacion = new System.Windows.Forms.TextBox();
            this.txtExamen = new System.Windows.Forms.TextBox();
            this.lblSAGA = new System.Windows.Forms.Label();
            this.lblEvaluacion = new System.Windows.Forms.Label();
            this.lblExamen = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.gbDatosEstudiantes.SuspendLayout();
            this.gbNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosEstudiantes
            // 
            this.gbDatosEstudiantes.Controls.Add(this.txtAsignatura);
            this.gbDatosEstudiantes.Controls.Add(this.lblAsignatura);
            this.gbDatosEstudiantes.Controls.Add(this.cbPeriodo);
            this.gbDatosEstudiantes.Controls.Add(this.btnContinuar);
            this.gbDatosEstudiantes.Controls.Add(this.cbSemestre);
            this.gbDatosEstudiantes.Controls.Add(this.txtCarrera);
            this.gbDatosEstudiantes.Controls.Add(this.txtNombre);
            this.gbDatosEstudiantes.Controls.Add(this.lblPeriodo);
            this.gbDatosEstudiantes.Controls.Add(this.lblSemestre);
            this.gbDatosEstudiantes.Controls.Add(this.lblCarrera);
            this.gbDatosEstudiantes.Controls.Add(this.lblNombre);
            this.gbDatosEstudiantes.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEstudiantes.Location = new System.Drawing.Point(16, 54);
            this.gbDatosEstudiantes.Margin = new System.Windows.Forms.Padding(4);
            this.gbDatosEstudiantes.Name = "gbDatosEstudiantes";
            this.gbDatosEstudiantes.Padding = new System.Windows.Forms.Padding(4);
            this.gbDatosEstudiantes.Size = new System.Drawing.Size(616, 327);
            this.gbDatosEstudiantes.TabIndex = 1;
            this.gbDatosEstudiantes.TabStop = false;
            this.gbDatosEstudiantes.Text = "DatosEstudiante";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "PRIMER PARCIAL",
            "SEGUNDO PARCIAL",
            "EXAMEN FINAL"});
            this.cbPeriodo.Location = new System.Drawing.Point(236, 188);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(360, 29);
            this.cbPeriodo.TabIndex = 10;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(236, 280);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(360, 29);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // cbSemestre
            // 
            this.cbSemestre.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "PRIMERO",
            "SEGUNDO",
            "TERCERO",
            "CUARTO",
            "QUINTO",
            "SEXTO",
            "SEPTIMO",
            "OCTAVO",
            "NOVENO",
            "DECIMO"});
            this.cbSemestre.Location = new System.Drawing.Point(236, 143);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(360, 29);
            this.cbSemestre.TabIndex = 8;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarrera.Location = new System.Drawing.Point(236, 98);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(360, 27);
            this.txtCarrera.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(236, 53);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 27);
            this.txtNombre.TabIndex = 4;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(6, 190);
            this.lblPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(219, 21);
            this.lblPeriodo.TabIndex = 3;
            this.lblPeriodo.Text = "Periodo de Evaluación:";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(6, 145);
            this.lblSemestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(93, 21);
            this.lblSemestre.TabIndex = 2;
            this.lblSemestre.Text = "Semestre";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(6, 100);
            this.lblCarrera.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(89, 21);
            this.lblCarrera.TabIndex = 1;
            this.lblCarrera.Text = "Carrera:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 55);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(172, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // gbNotas
            // 
            this.gbNotas.Controls.Add(this.btnGuardar);
            this.gbNotas.Controls.Add(this.txtSAGA);
            this.gbNotas.Controls.Add(this.txtEvaluacion);
            this.gbNotas.Controls.Add(this.txtExamen);
            this.gbNotas.Controls.Add(this.lblSAGA);
            this.gbNotas.Controls.Add(this.lblEvaluacion);
            this.gbNotas.Controls.Add(this.lblExamen);
            this.gbNotas.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNotas.Location = new System.Drawing.Point(13, 389);
            this.gbNotas.Margin = new System.Windows.Forms.Padding(4);
            this.gbNotas.Name = "gbNotas";
            this.gbNotas.Padding = new System.Windows.Forms.Padding(4);
            this.gbNotas.Size = new System.Drawing.Size(617, 180);
            this.gbNotas.TabIndex = 2;
            this.gbNotas.TabStop = false;
            this.gbNotas.Text = "Notas del Estudiante";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(525, 576);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 27);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(463, 52);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 27);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSAGA
            // 
            this.txtSAGA.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSAGA.Location = new System.Drawing.Point(237, 142);
            this.txtSAGA.Margin = new System.Windows.Forms.Padding(4);
            this.txtSAGA.Name = "txtSAGA";
            this.txtSAGA.Size = new System.Drawing.Size(124, 27);
            this.txtSAGA.TabIndex = 14;
            // 
            // txtEvaluacion
            // 
            this.txtEvaluacion.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvaluacion.Location = new System.Drawing.Point(237, 97);
            this.txtEvaluacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtEvaluacion.Name = "txtEvaluacion";
            this.txtEvaluacion.Size = new System.Drawing.Size(124, 27);
            this.txtEvaluacion.TabIndex = 13;
            // 
            // txtExamen
            // 
            this.txtExamen.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamen.Location = new System.Drawing.Point(237, 52);
            this.txtExamen.Margin = new System.Windows.Forms.Padding(4);
            this.txtExamen.Name = "txtExamen";
            this.txtExamen.Size = new System.Drawing.Size(124, 27);
            this.txtExamen.TabIndex = 12;
            // 
            // lblSAGA
            // 
            this.lblSAGA.AutoSize = true;
            this.lblSAGA.Location = new System.Drawing.Point(7, 145);
            this.lblSAGA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSAGA.Name = "lblSAGA";
            this.lblSAGA.Size = new System.Drawing.Size(113, 21);
            this.lblSAGA.TabIndex = 11;
            this.lblSAGA.Text = "Nota SAGA:";
            // 
            // lblEvaluacion
            // 
            this.lblEvaluacion.AutoSize = true;
            this.lblEvaluacion.Location = new System.Drawing.Point(7, 100);
            this.lblEvaluacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvaluacion.Name = "lblEvaluacion";
            this.lblEvaluacion.Size = new System.Drawing.Size(206, 21);
            this.lblEvaluacion.TabIndex = 10;
            this.lblEvaluacion.Text = "Evaluación Continua:";
            // 
            // lblExamen
            // 
            this.lblExamen.AutoSize = true;
            this.lblExamen.Location = new System.Drawing.Point(7, 55);
            this.lblExamen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamen.Name = "lblExamen";
            this.lblExamen.Size = new System.Drawing.Size(89, 21);
            this.lblExamen.TabIndex = 9;
            this.lblExamen.Text = "Examen:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(248, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 21);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Registro de Notas";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(6, 238);
            this.lblAsignatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(118, 21);
            this.lblAsignatura.TabIndex = 11;
            this.lblAsignatura.Text = "Asignatura:";
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsignatura.Location = new System.Drawing.Point(236, 235);
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.Size = new System.Drawing.Size(360, 27);
            this.txtAsignatura.TabIndex = 12;
            // 
            // RegistroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 610);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbNotas);
            this.Controls.Add(this.gbDatosEstudiantes);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistroNotas";
            this.Text = "Registro de Notas ";
            this.Load += new System.EventHandler(this.RegistroNotas_Load);
            this.gbDatosEstudiantes.ResumeLayout(false);
            this.gbDatosEstudiantes.PerformLayout();
            this.gbNotas.ResumeLayout(false);
            this.gbNotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosEstudiantes;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbNotas;
        private System.Windows.Forms.TextBox txtSAGA;
        private System.Windows.Forms.TextBox txtEvaluacion;
        private System.Windows.Forms.TextBox txtExamen;
        private System.Windows.Forms.Label lblSAGA;
        private System.Windows.Forms.Label lblEvaluacion;
        private System.Windows.Forms.Label lblExamen;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.TextBox txtAsignatura;
    }
}

