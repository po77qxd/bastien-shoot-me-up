namespace shoot_me_up
{
    partial class Home
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
            button4 = new Button();
            BestScoresTitle = new Label();
            BestScoresLabel = new Label();
            HideScores = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(355, 27);
            label1.Name = "label1";
            label1.Size = new Size(411, 86);
            label1.TabIndex = 0;
            label1.Text = "Shoot me up";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(456, 192);
            button1.Name = "button1";
            button1.Size = new Size(219, 90);
            button1.TabIndex = 1;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = Color.DodgerBlue;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(456, 323);
            button2.Name = "button2";
            button2.Size = new Size(219, 90);
            button2.TabIndex = 2;
            button2.Text = "Scores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.DodgerBlue;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(456, 456);
            button3.Name = "button3";
            button3.Size = new Size(219, 113);
            button3.TabIndex = 3;
            button3.Text = "Level editor";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.DodgerBlue;
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(456, 610);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(219, 90);
            button4.TabIndex = 4;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // BestScoresTitle
            // 
            BestScoresTitle.AutoSize = true;
            BestScoresTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            BestScoresTitle.ForeColor = Color.White;
            BestScoresTitle.Location = new Point(474, 137);
            BestScoresTitle.Name = "BestScoresTitle";
            BestScoresTitle.Size = new Size(166, 41);
            BestScoresTitle.TabIndex = 5;
            BestScoresTitle.Text = "Best scores";
            // 
            // BestScoresLabel
            // 
            BestScoresLabel.AutoSize = true;
            BestScoresLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BestScoresLabel.ForeColor = Color.White;
            BestScoresLabel.Location = new Point(456, 192);
            BestScoresLabel.Name = "BestScoresLabel";
            BestScoresLabel.Size = new Size(0, 32);
            BestScoresLabel.TabIndex = 6;
            // 
            // HideScores
            // 
            HideScores.FlatAppearance.BorderColor = Color.DodgerBlue;
            HideScores.FlatAppearance.BorderSize = 2;
            HideScores.FlatStyle = FlatStyle.Flat;
            HideScores.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            HideScores.ForeColor = Color.White;
            HideScores.Location = new Point(456, 556);
            HideScores.Margin = new Padding(3, 2, 3, 2);
            HideScores.Name = "HideScores";
            HideScores.Size = new Size(219, 90);
            HideScores.TabIndex = 7;
            HideScores.Text = "Home";
            HideScores.UseVisualStyleBackColor = true;
            HideScores.Click += HideScores_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 761);
            Controls.Add(HideScores);
            Controls.Add(BestScoresLabel);
            Controls.Add(BestScoresTitle);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label BestScoresTitle;
        private Label BestScoresLabel;
        private Button HideScores;
    }
}