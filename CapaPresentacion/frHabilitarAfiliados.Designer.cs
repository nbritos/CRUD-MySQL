namespace CapaPresentacion
{
    partial class frHabilitarAfiliados
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
            this.dgvAfiliadosInactivos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliadosInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAfiliadosInactivos
            // 
            this.dgvAfiliadosInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfiliadosInactivos.Location = new System.Drawing.Point(13, 13);
            this.dgvAfiliadosInactivos.Name = "dgvAfiliadosInactivos";
            this.dgvAfiliadosInactivos.RowHeadersWidth = 51;
            this.dgvAfiliadosInactivos.RowTemplate.Height = 24;
            this.dgvAfiliadosInactivos.Size = new System.Drawing.Size(775, 354);
            this.dgvAfiliadosInactivos.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(669, 390);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(109, 48);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frHabilitarAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvAfiliadosInactivos);
            this.Name = "frHabilitarAfiliados";
            this.Text = "frHabilitarAfiliados";
            this.Load += new System.EventHandler(this.frHabilitarAfiliados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliadosInactivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAfiliadosInactivos;
        private System.Windows.Forms.Button btnCerrar;
    }
}