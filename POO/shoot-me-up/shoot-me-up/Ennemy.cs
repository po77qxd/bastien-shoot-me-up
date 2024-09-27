namespace shoot_me_up
{
    public class Ennemy : PictureBox
    {
        int speed = 1;
        public Ennemy(Point initialPostion) {
            this.Image = Image.FromFile("../../../Ressources/ennemy.png");
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Size(50, 50);
            this.Location = initialPostion;
        }

        public void MoveEnnemy()
        {
            this.Top += speed;
        }
    }
}