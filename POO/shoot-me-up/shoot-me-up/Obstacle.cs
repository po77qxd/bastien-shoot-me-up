//TODO: click droit sur la classe > envoyer sur classe.cs

namespace shoot_me_up
{
    public class Obstacle : PictureBox
    {
        public int life = 3;
        public Obstacle(Point initialPosition)
        {
            this.Image = Image.FromFile("../../../Ressources/obstacle.png");
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Size(150, 40);
            this.Location = initialPosition;
        }
    }
}