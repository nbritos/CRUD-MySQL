namespace CapaPresentacion
{
    partial class frPlanesAdicionales
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnApellido = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvParaPlanes = new System.Windows.Forms.DataGridView();
            this.AgregarPlan = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaPlanes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(173, 33);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(539, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 1;
            // 
            // btnApellido
            // 
            this.btnApellido.Location = new System.Drawing.Point(305, 32);
            this.btnApellido.Name = "btnApellido";
            this.btnApellido.Size = new System.Drawing.Size(44, 23);
            this.btnApellido.TabIndex = 2;
            this.btnApellido.Text = "button1";
            this.btnApellido.UseVisualStyleBackColor = true;
            this.btnApellido.Click += new System.EventHandler(this.btnApellido_Click);
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(662, 32);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(44, 23);
            this.btnID.TabIndex = 3;
            this.btnID.Text = "button2";
            this.btnID.UseVisualStyleBackColor = true;
            this.btnID.Click += new System.EventHandler(this.btnID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // dgvParaPlanes
            // 
            this.dgvParaPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParaPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgregarPlan});
            this.dgvParaPlanes.Location = new System.Drawing.Point(27, 86);
            this.dgvParaPlanes.Name = "dgvParaPlanes";
            this.dgvParaPlanes.RowHeadersWidth = 51;
            this.dgvParaPlanes.RowTemplate.Height = 24;
            this.dgvParaPlanes.Size = new System.Drawing.Size(748, 150);
            this.dgvParaPlanes.TabIndex = 6;
            this.dgvParaPlanes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParaPlanes_CellContentClick);
            // 
            // AgregarPlan
            // 
            this.AgregarPlan.HeaderText = "AgregarPlan";
            this.AgregarPlan.MinimumWidth = 6;
            this.AgregarPlan.Name = "AgregarPlan";
            this.AgregarPlan.ReadOnly = true;
            this.AgregarPlan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AgregarPlan.Text = "Agregar";
            this.AgregarPlan.UseColumnTextForLinkValue = true;
            this.AgregarPlan.Width = 125;
            // 
            // frPlanesAdicionales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvParaPlanes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnID);
            this.Controls.Add(this.btnApellido);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtApellido);
            this.Name = "frPlanesAdicionales";
            this.Text = "frPlanesAdicionales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaPlanes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnApellido;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvParaPlanes;
        private System.Windows.Forms.DataGridViewLinkColumn AgregarPlan;
    }
}