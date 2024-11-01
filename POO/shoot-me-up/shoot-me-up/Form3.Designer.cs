namespace shoot_me_up
{
    partial class Form3
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
            levelsTitle = new Label();
            level1 = new Button();
            level2 = new Button();
            home = new Button();
            level0 = new Button();
            SuspendLayout();
            // 
            // levelsTitle
            // 
            levelsTitle.AutoSize = true;
            levelsTitle.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            levelsTitle.ForeColor = Color.White;
            levelsTitle.Location = new Point(499, 7);
            levelsTitle.Name = "levelsTitle";
            levelsTitle.Size = new Size(161, 65);
            levelsTitle.TabIndex = 0;
            levelsTitle.Text = "Levels";
            // 
            // level1
            // 
            level1.FlatAppearance.BorderColor = Color.DodgerBlue;
            level1.FlatAppearance.BorderSize = 2;
            level1.FlatStyle = FlatStyle.Flat;
            level1.Font = new Font("Segoe UI", 25.8F, FontStyle.Regular, GraphicsUnit.Point);
            level1.ForeColor = Color.White;
            level1.Location = new Point(472, 217);
            level1.Margin = new Padding(3, 2, 3, 2);
            level1.Name = "level1";
            level1.Size = new Size(219, 90);
            level1.TabIndex = 2;
            level1.Text = "Level 1";
            level1.UseVisualStyleBackColor = true;
            level1.Click += level1_Click;
            // 
            // level2
            // 
            level2.FlatAppearance.BorderColor = Color.DodgerBlue;
            level2.FlatAppearance.BorderSize = 2;
            level2.FlatStyle = FlatStyle.Flat;
            level2.Font = new Font("Segoe UI", 25.8F, FontStyle.Regular, GraphicsUnit.Point);
            level2.ForeColor = Color.White;
            level2.Location = new Point(472, 340);
            level2.Margin = new Padding(3, 2, 3, 2);
            level2.Name = "level2";
            level2.Size = new Size(219, 90);
            level2.TabIndex = 3;
            level2.Text = "Level 2";
            level2.UseVisualStyleBackColor = true;
            level2.Click += level2_Click;
            // 
            // home
            // 
            home.FlatAppearance.BorderColor = Color.DodgerBlue;
            home.FlatAppearance.BorderSize = 2;
            home.FlatStyle = FlatStyle.Flat;
            home.Font = new Font("Segoe UI", 25.8F, FontStyle.Regular, GraphicsUnit.Point);
            home.ForeColor = Color.White;
            home.Location = new Point(472, 463);
            home.Margin = new Padding(3, 2, 3, 2);
            home.Name = "home";
            home.Size = new Size(219, 90);
            home.TabIndex = 4;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // level0
            // 
            level0.FlatAppearance.BorderColor = Color.DodgerBlue;
            level0.FlatAppearance.BorderSize = 2;
            level0.FlatStyle = FlatStyle.Flat;
            level0.Font = new Font("Segoe UI", 25.8F, FontStyle.Regular, GraphicsUnit.Point);
            level0.ForeColor = Color.White;
            level0.Location = new Point(472, 98);
            level0.Margin = new Padding(3, 2, 3, 2);
            level0.Name = "level0";
            level0.Size = new Size(219, 90);
            level0.TabIndex = 1;
            level0.Text = "Survie";
            level0.UseVisualStyleBackColor = true;
            level0.Click += level0_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1184, 791);
            Controls.Add(level0);
            Controls.Add(home);
            Controls.Add(level2);
            Controls.Add(level1);
            Controls.Add(levelsTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label levelsTitle;
        private Button level1;
        private Button level2;
        private Button home;
        private Button level0;
    }
}