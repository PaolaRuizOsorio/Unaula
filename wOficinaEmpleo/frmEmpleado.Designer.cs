namespace wOficinaEmpleo
{
    partial class frmEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblNivelEstudio = new System.Windows.Forms.Label();
            this.lblTituloObtenido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.datFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTituloObtenido = new System.Windows.Forms.TextBox();
            this.cboNivelEstudio = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtgEmpleado = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(58, 162);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(406, 162);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 21);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDocumento.Location = new System.Drawing.Point(58, 59);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(207, 21);
            this.lblNumeroDocumento.TabIndex = 3;
            this.lblNumeroDocumento.Text = "Número de Documento";
            // 
            // lblNivelEstudio
            // 
            this.lblNivelEstudio.AutoSize = true;
            this.lblNivelEstudio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelEstudio.Location = new System.Drawing.Point(58, 394);
            this.lblNivelEstudio.Name = "lblNivelEstudio";
            this.lblNivelEstudio.Size = new System.Drawing.Size(143, 21);
            this.lblNivelEstudio.TabIndex = 5;
            this.lblNivelEstudio.Text = "Nivel de Estudio";
            // 
            // lblTituloObtenido
            // 
            this.lblTituloObtenido.AutoSize = true;
            this.lblTituloObtenido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloObtenido.Location = new System.Drawing.Point(328, 394);
            this.lblTituloObtenido.Name = "lblTituloObtenido";
            this.lblTituloObtenido.Size = new System.Drawing.Size(138, 21);
            this.lblTituloObtenido.TabIndex = 6;
            this.lblTituloObtenido.Text = "Título Obtenido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(878, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 7;
            // 
            // groupBoxDatosEmpleado
            // 
            this.groupBoxDatosEmpleado.Controls.Add(this.lblFechaNacimiento);
            this.groupBoxDatosEmpleado.Controls.Add(this.datFechaDeNacimiento);
            this.groupBoxDatosEmpleado.Controls.Add(this.cboTipoDocumento);
            this.groupBoxDatosEmpleado.Controls.Add(this.lblTipoDocumento);
            this.groupBoxDatosEmpleado.Controls.Add(this.txtNumeroDocumento);
            this.groupBoxDatosEmpleado.Controls.Add(this.txtApellido);
            this.groupBoxDatosEmpleado.Controls.Add(this.txtTituloObtenido);
            this.groupBoxDatosEmpleado.Controls.Add(this.cboNivelEstudio);
            this.groupBoxDatosEmpleado.Controls.Add(this.txtNombre);
            this.groupBoxDatosEmpleado.Controls.Add(this.label8);
            this.groupBoxDatosEmpleado.Controls.Add(this.lblTituloObtenido);
            this.groupBoxDatosEmpleado.Controls.Add(this.lblNivelEstudio);
            this.groupBoxDatosEmpleado.Controls.Add(this.lblNumeroDocumento);
            this.groupBoxDatosEmpleado.Controls.Add(this.lblApellido);
            this.groupBoxDatosEmpleado.Controls.Add(this.lblNombre);
            this.groupBoxDatosEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosEmpleado.Location = new System.Drawing.Point(131, 40);
            this.groupBoxDatosEmpleado.Name = "groupBoxDatosEmpleado";
            this.groupBoxDatosEmpleado.Size = new System.Drawing.Size(834, 501);
            this.groupBoxDatosEmpleado.TabIndex = 11;
            this.groupBoxDatosEmpleado.TabStop = false;
            this.groupBoxDatosEmpleado.Text = "Datos Empleado ";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(58, 270);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(191, 21);
            this.lblFechaNacimiento.TabIndex = 25;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // datFechaDeNacimiento
            // 
            this.datFechaDeNacimiento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datFechaDeNacimiento.Location = new System.Drawing.Point(62, 313);
            this.datFechaDeNacimiento.Name = "datFechaDeNacimiento";
            this.datFechaDeNacimiento.Size = new System.Drawing.Size(422, 28);
            this.datFechaDeNacimiento.TabIndex = 24;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "T.I",
            "C.C",
            "C.E",
            "PASAPORTE"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(410, 95);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(233, 29);
            this.cboTipoDocumento.TabIndex = 23;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.Location = new System.Drawing.Point(406, 59);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(176, 21);
            this.lblTipoDocumento.TabIndex = 22;
            this.lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocumento.Location = new System.Drawing.Point(62, 98);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(233, 28);
            this.txtNumeroDocumento.TabIndex = 21;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(410, 197);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(233, 28);
            this.txtApellido.TabIndex = 20;
            // 
            // txtTituloObtenido
            // 
            this.txtTituloObtenido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloObtenido.Location = new System.Drawing.Point(332, 441);
            this.txtTituloObtenido.Name = "txtTituloObtenido";
            this.txtTituloObtenido.Size = new System.Drawing.Size(426, 28);
            this.txtTituloObtenido.TabIndex = 19;
            // 
            // cboNivelEstudio
            // 
            this.cboNivelEstudio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNivelEstudio.FormattingEnabled = true;
            this.cboNivelEstudio.Items.AddRange(new object[] {
            "Bachiller ",
            "Tecnico ",
            "Tecnologo ",
            "Prosgrado "});
            this.cboNivelEstudio.Location = new System.Drawing.Point(61, 440);
            this.cboNivelEstudio.Name = "cboNivelEstudio";
            this.cboNivelEstudio.Size = new System.Drawing.Size(233, 29);
            this.cboNivelEstudio.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(61, 197);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(233, 28);
            this.txtNombre.TabIndex = 11;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(153, 578);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(131, 40);
            this.btnInsertar.TabIndex = 12;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(315, 578);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(131, 40);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(484, 578);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(131, 40);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(654, 578);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 40);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(812, 578);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 40);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dtgEmpleado
            // 
            this.dtgEmpleado.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dtgEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleado.Location = new System.Drawing.Point(68, 640);
            this.dtgEmpleado.Name = "dtgEmpleado";
            this.dtgEmpleado.RowHeadersWidth = 51;
            this.dtgEmpleado.RowTemplate.Height = 24;
            this.dtgEmpleado.Size = new System.Drawing.Size(1244, 251);
            this.dtgEmpleado.TabIndex = 17;
            this.dtgEmpleado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgEmpleado_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1015, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1022, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Es un placer que seas parte ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1010, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "de nuestro equipo de trabajo ";
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1407, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgEmpleado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.groupBoxDatosEmpleado);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.groupBoxDatosEmpleado.ResumeLayout(false);
            this.groupBoxDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblNivelEstudio;
        private System.Windows.Forms.Label lblTituloObtenido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxDatosEmpleado;
        private System.Windows.Forms.ComboBox cboNivelEstudio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTituloObtenido;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dtgEmpleado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.DateTimePicker datFechaDeNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
    }
}