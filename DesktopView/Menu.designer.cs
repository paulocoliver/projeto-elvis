namespace Trabalho.DesktopView
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.empresarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDepartamentos,
            this.toolCargos,
            this.empresarioToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolDepartamentos
            // 
            this.toolDepartamentos.Name = "toolDepartamentos";
            this.toolDepartamentos.Size = new System.Drawing.Size(155, 22);
            this.toolDepartamentos.Text = "Departamentos";
            this.toolDepartamentos.Click += new System.EventHandler(this.toolDepartamentos_Click);
            // 
            // toolCargos
            // 
            this.toolCargos.Name = "toolCargos";
            this.toolCargos.Size = new System.Drawing.Size(155, 22);
            this.toolCargos.Text = "Cargos";
            this.toolCargos.Click += new System.EventHandler(this.toolCargos_Click);
            // 
            // empresarioToolStripMenuItem
            // 
            this.empresarioToolStripMenuItem.Name = "empresarioToolStripMenuItem";
            this.empresarioToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.empresarioToolStripMenuItem.Text = "Empresario";
            this.empresarioToolStripMenuItem.Click += new System.EventHandler(this.empresarioToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem toolCargos;
        private System.Windows.Forms.ToolStripMenuItem empresarioToolStripMenuItem;
    }
}