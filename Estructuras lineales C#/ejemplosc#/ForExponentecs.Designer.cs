namespace ejemplosc_
{
    partial class ForExponentecs
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
            button1 = new Button();
            TextoNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TextoExpo = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(220, 244);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "procesar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TextoNumero
            // 
            TextoNumero.Location = new Point(57, 131);
            TextoNumero.Name = "TextoNumero";
            TextoNumero.Size = new Size(150, 31);
            TextoNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 91);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 2;
            label1.Text = "Ingresa el numero";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 91);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 3;
            label2.Text = "Ingresa el exponente";
            // 
            // TextoExpo
            // 
            TextoExpo.Location = new Point(342, 131);
            TextoExpo.Name = "TextoExpo";
            TextoExpo.Size = new Size(150, 31);
            TextoExpo.TabIndex = 4;
            // 
            // ForExponentecs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 450);
            Controls.Add(TextoExpo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TextoNumero);
            Controls.Add(button1);
            Name = "ForExponentecs";
            Text = "ForExponentecs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TextoNumero;
        private Label label1;
        private Label label2;
        private TextBox TextoExpo;
    }
}