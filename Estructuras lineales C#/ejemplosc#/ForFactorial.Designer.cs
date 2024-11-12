namespace ejemplosc_
{
    partial class ForFactorial
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
            label1 = new Label();
            CajaTexto4 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(159, 198);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Siguiente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 86);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 1;
            label1.Text = "Ingresa un numero";
            // 
            // CajaTexto4
            // 
            CajaTexto4.Location = new Point(147, 130);
            CajaTexto4.Name = "CajaTexto4";
            CajaTexto4.Size = new Size(150, 31);
            CajaTexto4.TabIndex = 2;
            // 
            // ForFactorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(409, 396);
            Controls.Add(CajaTexto4);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ForFactorial";
            Text = "ForFactorial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox CajaTexto4;
        private SaveFileDialog saveFileDialog1;
    }
}