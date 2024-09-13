using System;

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
            Ship1 = new Ship(components);
            missile = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Ship1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)missile).BeginInit();
            SuspendLayout();
            // 
            // Ship1
            // 
            Ship1.Image = (Image)resources.GetObject("Ship1.Image");
            Ship1.Location = new Point(410, 491);
            Ship1.Name = "Ship1";
            Ship1.Size = new Size(90, 92);
            Ship1.SizeMode = PictureBoxSizeMode.Zoom;
            Ship1.TabIndex = 2;
            // 
            // missile
            // 
            missile.Image = (Image)resources.GetObject("missile.Image");
            missile.Location = new Point(452, 457);
            missile.Name = "missile";
            missile.Size = new Size(10, 28);
            missile.TabIndex = 3;
            missile.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1278, 844);
            Controls.Add(missile);
            Controls.Add(Ship1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Ship1).EndInit();
            ((System.ComponentModel.ISupportInitialize)missile).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Ship Ship1;
        private PictureBox missile;
    }
}