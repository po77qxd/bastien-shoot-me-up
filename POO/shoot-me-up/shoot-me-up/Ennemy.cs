namespace shoot_me_up
{
    /// <summary>
    /// class ennemy, type PictureBox
    /// </summary>
    public class Ennemy : PictureBox
    {
        private int speed = 1;
        public Ennemy(Point initialPostion) {
            this.Image = Image.FromFile("../../../Ressources/ennemy.png");
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.Size = new Size(50, 50);
            this.Location = initialPostion;
        }
        /// <summary>
        /// Move the ennemy
        /// </summary>
        public void MoveEnnemy()
        {
            this.Top += speed;
        }
    }
}