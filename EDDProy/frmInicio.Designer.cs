
namespace EDDemo
{
    partial class frmInicio
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
            this.estructuraLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIlasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lIstasDoblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasCircularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estructuraLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(206, 654);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estructuraLinealesToolStripMenuItem
            // 
            this.estructuraLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pIlasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasSimplesToolStripMenuItem,
            this.lIstasDoblesToolStripMenuItem,
            this.listasCircularesToolStripMenuItem});
            this.estructuraLinealesToolStripMenuItem.Name = "estructuraLinealesToolStripMenuItem";
            this.estructuraLinealesToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.estructuraLinealesToolStripMenuItem.Text = "Estructura lineales ";
            // 
            // pIlasToolStripMenuItem
            // 
            this.pIlasToolStripMenuItem.Name = "pIlasToolStripMenuItem";
            this.pIlasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.pIlasToolStripMenuItem.Text = "PIlas";
            this.pIlasToolStripMenuItem.Click += new System.EventHandler(this.pIlasToolStripMenuItem_Click_1);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no lineales";
            this.estructurasNoLibealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasNoLibealesToolStripMenuItem_Click);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(175, 34);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // listasSimplesToolStripMenuItem
            // 
            this.listasSimplesToolStripMenuItem.Name = "listasSimplesToolStripMenuItem";
            this.listasSimplesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listasSimplesToolStripMenuItem.Text = "Listas simples ";
            // 
            // lIstasDoblesToolStripMenuItem
            // 
            this.lIstasDoblesToolStripMenuItem.Name = "lIstasDoblesToolStripMenuItem";
            this.lIstasDoblesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.lIstasDoblesToolStripMenuItem.Text = "LIstas dobles";
            // 
            // listasCircularesToolStripMenuItem
            // 
            this.listasCircularesToolStripMenuItem.Name = "listasCircularesToolStripMenuItem";
            this.listasCircularesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listasCircularesToolStripMenuItem.Text = "Listas circulares";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1025, 654);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructuraLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIlasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lIstasDoblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasCircularesToolStripMenuItem;
    }
}

