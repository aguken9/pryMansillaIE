namespace pryMansillaIE
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.temporizador1 = new System.Windows.Forms.Timer(this.components);
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lkRegistrate = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(169, 128);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(237, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(169, 165);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(237, 20);
            this.txtContraseña.TabIndex = 1;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblContra.Location = new System.Drawing.Point(52, 163);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(96, 20);
            this.lblContra.TabIndex = 3;
            this.lblContra.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsuario.Location = new System.Drawing.Point(52, 128);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(103, 228);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(219, 30);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // temporizador1
            // 
            this.temporizador1.Interval = 5000;
            this.temporizador1.Tick += new System.EventHandler(this.temporizador1_Tick);
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::pryMansillaIE.Properties.Resources.broker;
            this.pbImagen.Location = new System.Drawing.Point(56, 59);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(350, 48);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 6;
            this.pbImagen.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(135, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 26);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Ingrese sus Datos";
            // 
            // lkRegistrate
            // 
            this.lkRegistrate.AutoSize = true;
            this.lkRegistrate.Location = new System.Drawing.Point(53, 200);
            this.lkRegistrate.Name = "lkRegistrate";
            this.lkRegistrate.Size = new System.Drawing.Size(149, 13);
            this.lkRegistrate.TabIndex = 8;
            this.lkRegistrate.TabStop = true;
            this.lkRegistrate.Text = "¿No tenes cuenta? Registrate";
            this.lkRegistrate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkRegistrate_LinkClicked);
            // 
            // frmInicioSesion
            // 
            this.AcceptButton = this.btnIngresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 270);
            this.Controls.Add(this.lkRegistrate);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Timer temporizador1;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.LinkLabel lkRegistrate;
    }
}