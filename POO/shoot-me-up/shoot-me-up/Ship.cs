using System.ComponentModel;
using static System.Formats.Asn1.AsnWriter;


namespace shoot_me_up
{
    public class Ship : PictureBox
    {
        private System.Media.SoundPlayer shootSound = new System.Media.SoundPlayer("../../../Ressources/sounds/laser.wav");
        public Ship(IContainer container)
        {
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.UserMouse, true);
            TabStop = true;//permet de prendre le controle le vaisseau au début du jeu
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            container.Add(this);
        }


        private void TimerD_Tick(object sender, EventArgs e)
        {
            
        }
        public void keyisdown(object sender, KeyEventArgs e)
        {
            Game game = this.Parent as Game;// get parent form

            switch (e.KeyCode)
            {
                case Keys.A:
                    game.goLeft = true;
                    break;
                case Keys.D:
                    game.goRight = true;
                    break;
                case Keys.W:
                    game.goTop = true;
                    break;
                case Keys.S:
                    game.goDown = true;
                    break;
                case Keys.Space:
                    if (game.canShoot)
                    {
                        //Adding the half of the ship width to center the missile
                        var missile = new Missile(new Point(this.Location.X + this.Width / 2, this.Location.Y));
                        game.Controls.Add(missile);
                        game.missiles.Add(missile);
                        shootSound.Play();
                        game.canShoot = false;
                    }
                    break;
            }
        }

        public void keyisup(object sender, KeyEventArgs e)
        {
            Game form1 = this.Parent as Game;// get parent form
            switch (e.KeyCode)
            {
                case Keys.A:
                    form1.goLeft = false;
                    break;
                case Keys.D:
                    form1.goRight = false;
                    break;
                case Keys.W:
                    form1.goTop = false;
                    break;
                case Keys.S:
                    form1.goDown = false;
                    break;
            }
        }

    }
}