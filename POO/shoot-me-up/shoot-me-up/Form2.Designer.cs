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
            label1.Location = new Point(406, 36);
            label1.Name = "label1";
            label1.Size = new Size(514, 106);
            label1.TabIndex = 0;
            label1.Text = "Shoot me up";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(521, 256);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(250, 120);
            button1.TabIndex = 1;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(521, 431);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(250, 120);
            button2.TabIndex = 2;
            button2.Text = "Scores";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(521, 608);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(250, 151);
            button3.TabIndex = 3;
            button3.Text = "Level editor";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(521, 814);
            button4.Name = "button4";
            button4.Size = new Size(250, 120);
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
            BestScoresTitle.Location = new Point(542, 183);
            BestScoresTitle.Name = "BestScoresTitle";
            BestScoresTitle.Size = new Size(204, 50);
            BestScoresTitle.TabIndex = 5;
            BestScoresTitle.Text = "Best scores";
            // 
            // BestScoresLabel
            // 
            BestScoresLabel.AutoSize = true;
            BestScoresLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BestScoresLabel.ForeColor = Color.White;
            BestScoresLabel.Location = new Point(521, 256);
            BestScoresLabel.Name = "BestScoresLabel";
            BestScoresLabel.Size = new Size(0, 41);
            BestScoresLabel.TabIndex = 6;
            // 
            // HideScores
            // 
            HideScores.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            HideScores.Location = new Point(521, 742);
            HideScores.Name = "HideScores";
            HideScores.Size = new Size(250, 120);
            HideScores.TabIndex = 7;
            HideScores.Text = "Home";
            HideScores.UseVisualStyleBackColor = true;
            HideScores.Click += HideScores_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1353, 1015);
            Controls.Add(HideScores);
            Controls.Add(BestScoresLabel);
            Controls.Add(BestScoresTitle);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
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