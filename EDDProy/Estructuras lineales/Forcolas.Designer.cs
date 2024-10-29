namespace Estructuras
{
    partial class Forcolas
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
            this.Valores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cajainsertar = new System.Windows.Forms.TextBox();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.insertar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.vaciar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Valores
            // 
            this.Valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(680, 0);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(120, 450);
            this.Valores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "introduce los valores de la cola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "indroduce el valor a buscar";
            // 
            // cajainsertar
            // 
            this.cajainsertar.Location = new System.Drawing.Point(309, 47);
            this.cajainsertar.Name = "cajainsertar";
            this.cajainsertar.Size = new System.Drawing.Size(100, 26);
            this.cajainsertar.TabIndex = 3;
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(309, 113);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 4;
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(465, 47);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(86, 38);
            this.insertar.TabIndex = 5;
            this.insertar.Text = "Enqueve";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(465, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // vaciar
            // 
            this.vaciar.Location = new System.Drawing.Point(218, 223);
            this.vaciar.Name = "vaciar";
            this.vaciar.Size = new System.Drawing.Size(103, 56);
            this.vaciar.TabIndex = 7;
            this.vaciar.Text = "vaciar";
            this.vaciar.UseVisualStyleBackColor = true;
            this.vaciar.Click += new System.EventHandler(this.vaciar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(441, 214);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(110, 56);
            this.eliminar.TabIndex = 8;
            this.eliminar.Text = "Dequeve";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Forcolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.vaciar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajainsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valores);
            this.Name = "Forcolas";
            this.Text = "Forcolas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajainsertar;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button vaciar;
        private System.Windows.Forms.Button eliminar;
    }
}