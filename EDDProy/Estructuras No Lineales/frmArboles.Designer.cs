
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.botonbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cajabusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Amplitud = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelamplitud = new System.Windows.Forms.Label();
            this.cajaprede = new System.Windows.Forms.TextBox();
            this.cajasucesor = new System.Windows.Forms.TextBox();
            this.butonpredecesor = new System.Windows.Forms.Button();
            this.butonsucesor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labcantidahojas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labnodos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lablleno = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labcompleto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDato.Location = new System.Drawing.Point(270, 193);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(90, 44);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(402, 191);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(128, 46);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.BackColor = System.Drawing.SystemColors.Control;
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(789, 14);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(573, 730);
            this.txtArbol.TabIndex = 2;
            this.txtArbol.TextChanged += new System.EventHandler(this.txtArbol_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(584, 99);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(158, 57);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "podar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.Location = new System.Drawing.Point(584, 9);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(158, 59);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = false;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRecorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.Location = new System.Drawing.Point(584, 193);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(158, 58);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(145, 199);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(81, 29);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato :";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCrearArbol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearArbol.Location = new System.Drawing.Point(402, 14);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(146, 49);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = false;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.BackColor = System.Drawing.Color.White;
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(270, 26);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(90, 32);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.BackColor = System.Drawing.Color.PowderBlue;
            this.lblPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOrden.Location = new System.Drawing.Point(38, 634);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(111, 22);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblRecorridoPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(172, 636);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(105, 22);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "PostOrden";
            this.lblRecorridoPostOrden.Click += new System.EventHandler(this.lblRecorridoPostOrden_Click);
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.BackColor = System.Drawing.Color.PowderBlue;
            this.lblInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOrden.Location = new System.Drawing.Point(60, 583);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(87, 22);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.BackColor = System.Drawing.Color.PowderBlue;
            this.lblPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrden.Location = new System.Drawing.Point(50, 528);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(102, 22);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblRecorridoInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(172, 583);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(105, 22);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "PostOrden";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblRecorridoPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(172, 530);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(105, 22);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "PostOrden";
            // 
            // botonbuscar
            // 
            this.botonbuscar.BackColor = System.Drawing.Color.Gainsboro;
            this.botonbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonbuscar.Location = new System.Drawing.Point(402, 99);
            this.botonbuscar.Name = "botonbuscar";
            this.botonbuscar.Size = new System.Drawing.Size(128, 44);
            this.botonbuscar.TabIndex = 15;
            this.botonbuscar.Text = "buscar";
            this.botonbuscar.UseVisualStyleBackColor = false;
            this.botonbuscar.Click += new System.EventHandler(this.botonbuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 44);
            this.label1.TabIndex = 16;
            this.label1.Text = "ingresa el numero \r\na buscar";
            // 
            // cajabusqueda
            // 
            this.cajabusqueda.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cajabusqueda.Location = new System.Drawing.Point(270, 99);
            this.cajabusqueda.Multiline = true;
            this.cajabusqueda.Name = "cajabusqueda";
            this.cajabusqueda.Size = new System.Drawing.Size(90, 44);
            this.cajabusqueda.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "ingresa el numero \r\nde nodos del arbol ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 44);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ingresa el dato a \r\neliminar(predecesor)";
            // 
            // Amplitud
            // 
            this.Amplitud.AutoSize = true;
            this.Amplitud.BackColor = System.Drawing.Color.PowderBlue;
            this.Amplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amplitud.Location = new System.Drawing.Point(443, 528);
            this.Amplitud.Name = "Amplitud";
            this.Amplitud.Size = new System.Drawing.Size(87, 22);
            this.Amplitud.TabIndex = 20;
            this.Amplitud.Text = "Amplitud";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 44);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ingresa el dato a \r\neliminar";
            // 
            // labelamplitud
            // 
            this.labelamplitud.AutoSize = true;
            this.labelamplitud.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelamplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelamplitud.Location = new System.Drawing.Point(551, 528);
            this.labelamplitud.Name = "labelamplitud";
            this.labelamplitud.Size = new System.Drawing.Size(54, 25);
            this.labelamplitud.TabIndex = 22;
            this.labelamplitud.Text = "BFS";
            this.labelamplitud.UseWaitCursor = true;
            // 
            // cajaprede
            // 
            this.cajaprede.Location = new System.Drawing.Point(270, 281);
            this.cajaprede.Multiline = true;
            this.cajaprede.Name = "cajaprede";
            this.cajaprede.Size = new System.Drawing.Size(90, 44);
            this.cajaprede.TabIndex = 23;
            // 
            // cajasucesor
            // 
            this.cajasucesor.Location = new System.Drawing.Point(270, 356);
            this.cajasucesor.Multiline = true;
            this.cajasucesor.Name = "cajasucesor";
            this.cajasucesor.Size = new System.Drawing.Size(90, 44);
            this.cajasucesor.TabIndex = 24;
            this.cajasucesor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // butonpredecesor
            // 
            this.butonpredecesor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butonpredecesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonpredecesor.Location = new System.Drawing.Point(404, 280);
            this.butonpredecesor.Name = "butonpredecesor";
            this.butonpredecesor.Size = new System.Drawing.Size(126, 45);
            this.butonpredecesor.TabIndex = 25;
            this.butonpredecesor.Text = "Predecesor";
            this.butonpredecesor.UseVisualStyleBackColor = false;
            this.butonpredecesor.Click += new System.EventHandler(this.butonpredecesor_Click);
            // 
            // butonsucesor
            // 
            this.butonsucesor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butonsucesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonsucesor.Location = new System.Drawing.Point(404, 356);
            this.butonsucesor.Name = "butonsucesor";
            this.butonsucesor.Size = new System.Drawing.Size(126, 44);
            this.butonsucesor.TabIndex = 26;
            this.butonsucesor.Text = "Sucesor";
            this.butonsucesor.UseVisualStyleBackColor = false;
            this.butonsucesor.Click += new System.EventHandler(this.butonsucesor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PowderBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Altura del Arbol :";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltura.Location = new System.Drawing.Point(211, 432);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(0, 25);
            this.labelAltura.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PowderBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(266, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "hojas del arbol :";
            // 
            // labcantidahojas
            // 
            this.labcantidahojas.AutoSize = true;
            this.labcantidahojas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labcantidahojas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcantidahojas.Location = new System.Drawing.Point(448, 429);
            this.labcantidahojas.Name = "labcantidahojas";
            this.labcantidahojas.Size = new System.Drawing.Size(27, 25);
            this.labcantidahojas.TabIndex = 30;
            this.labcantidahojas.Text = "N";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PowderBlue;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 431);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 22);
            this.label7.TabIndex = 31;
            this.label7.Text = "cantidad de nodos:";
            // 
            // labnodos
            // 
            this.labnodos.AllowDrop = true;
            this.labnodos.AutoSize = true;
            this.labnodos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labnodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labnodos.Location = new System.Drawing.Point(704, 433);
            this.labnodos.Name = "labnodos";
            this.labnodos.Size = new System.Drawing.Size(27, 25);
            this.labnodos.TabIndex = 32;
            this.labnodos.Text = "N";
            this.labnodos.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PowderBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 581);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "lleno:";
            // 
            // lablleno
            // 
            this.lablleno.AutoSize = true;
            this.lablleno.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lablleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablleno.Location = new System.Drawing.Point(551, 584);
            this.lablleno.Name = "lablleno";
            this.lablleno.Size = new System.Drawing.Size(27, 25);
            this.lablleno.TabIndex = 34;
            this.lablleno.Text = "N";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.PowderBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(430, 634);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 35;
            this.label10.Text = "Completo:";
            // 
            // labcompleto
            // 
            this.labcompleto.AutoSize = true;
            this.labcompleto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labcompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcompleto.Location = new System.Drawing.Point(551, 636);
            this.labcompleto.Name = "labcompleto";
            this.labcompleto.Size = new System.Drawing.Size(27, 25);
            this.labcompleto.TabIndex = 36;
            this.labcompleto.Text = "N";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1389, 809);
            this.Controls.Add(this.labcompleto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lablleno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labnodos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labcantidahojas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butonsucesor);
            this.Controls.Add(this.butonpredecesor);
            this.Controls.Add(this.cajasucesor);
            this.Controls.Add(this.cajaprede);
            this.Controls.Add(this.labelamplitud);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Amplitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cajabusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonbuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button botonbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajabusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Amplitud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelamplitud;
        private System.Windows.Forms.TextBox cajaprede;
        private System.Windows.Forms.TextBox cajasucesor;
        private System.Windows.Forms.Button butonpredecesor;
        private System.Windows.Forms.Button butonsucesor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labcantidahojas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labnodos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lablleno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labcompleto;
    }
}