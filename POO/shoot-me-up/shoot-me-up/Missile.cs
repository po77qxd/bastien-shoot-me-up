using System.Windows.Forms;

namespace shoot_me_up
{
    public class Missile : PictureBox
    {
        // Vitesse de déplacement du missile. Correspond au nombre de pixels dont le missile sera déplacera à chaque fois que le timer appelle MoveMissile.
        private int speed = 5;

        public Missile(Point initialPosition)
        {
            this.Image = Image.FromFile("../../../Ressources/missile.png");
            this.SizeMode = PictureBoxSizeMode.Normal;
            this.Size = new Size(6, 30);
            //45 = la moitié de la largeur du vaisseau, 3 = la moitié de la largeur du missile. Est utilisé pour centrer le missile
            this.Location = initialPosition + new Size(42, 0);
        }

        // Déplace le missile vers le haut
        public void MoveMissile()
        {
            this.Top -= speed;
        }
    }
}