namespace shoot_me_up
{
    public class Explosion : PictureBox
    {
        public int timeBeforeDestruction = 10;//10 * 5 = 50ms before removing
        public Explosion(Point initialLocation)
        {
            this.Image = Image.FromFile("../../../Ressources/explosion.png");
            this.Size = new Size(50, 50);
            this.Location = initialLocation;
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}