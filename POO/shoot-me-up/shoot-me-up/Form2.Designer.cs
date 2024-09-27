namespace shoot_me_up
{
    partial class Form2
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(355, 27);
            label1.Name = "label1";
            label1.Size = new Size(411, 86);
            label1.TabIndex = 0;
            label1.Text = "Shoot me up";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(456, 192);
            button1.Name = "button1";
            button1.Size = new Size(219, 90);
            button1.TabIndex = 1;
            button1.Text = "Jouer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(456, 323);
            button2.Name = "button2";
            button2.Size = new Size(219, 90);
            button2.TabIndex = 2;
            button2.Text = "Scores";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(456, 456);
            button3.Name = "button3";
            button3.Size = new Size(219, 113);
            button3.TabIndex = 3;
            button3.Text = "Editeur de niveau";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}