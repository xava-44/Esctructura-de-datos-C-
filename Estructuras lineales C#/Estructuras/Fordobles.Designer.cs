namespace Estructuras
{
    partial class Fordobles
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
            this.label3 = new System.Windows.Forms.Label();
            this.Valores = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.insertar = new System.Windows.Forms.Button();
            this.vaciar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.cajaagregar = new System.Windows.Forms.TextBox();
            this.cajavalor = new System.Windows.Forms.TextBox();
            this.cajaposicion = new System.Windows.Forms.TextBox();
            this.cajabuscar = new System.Windows.Forms.TextBox();
            this.cajaeliminar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingresa el valor a insertar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingresa la posicion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ingresa el valor a buscar";
            // 
            // Valores
            // 
            this.Valores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Valores.Dock = System.Windows.Forms.DockStyle.Right;
            this.Valores.FormattingEnabled = true;
            this.Valores.ItemHeight = 20;
            this.Valores.Location = new System.Drawing.Point(601, 0);
            this.Valores.Name = "Valores";
            this.Valores.Size = new System.Drawing.Size(133, 523);
            this.Valores.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "ingresa los valores \r\nde la lista doble";
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(458, 53);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(93, 45);
            this.agregar.TabIndex = 5;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(458, 199);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(93, 38);
            this.insertar.TabIndex = 6;
            this.insertar.Text = "insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // vaciar
            // 
            this.vaciar.Location = new System.Drawing.Point(320, 443);
            this.vaciar.Name = "vaciar";
            this.vaciar.Size = new System.Drawing.Size(124, 39);
            this.vaciar.TabIndex = 7;
            this.vaciar.Text = "vaciar";
            this.vaciar.UseVisualStyleBackColor = true;
            this.vaciar.Click += new System.EventHandler(this.vaciar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(458, 259);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(93, 42);
            this.buscar.TabIndex = 8;
            this.buscar.Text = "buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // cajaagregar
            // 
            this.cajaagregar.Location = new System.Drawing.Point(320, 62);
            this.cajaagregar.Name = "cajaagregar";
            this.cajaagregar.Size = new System.Drawing.Size(111, 26);
            this.cajaagregar.TabIndex = 9;
            // 
            // cajavalor
            // 
            this.cajavalor.Location = new System.Drawing.Point(320, 140);
            this.cajavalor.Name = "cajavalor";
            this.cajavalor.Size = new System.Drawing.Size(111, 26);
            this.cajavalor.TabIndex = 10;
            // 
            // cajaposicion
            // 
            this.cajaposicion.Location = new System.Drawing.Point(320, 205);
            this.cajaposicion.Name = "cajaposicion";
            this.cajaposicion.Size = new System.Drawing.Size(111, 26);
            this.cajaposicion.TabIndex = 11;
            // 
            // cajabuscar
            // 
            this.cajabuscar.Location = new System.Drawing.Point(320, 275);
            this.cajabuscar.Name = "cajabuscar";
            this.cajabuscar.Size = new System.Drawing.Size(111, 26);
            this.cajabuscar.TabIndex = 12;
            // 
            // cajaeliminar
            // 
            this.cajaeliminar.Location = new System.Drawing.Point(320, 343);
            this.cajaeliminar.Name = "cajaeliminar";
            this.cajaeliminar.Size = new System.Drawing.Size(111, 26);
            this.cajaeliminar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 40);
            this.label5.TabIndex = 14;
            this.label5.Text = "ingresa la posicion \r\ndel nodo a eliminar";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(458, 329);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(107, 45);
            this.eliminar.TabIndex = 15;
            this.eliminar.Text = "eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Fordobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 523);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cajaeliminar);
            this.Controls.Add(this.cajabuscar);
            this.Controls.Add(this.cajaposicion);
            this.Controls.Add(this.cajavalor);
            this.Controls.Add(this.cajaagregar);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.vaciar);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Valores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Fordobles";
            this.Text = "Fordobles";
            this.Load += new System.EventHandler(this.Fordobles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Valores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Button vaciar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox cajaagregar;
        private System.Windows.Forms.TextBox cajavalor;
        private System.Windows.Forms.TextBox cajaposicion;
        private System.Windows.Forms.TextBox cajabuscar;
        private System.Windows.Forms.TextBox cajaeliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button eliminar;
    }
}