namespace Estructuras
{
    partial class ForPila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.cajainsertar = new System.Windows.Forms.TextBox();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.Vaciar = new System.Windows.Forms.Button();
            this.Valores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el valor de la pila ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa el valor a buscar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "push";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(433, 110);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(113, 38);
            this.Buscar.TabIndex = 4;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(136, 203);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(152, 52);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "pop";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // cajainsertar
            // 
            this.cajainsertar.Location = new System.Drawing.Point(290, 42);
            this.cajainsertar.Name = "cajainsertar";
            this.cajainsertar.Size = new System.Drawing.Size(100, 26);
            this.cajainsertar.TabIndex = 6;
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(290, 113);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 7;
            // 
            // Vaciar
            // 
            this.Vaciar.Location = new System.Drawing.Point(368, 204);
            this.Vaciar.Name = "Vaciar";
            this.Vaciar.Size = new System.Drawing.Size(160, 51);
            this.Vaciar.TabIndex = 10;
            this.Vaciar.Text = "Vaciar";
            this.Vaciar.UseVisualStyleBackColor = true;
            this.Vaciar.Click += new System.EventHandler(this.Vaciar_Click);
            // 
            // Valores
            // 
            this.Valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(566, 0);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(109, 436);
            this.Valores.TabIndex = 11;
            // 
            // ForPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(675, 436);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.Vaciar);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajainsertar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForPila";
            this.Load += new System.EventHandler(this.ForPila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.TextBox cajainsertar;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.Button Vaciar;
        private System.Windows.Forms.ListBox Valores;
    }
}