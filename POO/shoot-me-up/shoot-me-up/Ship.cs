using System.ComponentModel;
using static System.Formats.Asn1.AsnWriter;


namespace shoot_me_up
{
    public class Ship : PictureBox
    {
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
            Form1 form1 = this.Parent as Form1;

            switch (e.KeyCode)
            {
                case Keys.A:
                    form1.goLeft = true;
                    break;
                case Keys.D:
                    form1.goRight = true;
                    break;
                case Keys.W:
                    form1.goTop = true;
                    break;
                case Keys.S:
                    form1.goDown = true;
                    break;
                case Keys.Space:
                    Form1 form = this.Parent as Form1;  // Récupérer la référence du formulaire parent
                    if (form.canShoot)
                    {
                        var missile = new Missile(new Point(this.Location.X, this.Location.Y));
                        form.Controls.Add(missile);
                        form.missiles.Add(missile);
                        form1.canShoot = false;
                    }
                    break;
            }
        }

        public void keyisup(object sender, KeyEventArgs e)
        {
            Form1 form1 = this.Parent as Form1;
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