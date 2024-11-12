namespace ejemplosc_
{
    partial class ForBusqueda
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            valores = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 51);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 0;
            label1.Text = "Introduce la cantidad del arreglo";
            // 
            // valores
            // 
            valores.FormattingEnabled = true;
            valores.ItemHeight = 25;
            valores.Location = new Point(287, 197);
            valores.Name = "valores";
            valores.Size = new Size(180, 129);
            valores.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(472, 135);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(287, 49);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 138);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 5;
            label2.Text = "introduce los valores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 397);
            label3.Name = "label3";
            label3.Size = new Size(226, 25);
            label3.TabIndex = 6;
            label3.Text = "Ingresa el numero a buscar";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 394);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(482, 394);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 8;
            button2.Text = "procesar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ForBusqueda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 655);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(valores);
            Controls.Add(label1);
            Name = "ForBusqueda";
            Text = "ForBusqueda";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox valores;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button2;
    }
}