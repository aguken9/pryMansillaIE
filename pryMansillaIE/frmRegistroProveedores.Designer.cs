﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroProveedores));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbCuadro = new System.Windows.Forms.GroupBox();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.cmbJurisdiccion = new System.Windows.Forms.ComboBox();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.cmbJuzgado = new System.Windows.Forms.ComboBox();
            this.cmbLiquidador = new System.Windows.Forms.ComboBox();
            this.mskExpediente = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
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
            this.grbCuadro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.Location = new System.Drawing.Point(12, 349);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(372, 39);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.Location = new System.Drawing.Point(12, 394);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(372, 39);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(12, 439);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(372, 47);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.Location = new System.Drawing.Point(12, 492);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(372, 42);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grbCuadro
            // 
            this.grbCuadro.Controls.Add(this.dtpApertura);
            this.grbCuadro.Controls.Add(this.cmbJurisdiccion);
            this.grbCuadro.Controls.Add(this.lblJurisdiccion);
            this.grbCuadro.Controls.Add(this.cmbJuzgado);
            this.grbCuadro.Controls.Add(this.cmbLiquidador);
            this.grbCuadro.Controls.Add(this.mskExpediente);
            this.grbCuadro.Controls.Add(this.txtDireccion);
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
            // dtpApertura
            // 
            this.dtpApertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpApertura.Location = new System.Drawing.Point(205, 126);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(121, 20);
            this.dtpApertura.TabIndex = 32;
            // 
            // cmbJurisdiccion
            // 
            this.cmbJurisdiccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJurisdiccion.FormattingEnabled = true;
            this.cmbJurisdiccion.Location = new System.Drawing.Point(205, 226);
            this.cmbJurisdiccion.Name = "cmbJurisdiccion";
            this.cmbJurisdiccion.Size = new System.Drawing.Size(121, 21);
            this.cmbJurisdiccion.TabIndex = 31;
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
            // cmbJuzgado
            // 
            this.cmbJuzgado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuzgado.FormattingEnabled = true;
            this.cmbJuzgado.Location = new System.Drawing.Point(205, 199);
            this.cmbJuzgado.Name = "cmbJuzgado";
            this.cmbJuzgado.Size = new System.Drawing.Size(121, 21);
            this.cmbJuzgado.TabIndex = 29;
            this.cmbJuzgado.SelectedIndexChanged += new System.EventHandler(this.cmbJuzgado_SelectedIndexChanged);
            // 
            // cmbLiquidador
            // 
            this.cmbLiquidador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLiquidador.FormattingEnabled = true;
            this.cmbLiquidador.Location = new System.Drawing.Point(205, 283);
            this.cmbLiquidador.Name = "cmbLiquidador";
            this.cmbLiquidador.Size = new System.Drawing.Size(121, 21);
            this.cmbLiquidador.TabIndex = 28;
            // 
            // mskExpediente
            // 
            this.mskExpediente.Location = new System.Drawing.Point(205, 166);
            this.mskExpediente.Mask = "0000/0000";
            this.mskExpediente.Name = "mskExpediente";
            this.mskExpediente.Size = new System.Drawing.Size(121, 20);
            this.mskExpediente.TabIndex = 19;
            this.mskExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskExpediente_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(205, 257);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 26;
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
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
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
            this.lblDireccion.Location = new System.Drawing.Point(57, 260);
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
            this.grillaProveedores.Location = new System.Drawing.Point(390, 16);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaProveedores.Size = new System.Drawing.Size(564, 518);
            this.grillaProveedores.TabIndex = 19;
            this.grillaProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaProveedores_CellClick);
            // 
            // frmRegistroProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(970, 536);
            this.Controls.Add(this.grillaProveedores);
            this.Controls.Add(this.grbCuadro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DateTimePicker dtpApertura;
    }
}