//TODO: click droit sur la classe > envoyer sur classe.cs

namespace shoot_me_up
{
    public class EnnemyMissile : PictureBox
    {
        private int speed = 5;
        public EnnemyMissile(Point initialPosition)
        {
            this.Image = Image.FromFile("../../../Ressources/ennemyMissile.png");
            this.SizeMode = PictureBoxSizeMode.Normal;
            this.Size = new Size(6, 30);
            //25 = la moitié de la largeur de l'ennemi - 3 (la moitié de la largeur de l'image), est utilisé pour centrer le missile
            this.Location = initialPosition + new Size(22, 0);
        }

        public void MoveEnnemyMissile()
        {
            this.Top += speed;
        }
    }
}