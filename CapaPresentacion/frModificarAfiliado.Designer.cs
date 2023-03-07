namespace CapaPresentacion
{
    partial class frModificarAfiliado
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
            this.dgvAfiliados = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAfiliados
            // 
            this.dgvAfiliados.AllowUserToAddRows = false;
            this.dgvAfiliados.AllowUserToDeleteRows = false;
            this.dgvAfiliados.AllowUserToResizeColumns = false;
            this.dgvAfiliados.AllowUserToResizeRows = false;
            this.dgvAfiliados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            this.dgvAfiliados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAfiliados.Location = new System.Drawing.Point(12, 12);
            this.dgvAfiliados.Name = "dgvAfiliados";
            this.dgvAfiliados.RowHeadersWidth = 51;
            this.dgvAfiliados.RowTemplate.Height = 24;
            this.dgvAfiliados.Size = new System.Drawing.Size(883, 426);
            this.dgvAfiliados.TabIndex = 0;
            this.dgvAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAfiliados_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(740, 469);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 49);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "button1";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            this.Editar.Width = 48;
            // 
            // frModificarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 530);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvAfiliados);
            this.Name = "frModificarAfiliado";
            this.Text = "frModificarAfiliado";
            this.Load += new System.EventHandler(this.frModificarAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAfiliados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
    }
}