namespace pryMansillaIE
{
    partial class frmRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarse));
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.plPanel = new System.Windows.Forms.Panel();
            this.pbFirma = new System.Windows.Forms.PictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblFirma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.pbMostrarF = new System.Windows.Forms.PictureBox();
            this.grbMostrar = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbDatos.SuspendLayout();
            this.plPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarF)).BeginInit();
            this.grbMostrar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.plPanel);
            this.grbDatos.Controls.Add(this.btnRegistrar);
            this.grbDatos.Controls.Add(this.lblFirma);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.lblUsuario);
            this.grbDatos.Controls.Add(this.txtContraseña);
            this.grbDatos.Controls.Add(this.txtUsuario);
            this.grbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbDatos.Location = new System.Drawing.Point(8, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(412, 357);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Ingrese sus Datos";
            // 
            // plPanel
            // 
            this.plPanel.BackColor = System.Drawing.SystemColors.Control;
            this.plPanel.Controls.Add(this.pbFirma);
            this.plPanel.Location = new System.Drawing.Point(120, 161);
            this.plPanel.Name = "plPanel";
            this.plPanel.Size = new System.Drawing.Size(224, 129);
            this.plPanel.TabIndex = 6;
            // 
            // pbFirma
            // 
            this.pbFirma.Location = new System.Drawing.Point(3, 3);
            this.pbFirma.Name = "pbFirma";
            this.pbFirma.Size = new System.Drawing.Size(218, 123);
            this.pbFirma.TabIndex = 5;
            this.pbFirma.TabStop = false;
            this.pbFirma.Paint += new System.Windows.Forms.PaintEventHandler(this.pbFirma_Paint);
            this.pbFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pbFirma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbFirma_MouseMove);
            this.pbFirma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbFirma_MouseUp);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegistrar.Location = new System.Drawing.Point(167, 305);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 36);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirma.Location = new System.Drawing.Point(18, 161);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(87, 20);
            this.lblFirma.TabIndex = 4;
            this.lblFirma.Text = "Firme aquí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsuario.Location = new System.Drawing.Point(18, 49);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = " Usuario:";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(120, 103);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(190, 23);
            this.txtContraseña.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(120, 51);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 23);
            this.txtUsuario.TabIndex = 0;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(34, 39);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(267, 21);
            this.cmbUsuarios.TabIndex = 2;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pbMostrarF
            // 
            this.pbMostrarF.Location = new System.Drawing.Point(14, 10);
            this.pbMostrarF.Name = "pbMostrarF";
            this.pbMostrarF.Size = new System.Drawing.Size(267, 173);
            this.pbMostrarF.TabIndex = 3;
            this.pbMostrarF.TabStop = false;
            // 
            // grbMostrar
            // 
            this.grbMostrar.Controls.Add(this.panel1);
            this.grbMostrar.Controls.Add(this.cmbUsuarios);
            this.grbMostrar.Location = new System.Drawing.Point(458, 22);
            this.grbMostrar.Name = "grbMostrar";
            this.grbMostrar.Size = new System.Drawing.Size(335, 347);
            this.grbMostrar.TabIndex = 4;
            this.grbMostrar.TabStop = false;
            this.grbMostrar.Text = "Elija la firma que desea ver:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pbMostrarF);
            this.panel1.Location = new System.Drawing.Point(20, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 196);
            this.panel1.TabIndex = 4;
            // 
            // frmRegistrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 392);
            this.Controls.Add(this.grbMostrar);
            this.Controls.Add(this.grbDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuarios";
            this.Load += new System.EventHandler(this.frmRegistrarse_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.plPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMostrarF)).EndInit();
            this.grbMostrar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.PictureBox pbFirma;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Panel plPanel;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.PictureBox pbMostrarF;
        private System.Windows.Forms.GroupBox grbMostrar;
        private System.Windows.Forms.Panel panel1;
    }
}