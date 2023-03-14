namespace wLinea
{
    partial class frmDibujarLinea
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
            this.lblXInicial = new System.Windows.Forms.Label();
            this.lblXFinal = new System.Windows.Forms.Label();
            this.lblYInicial = new System.Windows.Forms.Label();
            this.lblYFinal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXInicial = new System.Windows.Forms.TextBox();
            this.txtYInicial = new System.Windows.Forms.TextBox();
            this.txtXFinal = new System.Windows.Forms.TextBox();
            this.txtYFinal = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnDibujarLinea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblXInicial
            // 
            this.lblXInicial.AutoSize = true;
            this.lblXInicial.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXInicial.Location = new System.Drawing.Point(63, 70);
            this.lblXInicial.Name = "lblXInicial";
            this.lblXInicial.Size = new System.Drawing.Size(61, 15);
            this.lblXInicial.TabIndex = 0;
            this.lblXInicial.Text = "X Inicial";
            // 
            // lblXFinal
            // 
            this.lblXFinal.AutoSize = true;
            this.lblXFinal.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXFinal.Location = new System.Drawing.Point(63, 161);
            this.lblXFinal.Name = "lblXFinal";
            this.lblXFinal.Size = new System.Drawing.Size(52, 15);
            this.lblXFinal.TabIndex = 1;
            this.lblXFinal.Text = "X Final";
            // 
            // lblYInicial
            // 
            this.lblYInicial.AutoSize = true;
            this.lblYInicial.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYInicial.Location = new System.Drawing.Point(209, 70);
            this.lblYInicial.Name = "lblYInicial";
            this.lblYInicial.Size = new System.Drawing.Size(60, 15);
            this.lblYInicial.TabIndex = 2;
            this.lblYInicial.Text = "Y Inicial";
            // 
            // lblYFinal
            // 
            this.lblYFinal.AutoSize = true;
            this.lblYFinal.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYFinal.Location = new System.Drawing.Point(209, 161);
            this.lblYFinal.Name = "lblYFinal";
            this.lblYFinal.Size = new System.Drawing.Size(51, 15);
            this.lblYFinal.TabIndex = 3;
            this.lblYFinal.Text = "Y Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de Líneas ";
            // 
            // txtXInicial
            // 
            this.txtXInicial.Location = new System.Drawing.Point(127, 65);
            this.txtXInicial.Name = "txtXInicial";
            this.txtXInicial.Size = new System.Drawing.Size(75, 20);
            this.txtXInicial.TabIndex = 5;
            // 
            // txtYInicial
            // 
            this.txtYInicial.Location = new System.Drawing.Point(274, 65);
            this.txtYInicial.Name = "txtYInicial";
            this.txtYInicial.Size = new System.Drawing.Size(75, 20);
            this.txtYInicial.TabIndex = 6;
            // 
            // txtXFinal
            // 
            this.txtXFinal.Location = new System.Drawing.Point(128, 156);
            this.txtXFinal.Name = "txtXFinal";
            this.txtXFinal.Size = new System.Drawing.Size(75, 20);
            this.txtXFinal.TabIndex = 7;
            // 
            // txtYFinal
            // 
            this.txtYFinal.Location = new System.Drawing.Point(274, 156);
            this.txtYFinal.Name = "txtYFinal";
            this.txtYFinal.Size = new System.Drawing.Size(75, 20);
            this.txtYFinal.TabIndex = 8;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(187, 269);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(51, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // btnDibujarLinea
            // 
            this.btnDibujarLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDibujarLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujarLinea.Location = new System.Drawing.Point(156, 339);
            this.btnDibujarLinea.Name = "btnDibujarLinea";
            this.btnDibujarLinea.Size = new System.Drawing.Size(113, 33);
            this.btnDibujarLinea.TabIndex = 10;
            this.btnDibujarLinea.Text = "Dibujar Línea";
            this.btnDibujarLinea.UseVisualStyleBackColor = false;
            this.btnDibujarLinea.Click += new System.EventHandler(this.btnDibujarLinea_Click);
            // 
            // frmDibujarLinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.btnDibujarLinea);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtYFinal);
            this.Controls.Add(this.txtXFinal);
            this.Controls.Add(this.txtYInicial);
            this.Controls.Add(this.txtXInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblYFinal);
            this.Controls.Add(this.lblYInicial);
            this.Controls.Add(this.lblXFinal);
            this.Controls.Add(this.lblXInicial);
            this.Name = "frmDibujarLinea";
            this.Text = "Dibujar Línea ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXInicial;
        private System.Windows.Forms.Label lblXFinal;
        private System.Windows.Forms.Label lblYInicial;
        private System.Windows.Forms.Label lblYFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXInicial;
        private System.Windows.Forms.TextBox txtYInicial;
        private System.Windows.Forms.TextBox txtXFinal;
        private System.Windows.Forms.TextBox txtYFinal;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnDibujarLinea;
    }
}

