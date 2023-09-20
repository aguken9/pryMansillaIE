
namespace pryMansillaIE
{
    partial class frmRegistroProveedores
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbCuadro = new System.Windows.Forms.GroupBox();
            this.cmbJuzgado = new System.Windows.Forms.ComboBox();
            this.cmbLiquidador = new System.Windows.Forms.ComboBox();
            this.mskExpediente = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblLiquidador = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.cmbJurisdiccion = new System.Windows.Forms.ComboBox();
            this.grbCuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 356);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(111, 356);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(217, 356);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(309, 356);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // grbCuadro
            // 
            this.grbCuadro.Controls.Add(this.cmbJurisdiccion);
            this.grbCuadro.Controls.Add(this.lblJurisdiccion);
            this.grbCuadro.Controls.Add(this.cmbJuzgado);
            this.grbCuadro.Controls.Add(this.cmbLiquidador);
            this.grbCuadro.Controls.Add(this.mskExpediente);
            this.grbCuadro.Controls.Add(this.txtDireccion);
            this.grbCuadro.Controls.Add(this.txtApertura);
            this.grbCuadro.Controls.Add(this.txtEntidad);
            this.grbCuadro.Controls.Add(this.txtNumero);
            this.grbCuadro.Controls.Add(this.lblLiquidador);
            this.grbCuadro.Controls.Add(this.lblDireccion);
            this.grbCuadro.Controls.Add(this.lblJuzgado);
            this.grbCuadro.Controls.Add(this.lblExpediente);
            this.grbCuadro.Controls.Add(this.lblApertura);
            this.grbCuadro.Controls.Add(this.lblEntidad);
            this.grbCuadro.Controls.Add(this.lblNumero);
            this.grbCuadro.Location = new System.Drawing.Point(12, 12);
            this.grbCuadro.Name = "grbCuadro";
            this.grbCuadro.Size = new System.Drawing.Size(372, 322);
            this.grbCuadro.TabIndex = 18;
            this.grbCuadro.TabStop = false;
            this.grbCuadro.Text = "Datos";
            // 
            // cmbJuzgado
            // 
            this.cmbJuzgado.FormattingEnabled = true;
            this.cmbJuzgado.Location = new System.Drawing.Point(205, 199);
            this.cmbJuzgado.Name = "cmbJuzgado";
            this.cmbJuzgado.Size = new System.Drawing.Size(121, 21);
            this.cmbJuzgado.TabIndex = 29;
            this.cmbJuzgado.SelectedIndexChanged += new System.EventHandler(this.cmbJuzgado_SelectedIndexChanged);
            // 
            // cmbLiquidador
            // 
            this.cmbLiquidador.FormattingEnabled = true;
            this.cmbLiquidador.Location = new System.Drawing.Point(205, 283);
            this.cmbLiquidador.Name = "cmbLiquidador";
            this.cmbLiquidador.Size = new System.Drawing.Size(121, 21);
            this.cmbLiquidador.TabIndex = 28;
            // 
            // mskExpediente
            // 
            this.mskExpediente.Location = new System.Drawing.Point(205, 166);
            this.mskExpediente.Name = "mskExpediente";
            this.mskExpediente.Size = new System.Drawing.Size(121, 20);
            this.mskExpediente.TabIndex = 19;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(205, 248);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 26;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(205, 126);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(121, 20);
            this.txtApertura.TabIndex = 23;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(205, 93);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(121, 20);
            this.txtEntidad.TabIndex = 22;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(205, 58);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(121, 20);
            this.txtNumero.TabIndex = 21;
            // 
            // lblLiquidador
            // 
            this.lblLiquidador.AutoSize = true;
            this.lblLiquidador.Location = new System.Drawing.Point(57, 286);
            this.lblLiquidador.Name = "lblLiquidador";
            this.lblLiquidador.Size = new System.Drawing.Size(127, 13);
            this.lblLiquidador.TabIndex = 20;
            this.lblLiquidador.Text = "Liquidador Responsable: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(57, 251);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(58, 13);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Direccion: ";
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.Location = new System.Drawing.Point(57, 202);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(53, 13);
            this.lblJuzgado.TabIndex = 18;
            this.lblJuzgado.Text = "Juzgado: ";
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.Location = new System.Drawing.Point(57, 169);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(93, 13);
            this.lblExpediente.TabIndex = 17;
            this.lblExpediente.Text = "Nº de Expediente:";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Location = new System.Drawing.Point(57, 126);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(50, 13);
            this.lblApertura.TabIndex = 16;
            this.lblApertura.Text = "Apertura:";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Location = new System.Drawing.Point(57, 93);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(46, 13);
            this.lblEntidad.TabIndex = 15;
            this.lblEntidad.Text = "Entidad:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(57, 61);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 14;
            this.lblNumero.Text = "Numero:";
            // 
            // grillaProveedores
            // 
            this.grillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProveedores.Location = new System.Drawing.Point(12, 394);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProveedores.Size = new System.Drawing.Size(372, 182);
            this.grillaProveedores.TabIndex = 19;
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.Location = new System.Drawing.Point(57, 229);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(65, 13);
            this.lblJurisdiccion.TabIndex = 30;
            this.lblJurisdiccion.Text = "Jurisdicción:";
            // 
            // cmbJurisdiccion
            // 
            this.cmbJurisdiccion.FormattingEnabled = true;
            this.cmbJurisdiccion.Location = new System.Drawing.Point(205, 226);
            this.cmbJurisdiccion.Name = "cmbJurisdiccion";
            this.cmbJurisdiccion.Size = new System.Drawing.Size(121, 21);
            this.cmbJurisdiccion.TabIndex = 31;
            // 
            // frmRegistroProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 588);
            this.Controls.Add(this.grillaProveedores);
            this.Controls.Add(this.grbCuadro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmRegistroProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Proveedores";
            this.Load += new System.EventHandler(this.frmRegistroProveedores_Load);
            this.grbCuadro.ResumeLayout(false);
            this.grbCuadro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grbCuadro;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblLiquidador;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJuzgado;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmbJuzgado;
        private System.Windows.Forms.ComboBox cmbLiquidador;
        private System.Windows.Forms.MaskedTextBox mskExpediente;
        private System.Windows.Forms.DataGridView grillaProveedores;
        private System.Windows.Forms.ComboBox cmbJurisdiccion;
        private System.Windows.Forms.Label lblJurisdiccion;
    }
}