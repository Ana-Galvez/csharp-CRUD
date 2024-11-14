namespace CRUD_MYSQL_C_
{
    partial class Form1
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
            this.gbalumno = new System.Windows.Forms.GroupBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnprueba = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvalumnos = new System.Windows.Forms.DataGridView();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblnombres = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.gbalumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbalumno
            // 
            this.gbalumno.Controls.Add(this.btnmodificar);
            this.gbalumno.Controls.Add(this.btneliminar);
            this.gbalumno.Controls.Add(this.btnprueba);
            this.gbalumno.Controls.Add(this.btnguardar);
            this.gbalumno.Controls.Add(this.dgvalumnos);
            this.gbalumno.Controls.Add(this.txtnombres);
            this.gbalumno.Controls.Add(this.txtapellido);
            this.gbalumno.Controls.Add(this.txtid);
            this.gbalumno.Controls.Add(this.lblnombres);
            this.gbalumno.Controls.Add(this.lblapellido);
            this.gbalumno.Controls.Add(this.lblid);
            this.gbalumno.Location = new System.Drawing.Point(81, 12);
            this.gbalumno.Name = "gbalumno";
            this.gbalumno.Size = new System.Drawing.Size(824, 424);
            this.gbalumno.TabIndex = 0;
            this.gbalumno.TabStop = false;
            this.gbalumno.Text = "Datos del Alumno";
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(49, 265);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(130, 23);
            this.btnmodificar.TabIndex = 10;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(227, 265);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(130, 23);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnprueba
            // 
            this.btnprueba.Location = new System.Drawing.Point(167, 344);
            this.btnprueba.Name = "btnprueba";
            this.btnprueba.Size = new System.Drawing.Size(75, 23);
            this.btnprueba.TabIndex = 8;
            this.btnprueba.Text = "Prueba";
            this.btnprueba.UseVisualStyleBackColor = true;
            this.btnprueba.Click += new System.EventHandler(this.btnprueba_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(46, 213);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(311, 23);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // dgvalumnos
            // 
            this.dgvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalumnos.Location = new System.Drawing.Point(421, 22);
            this.dgvalumnos.Name = "dgvalumnos";
            this.dgvalumnos.Size = new System.Drawing.Size(397, 384);
            this.dgvalumnos.TabIndex = 6;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(109, 107);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(277, 20);
            this.txtnombres.TabIndex = 5;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(109, 154);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(277, 20);
            this.txtapellido.TabIndex = 4;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(109, 59);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(277, 20);
            this.txtid.TabIndex = 3;
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(18, 107);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(49, 13);
            this.lblnombres.TabIndex = 2;
            this.lblnombres.Text = "Nombres";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(18, 157);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(44, 13);
            this.lblapellido.TabIndex = 1;
            this.lblapellido.Text = "Apellido";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(18, 59);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(56, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID Alumno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.gbalumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbalumno.ResumeLayout(false);
            this.gbalumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbalumno;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnprueba;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvalumnos;
    }
}

