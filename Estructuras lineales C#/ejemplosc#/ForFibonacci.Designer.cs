namespace ejemplosc_
{
    partial class ForFibonacci
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
            CajaTexto2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // CajaTexto2
            // 
            CajaTexto2.Location = new Point(44, 107);
            CajaTexto2.Name = "CajaTexto2";
            CajaTexto2.Size = new Size(271, 31);
            CajaTexto2.TabIndex = 0;
            CajaTexto2.TextChanged += CajaTexto2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 49);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 1;
            label1.Text = "ingresa un numero";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(123, 173);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "siguiente";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ForFibonacci
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(350, 303);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(CajaTexto2);
            Name = "ForFibonacci";
            Text = "ForFibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CajaTexto2;
        private Label label1;
        private Button button1;
    }
}