namespace Estructuras
{
    partial class Forcirculares
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
            this.insertar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cajainsertar = new System.Windows.Forms.TextBox();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.Valores = new System.Windows.Forms.ListBox();
            this.cajaeliminar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaposicion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(418, 78);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(85, 35);
            this.insertar.TabIndex = 0;
            this.insertar.Text = "insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(418, 133);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(85, 38);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(418, 220);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(82, 41);
            this.eliminar.TabIndex = 2;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ingresa el valor a insertar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ingresa el valor a buscar";
            // 
            // cajainsertar
            // 
            this.cajainsertar.Location = new System.Drawing.Point(286, 85);
            this.cajainsertar.Name = "cajainsertar";
            this.cajainsertar.Size = new System.Drawing.Size(100, 26);
            this.cajainsertar.TabIndex = 6;
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(286, 145);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 7;
            // 
            // Valores
            // 
            this.Valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(558, 0);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(120, 450);
            this.Valores.TabIndex = 9;
            // 
            // cajaeliminar
            // 
            this.cajaeliminar.Location = new System.Drawing.Point(286, 235);
            this.cajaeliminar.Name = "cajaeliminar";
            this.cajaeliminar.Size = new System.Drawing.Size(100, 26);
            this.cajaeliminar.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "ingresa la posicion a eliminar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 40);
            this.label3.TabIndex = 14;
            this.label3.Text = "ingresa la posicion donde \r\nquieres colocar el nodo ";
            // 
            // cajaposicion
            // 
            this.cajaposicion.Location = new System.Drawing.Point(286, 9);
            this.cajaposicion.Name = "cajaposicion";
            this.cajaposicion.Size = new System.Drawing.Size(100, 26);
            this.cajaposicion.TabIndex = 15;
            // 
            // Forcirculares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.cajaposicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cajaeliminar);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajainsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.insertar);
            this.Name = "Forcirculares";
            this.Text = "Forcirculares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajainsertar;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.TextBox cajaeliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajaposicion;
    }
}