namespace shoot_me_up
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            customPictureBox1 = new CustomPictureBox(components);
            missile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)missile).BeginInit();
            SuspendLayout();
            // 
            // customPictureBox1
            // 
            customPictureBox1.Image = (Image)resources.GetObject("customPictureBox1.Image");
            customPictureBox1.Location = new Point(389, 491);
            customPictureBox1.Name = "customPictureBox1";
            customPictureBox1.Size = new Size(111, 92);
            customPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            customPictureBox1.TabIndex = 2;
            customPictureBox1.Click += customPictureBox1_Click;
            // 
            // missile
            // 
            missile.Image = (Image)resources.GetObject("missile.Image");
            missile.Location = new Point(434, 457);
            missile.Name = "missile";
            missile.Size = new Size(20, 28);
            missile.SizeMode = PictureBoxSizeMode.Zoom;
            missile.TabIndex = 3;
            missile.TabStop = false;
            missile.Click += pictureBox1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1278, 844);
            Controls.Add(missile);
            Controls.Add(customPictureBox1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)customPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)missile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CustomPictureBox customPictureBox1;
        private PictureBox missile;
    }
}