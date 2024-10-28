using System.Windows.Forms;

namespace shoot_me_up
{
    public class Missile : PictureBox
    {
        // Vitesse de déplacement du missile. Correspond au nombre de pixels dont le missile sera déplacera à chaque fois que le timer appelle MoveMissile.
        private int speed = 7;

        public Missile(Point initialPosition)
        {
            Game form = this.Parent as Game;
            this.Image = Image.FromFile("../../../Ressources/missile.png");
            this.SizeMode = PictureBoxSizeMode.Normal;
            this.Size = new Size(6, 30);
            //Removing the half of the missile width to center the missile
            this.Location = initialPosition - new Size(this.Width / 2, 0);
        }

        // Déplace le missile vers le haut
        public void MoveMissile()
        {
            this.Top -= speed;
        }
    }
}