using System.Windows.Forms;

namespace shoot_me_up
{
    public class Missile : PictureBox
    {
        // missile speed. The number of pixel the missile move when the timer calls MoveMissile()
        private int speed = 7;

        public Missile(Point initialPosition)
        {
            Game form = this.Parent as Game;// get parent form
            this.Image = Image.FromFile("../../../Ressources/missile.png");
            this.SizeMode = PictureBoxSizeMode.Normal;
            this.Size = new Size(6, 30);
            //Removing the half of the missile width to center the missile
            this.Location = initialPosition - new Size(this.Width / 2, 0);
        }

        
        public void MoveMissile()
        {
            this.Top -= speed;
        }
    }
}