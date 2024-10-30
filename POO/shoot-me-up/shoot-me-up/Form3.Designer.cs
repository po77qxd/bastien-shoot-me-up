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
            this.levelsTitle = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.Button();
            this.level2 = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.level0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // levelsTitle
            // 
            this.levelsTitle.AutoSize = true;
            this.levelsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.levelsTitle.ForeColor = System.Drawing.Color.White;
            this.levelsTitle.Location = new System.Drawing.Point(499, 7);
            this.levelsTitle.Name = "levelsTitle";
            this.levelsTitle.Size = new System.Drawing.Size(161, 65);
            this.levelsTitle.TabIndex = 0;
            this.levelsTitle.Text = "Levels";
            // 
            // level1
            // 
            this.level1.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.level1.FlatAppearance.BorderSize = 2;
            this.level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level1.ForeColor = System.Drawing.Color.White;
            this.level1.Location = new System.Drawing.Point(472, 217);
            this.level1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(219, 90);
            this.level1.TabIndex = 2;
            this.level1.Text = "Level 1";
            this.level1.UseVisualStyleBackColor = true;
            // 
            // level2
            // 
            this.level2.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.level2.FlatAppearance.BorderSize = 2;
            this.level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level2.ForeColor = System.Drawing.Color.White;
            this.level2.Location = new System.Drawing.Point(472, 340);
            this.level2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(219, 90);
            this.level2.TabIndex = 3;
            this.level2.Text = "Level 2";
            this.level2.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.home.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.home.FlatAppearance.BorderSize = 2;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Location = new System.Drawing.Point(472, 463);
            this.home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(219, 90);
            this.home.TabIndex = 4;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // level0
            // 
            this.level0.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.level0.FlatAppearance.BorderSize = 2;
            this.level0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level0.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level0.ForeColor = System.Drawing.Color.White;
            this.level0.Location = new System.Drawing.Point(472, 98);
            this.level0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.level0.Name = "level0";
            this.level0.Size = new System.Drawing.Size(219, 90);
            this.level0.TabIndex = 1;
            this.level0.Text = "Survie";
            this.level0.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 791);
            this.Controls.Add(this.level0);
            this.Controls.Add(this.home);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.levelsTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label levelsTitle;
        private Button level1;
        private Button level2;
        private Button home;
        private Button level0;
    }
}