
namespace pryMansillaIE
{
    partial class frmProveedoresActivos
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
            this.trvProveedores = new System.Windows.Forms.TreeView();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // trvProveedores
            // 
            this.trvProveedores.Location = new System.Drawing.Point(23, 22);
            this.trvProveedores.Name = "trvProveedores";
            this.trvProveedores.Size = new System.Drawing.Size(255, 206);
            this.trvProveedores.TabIndex = 0;
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(23, 248);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(255, 186);
            this.lstDatos.TabIndex = 1;
            // 
            // frmProveedoresActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 443);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.trvProveedores);
            this.Name = "frmProveedoresActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores Activos";
            this.Load += new System.EventHandler(this.frmProveedoresActivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvProveedores;
        private System.Windows.Forms.ListBox lstDatos;
    }
}