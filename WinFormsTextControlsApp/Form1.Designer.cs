namespace WinFormsTextControlsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F);
            textBox1.Location = new Point(41, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(341, 50);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(41, -1);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.AcceptsTab = true;
            textBox2.Font = new Font("Segoe UI", 24F);
            textBox2.Location = new Point(41, 127);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Both;
            textBox2.Size = new Size(341, 230);
            textBox2.TabIndex = 0;
            textBox2.WordWrap = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 22F);
            textBox3.Location = new Point(455, 63);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(306, 47);
            textBox3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F);
            label2.Location = new Point(455, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 45);
            label2.TabIndex = 1;
            label2.Text = "City";
            // 
            // button1
            // 
            button1.Location = new Point(639, 278);
            button1.Name = "button1";
            button1.Size = new Size(122, 79);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 22F);
            textBox4.Location = new Point(455, 162);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(306, 47);
            textBox4.TabIndex = 4;
            textBox4.UseSystemPasswordChar = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 24F);
            maskedTextBox1.HidePromptOnLeave = true;
            maskedTextBox1.Location = new Point(41, 412);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(341, 50);
            maskedTextBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 579);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox1;
    }
}
