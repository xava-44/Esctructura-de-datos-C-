
namespace ejemplosc_
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            MenuStrip1 = new MenuStrip();
            pToolStripMenuItem = new ToolStripMenuItem();
            factorialDeUnNúmeroToolStripMenuItem = new ToolStripMenuItem();
            cálculoDeUnExponenteToolStripMenuItem = new ToolStripMenuItem();
            sumarLosElementosDeUnArregloToolStripMenuItem = new ToolStripMenuItem();
            SecuenciaDeFibonacciToolStripMenuItem = new ToolStripMenuItem();
            búsquedaBinariaToolStripMenuItem = new ToolStripMenuItem();
            algoritmoDeLaTorreDeHanoiToolStripMenuItem = new ToolStripMenuItem();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip1
            // 
            resources.ApplyResources(MenuStrip1, "MenuStrip1");
            MenuStrip1.ImageScalingSize = new Size(24, 24);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { pToolStripMenuItem });
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.RenderMode = ToolStripRenderMode.Professional;
            MenuStrip1.ItemClicked += MenuStrip1_ItemClicked;
            // 
            // pToolStripMenuItem
            // 
            resources.ApplyResources(pToolStripMenuItem, "pToolStripMenuItem");
            pToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { factorialDeUnNúmeroToolStripMenuItem, cálculoDeUnExponenteToolStripMenuItem, sumarLosElementosDeUnArregloToolStripMenuItem, SecuenciaDeFibonacciToolStripMenuItem, búsquedaBinariaToolStripMenuItem, algoritmoDeLaTorreDeHanoiToolStripMenuItem });
            pToolStripMenuItem.Name = "pToolStripMenuItem";
            // 
            // factorialDeUnNúmeroToolStripMenuItem
            // 
            resources.ApplyResources(factorialDeUnNúmeroToolStripMenuItem, "factorialDeUnNúmeroToolStripMenuItem");
            factorialDeUnNúmeroToolStripMenuItem.Image = Properties.Resources.factorial;
            factorialDeUnNúmeroToolStripMenuItem.Name = "factorialDeUnNúmeroToolStripMenuItem";
            factorialDeUnNúmeroToolStripMenuItem.Click += factorialDeUnNúmeroToolStripMenuItem_Click;
            // 
            // cálculoDeUnExponenteToolStripMenuItem
            // 
            resources.ApplyResources(cálculoDeUnExponenteToolStripMenuItem, "cálculoDeUnExponenteToolStripMenuItem");
            cálculoDeUnExponenteToolStripMenuItem.Image = Properties.Resources.images;
            cálculoDeUnExponenteToolStripMenuItem.Name = "cálculoDeUnExponenteToolStripMenuItem";
            cálculoDeUnExponenteToolStripMenuItem.Click += cálculoDeUnExponenteToolStripMenuItem_Click;
            // 
            // sumarLosElementosDeUnArregloToolStripMenuItem
            // 
            resources.ApplyResources(sumarLosElementosDeUnArregloToolStripMenuItem, "sumarLosElementosDeUnArregloToolStripMenuItem");
            sumarLosElementosDeUnArregloToolStripMenuItem.Image = Properties.Resources.descarga1;
            sumarLosElementosDeUnArregloToolStripMenuItem.Name = "sumarLosElementosDeUnArregloToolStripMenuItem";
            sumarLosElementosDeUnArregloToolStripMenuItem.Click += sumarLosElementosDeUnArregloToolStripMenuItem_Click;
            // 
            // SecuenciaDeFibonacciToolStripMenuItem
            // 
            resources.ApplyResources(SecuenciaDeFibonacciToolStripMenuItem, "SecuenciaDeFibonacciToolStripMenuItem");
            SecuenciaDeFibonacciToolStripMenuItem.Name = "SecuenciaDeFibonacciToolStripMenuItem";
            SecuenciaDeFibonacciToolStripMenuItem.Click += SecuenciaDeFibonacciToolStripMenuItem_Click;
            // 
            // búsquedaBinariaToolStripMenuItem
            // 
            resources.ApplyResources(búsquedaBinariaToolStripMenuItem, "búsquedaBinariaToolStripMenuItem");
            búsquedaBinariaToolStripMenuItem.Image = Properties.Resources.descarga;
            búsquedaBinariaToolStripMenuItem.Name = "búsquedaBinariaToolStripMenuItem";
            búsquedaBinariaToolStripMenuItem.Click += búsquedaBinariaToolStripMenuItem_Click;
            // 
            // algoritmoDeLaTorreDeHanoiToolStripMenuItem
            // 
            resources.ApplyResources(algoritmoDeLaTorreDeHanoiToolStripMenuItem, "algoritmoDeLaTorreDeHanoiToolStripMenuItem");
            algoritmoDeLaTorreDeHanoiToolStripMenuItem.Image = Properties.Resources.torres;
            algoritmoDeLaTorreDeHanoiToolStripMenuItem.Name = "algoritmoDeLaTorreDeHanoiToolStripMenuItem";
            algoritmoDeLaTorreDeHanoiToolStripMenuItem.Click += algoritmoDeLaTorreDeHanoiToolStripMenuItem_Click;
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(MenuStrip1);
            Cursor = Cursors.PanSW;
            ForeColor = SystemColors.Info;
            MainMenuStrip = MenuStrip1;
            Name = "Menu";
            Load += Form1_Load;
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_textChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private MenuStrip MenuStrip1;
        private ToolStripMenuItem pToolStripMenuItem;
        private ToolStripMenuItem factorialDeUnNúmeroToolStripMenuItem;
        private ToolStripMenuItem cálculoDeUnExponenteToolStripMenuItem;
        private ToolStripMenuItem sumarLosElementosDeUnArregloToolStripMenuItem;
        private ToolStripMenuItem SecuenciaDeFibonacciToolStripMenuItem;
        private ToolStripMenuItem búsquedaBinariaToolStripMenuItem;
        private ToolStripMenuItem algoritmoDeLaTorreDeHanoiToolStripMenuItem;
    }
}
