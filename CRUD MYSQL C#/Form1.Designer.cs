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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbalumno = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbuscarapellido = new System.Windows.Forms.TextBox();
            this.txtbuscarnombre = new System.Windows.Forms.TextBox();
            this.lblbuscarnombre = new System.Windows.Forms.Label();
            this.lblbuscarapellido = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.gbalumno, "gbalumno");
            this.gbalumno.Controls.Add(this.btnbuscar);
            this.gbalumno.Controls.Add(this.txtbuscarapellido);
            this.gbalumno.Controls.Add(this.txtbuscarnombre);
            this.gbalumno.Controls.Add(this.lblbuscarnombre);
            this.gbalumno.Controls.Add(this.lblbuscarapellido);
            this.gbalumno.Controls.Add(this.btnmodificar);
            this.gbalumno.Controls.Add(this.btneliminar);
            this.gbalumno.Controls.Add(this.btnguardar);
            this.gbalumno.Controls.Add(this.dgvalumnos);
            this.gbalumno.Controls.Add(this.txtnombres);
            this.gbalumno.Controls.Add(this.txtapellido);
            this.gbalumno.Controls.Add(this.txtid);
            this.gbalumno.Controls.Add(this.lblnombres);
            this.gbalumno.Controls.Add(this.lblapellido);
            this.gbalumno.Controls.Add(this.lblid);
            this.gbalumno.Name = "gbalumno";
            this.gbalumno.TabStop = false;
            // 
            // btnbuscar
            // 
            resources.ApplyResources(this.btnbuscar, "btnbuscar");
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtbuscarapellido
            // 
            resources.ApplyResources(this.txtbuscarapellido, "txtbuscarapellido");
            this.txtbuscarapellido.Name = "txtbuscarapellido";
            // 
            // txtbuscarnombre
            // 
            resources.ApplyResources(this.txtbuscarnombre, "txtbuscarnombre");
            this.txtbuscarnombre.Name = "txtbuscarnombre";
            this.txtbuscarnombre.TextChanged += new System.EventHandler(this.txtbuscarnombre_TextChanged);
            // 
            // lblbuscarnombre
            // 
            resources.ApplyResources(this.lblbuscarnombre, "lblbuscarnombre");
            this.lblbuscarnombre.Name = "lblbuscarnombre";
            // 
            // lblbuscarapellido
            // 
            resources.ApplyResources(this.lblbuscarapellido, "lblbuscarapellido");
            this.lblbuscarapellido.Name = "lblbuscarapellido";
            // 
            // btnmodificar
            // 
            resources.ApplyResources(this.btnmodificar, "btnmodificar");
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            resources.ApplyResources(this.btneliminar, "btneliminar");
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            resources.ApplyResources(this.btnguardar, "btnguardar");
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvalumnos
            // 
            resources.ApplyResources(this.dgvalumnos, "dgvalumnos");
            this.dgvalumnos.AllowUserToAddRows = false;
            this.dgvalumnos.AllowUserToDeleteRows = false;
            this.dgvalumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalumnos.Name = "dgvalumnos";
            this.dgvalumnos.ReadOnly = true;
            this.dgvalumnos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvalumnos_CellDoubleClick);
            // 
            // txtnombres
            // 
            resources.ApplyResources(this.txtnombres, "txtnombres");
            this.txtnombres.Name = "txtnombres";
            // 
            // txtapellido
            // 
            resources.ApplyResources(this.txtapellido, "txtapellido");
            this.txtapellido.Name = "txtapellido";
            // 
            // txtid
            // 
            resources.ApplyResources(this.txtid, "txtid");
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            // 
            // lblnombres
            // 
            resources.ApplyResources(this.lblnombres, "lblnombres");
            this.lblnombres.Name = "lblnombres";
            // 
            // lblapellido
            // 
            resources.ApplyResources(this.lblapellido, "lblapellido");
            this.lblapellido.Name = "lblapellido";
            // 
            // lblid
            // 
            resources.ApplyResources(this.lblid, "lblid");
            this.lblid.Name = "lblid";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbalumno);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.DataGridView dgvalumnos;
        private System.Windows.Forms.Label lblbuscarnombre;
        private System.Windows.Forms.Label lblbuscarapellido;
        private System.Windows.Forms.TextBox txtbuscarapellido;
        private System.Windows.Forms.TextBox txtbuscarnombre;
        private System.Windows.Forms.Button btnbuscar;
    }
}

