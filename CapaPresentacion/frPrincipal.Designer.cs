namespace CapaPresentacion
{
    partial class frPrincipal
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPlanesAdicionalesAlAfiliadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1159, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAfiliadoToolStripMenuItem,
            this.modificarAfiliadoToolStripMenuItem,
            this.habilitarAfiliadoToolStripMenuItem,
            this.agregarPlanesAdicionalesAlAfiliadoToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // agregarAfiliadoToolStripMenuItem
            // 
            this.agregarAfiliadoToolStripMenuItem.Name = "agregarAfiliadoToolStripMenuItem";
            this.agregarAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.agregarAfiliadoToolStripMenuItem.Text = "Agregar Afiliado";
            this.agregarAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.agregarAfiliadoToolStripMenuItem_Click);
            // 
            // modificarAfiliadoToolStripMenuItem
            // 
            this.modificarAfiliadoToolStripMenuItem.Name = "modificarAfiliadoToolStripMenuItem";
            this.modificarAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.modificarAfiliadoToolStripMenuItem.Text = "Modificar Afiliado/Dar de baja";
            this.modificarAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.modificarAfiliadoToolStripMenuItem_Click);
            // 
            // habilitarAfiliadoToolStripMenuItem
            // 
            this.habilitarAfiliadoToolStripMenuItem.Name = "habilitarAfiliadoToolStripMenuItem";
            this.habilitarAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.habilitarAfiliadoToolStripMenuItem.Text = "Habilitar Afiliado";
            this.habilitarAfiliadoToolStripMenuItem.Click += new System.EventHandler(this.habilitarAfiliadoToolStripMenuItem_Click);
            // 
            // agregarPlanesAdicionalesAlAfiliadoToolStripMenuItem
            // 
            this.agregarPlanesAdicionalesAlAfiliadoToolStripMenuItem.Name = "agregarPlanesAdicionalesAlAfiliadoToolStripMenuItem";
            this.agregarPlanesAdicionalesAlAfiliadoToolStripMenuItem.Size = new System.Drawing.Size(346, 26);
            this.agregarPlanesAdicionalesAlAfiliadoToolStripMenuItem.Text = "Agregar Planes Adicionales al Afiliado";
            // 
            // frPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 610);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "frPrincipal";
            this.Text = "7";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarAfiliadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPlanesAdicionalesAlAfiliadoToolStripMenuItem;
    }
}

