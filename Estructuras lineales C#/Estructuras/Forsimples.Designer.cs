namespace Estructuras
{
    partial class Forsimples
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
            this.buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cajainsertar = new System.Windows.Forms.TextBox();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.Valores = new System.Windows.Forms.ListBox();
            this.insertar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cajaposicion = new System.Windows.Forms.TextBox();
            this.insertarpocision = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cajainsertarvalor = new System.Windows.Forms.TextBox();
            this.eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cajaeliminar = new System.Windows.Forms.TextBox();
            this.vaciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(439, 256);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(107, 46);
            this.buscar.TabIndex = 0;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ingresa el valor a lista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "ingresa el valor a buscar";
            // 
            // cajainsertar
            // 
            this.cajainsertar.Location = new System.Drawing.Point(301, 28);
            this.cajainsertar.Name = "cajainsertar";
            this.cajainsertar.Size = new System.Drawing.Size(100, 26);
            this.cajainsertar.TabIndex = 3;
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(301, 266);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(100, 26);
            this.cajabuscar.TabIndex = 4;
            // 
            // Valores
            // 
            this.Valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(710, 0);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(120, 641);
            this.Valores.TabIndex = 5;
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(439, 20);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(128, 43);
            this.insertar.TabIndex = 6;
            this.insertar.Text = "insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingresa la posicion donde \r\nquieres insertar el nodo";
            // 
            // cajaposicion
            // 
            this.cajaposicion.Location = new System.Drawing.Point(301, 186);
            this.cajaposicion.Name = "cajaposicion";
            this.cajaposicion.Size = new System.Drawing.Size(100, 26);
            this.cajaposicion.TabIndex = 10;
            // 
            // insertarpocision
            // 
            this.insertarpocision.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.insertarpocision.Location = new System.Drawing.Point(439, 172);
            this.insertarpocision.Name = "insertarpocision";
            this.insertarpocision.Size = new System.Drawing.Size(162, 49);
            this.insertarpocision.TabIndex = 11;
            this.insertarpocision.Text = "insertar en posicion ";
            this.insertarpocision.UseVisualStyleBackColor = true;
            this.insertarpocision.Click += new System.EventHandler(this.insertarpocision_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 42);
            this.label4.TabIndex = 12;
            this.label4.Text = "ingresa el valor del\r\n   nodo a insetar";
            // 
            // cajainsertarvalor
            // 
            this.cajainsertarvalor.Location = new System.Drawing.Point(301, 110);
            this.cajainsertarvalor.Name = "cajainsertarvalor";
            this.cajainsertarvalor.Size = new System.Drawing.Size(100, 26);
            this.cajainsertarvalor.TabIndex = 13;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(439, 352);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(107, 55);
            this.eliminar.TabIndex = 14;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 42);
            this.label5.TabIndex = 15;
            this.label5.Text = "ingresa la posicion \r\ndel nodo a eliminar";
            // 
            // cajaeliminar
            // 
            this.cajaeliminar.Location = new System.Drawing.Point(301, 365);
            this.cajaeliminar.Name = "cajaeliminar";
            this.cajaeliminar.Size = new System.Drawing.Size(100, 26);
            this.cajaeliminar.TabIndex = 16;
            // 
            // vaciar
            // 
            this.vaciar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.vaciar.Location = new System.Drawing.Point(311, 479);
            this.vaciar.Name = "vaciar";
            this.vaciar.Size = new System.Drawing.Size(116, 51);
            this.vaciar.TabIndex = 17;
            this.vaciar.Text = "vaciar";
            this.vaciar.UseVisualStyleBackColor = false;
            this.vaciar.Click += new System.EventHandler(this.vaciar_Click);
            // 
            // Forsimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 641);
            this.Controls.Add(this.vaciar);
            this.Controls.Add(this.cajaeliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.cajainsertarvalor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.insertarpocision);
            this.Controls.Add(this.cajaposicion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajainsertar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Forsimples";
            this.Text = "Forsimples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajainsertar;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cajaposicion;
        private System.Windows.Forms.Button insertarpocision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cajainsertarvalor;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cajaeliminar;
        private System.Windows.Forms.Button vaciar;
    }
}