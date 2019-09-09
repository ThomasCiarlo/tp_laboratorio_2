namespace tp1
{
    partial class FromCalculadora
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
            this.bntConverBinario = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConverDecimal = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnOperar = new System.Windows.Forms.Button();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbOperador = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bntConverBinario
            // 
            this.bntConverBinario.Location = new System.Drawing.Point(12, 214);
            this.bntConverBinario.Name = "bntConverBinario";
            this.bntConverBinario.Size = new System.Drawing.Size(262, 40);
            this.bntConverBinario.TabIndex = 2;
            this.bntConverBinario.Text = "Convertir a Binario";
            this.bntConverBinario.UseVisualStyleBackColor = true;
            this.bntConverBinario.Click += new System.EventHandler(this.BntConverBinario_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(196, 137);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(170, 55);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnConverDecimal
            // 
            this.btnConverDecimal.Location = new System.Drawing.Point(280, 214);
            this.btnConverDecimal.Name = "btnConverDecimal";
            this.btnConverDecimal.Size = new System.Drawing.Size(269, 40);
            this.btnConverDecimal.TabIndex = 7;
            this.btnConverDecimal.Text = "Convertir a Decimal";
            this.btnConverDecimal.UseVisualStyleBackColor = true;
            this.btnConverDecimal.Click += new System.EventHandler(this.BtnConverDecimal_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(372, 137);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(177, 55);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(12, 137);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(178, 55);
            this.btnOperar.TabIndex = 9;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.BtnOperar_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.Color.White;
            this.txtNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(386, 59);
            this.txtNumero2.Multiline = true;
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(146, 59);
            this.txtNumero2.TabIndex = 11;
            this.txtNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero2.TextChanged += new System.EventHandler(this.TxtNumero2_TextChanged);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtNumero1.Location = new System.Drawing.Point(29, 59);
            this.txtNumero1.Multiline = true;
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(146, 59);
            this.txtNumero1.TabIndex = 12;
            this.txtNumero1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero1.TextChanged += new System.EventHandler(this.TxtNumero1_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(386, 9);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblResultado.Size = new System.Drawing.Size(0, 32);
            this.lblResultado.TabIndex = 13;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbOperador
            // 
            this.cmbOperador.DropDownHeight = 120;
            this.cmbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperador.FormattingEnabled = true;
            this.cmbOperador.IntegralHeight = false;
            this.cmbOperador.ItemHeight = 42;
            this.cmbOperador.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cmbOperador.Location = new System.Drawing.Point(221, 68);
            this.cmbOperador.Name = "cmbOperador";
            this.cmbOperador.Size = new System.Drawing.Size(121, 50);
            this.cmbOperador.TabIndex = 14;
            // 
            // FromCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 291);
            this.Controls.Add(this.cmbOperador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnConverDecimal);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.bntConverBinario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FromCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Thomas ciarlo del curso 2°C";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.Load += new System.EventHandler(this.FromCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntConverBinario;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConverDecimal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbOperador;
    }
}

