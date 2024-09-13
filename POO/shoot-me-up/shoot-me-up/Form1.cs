using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        public List<Missile> missiles;

        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            //missiles = new List<Missile>();
            missiles = new List<Missile>();
            //créer un eliste d'aliens
            // Création et configuration du timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // 0,1 seconde = 100 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var missile in missiles)
            {
                missile.MoveMissile();
            }
        }

        private void Ship1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }

    public class Ship : PictureBox
    {
        public Ship(IContainer container)
        {
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.UserMouse, true);
            TabStop = true;
            container.Add(this);
        }



        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            // Determine which key is pressed and move PictureBox accordingly
            int x = this.Location.X;
            int y = this.Location.Y;

            if (e.KeyCode == Keys.D)
            {
                e.IsInputKey = true;
                if (!(x > (this.Parent.Size.Width - this.Size.Width)))
                {
                    x += 5;
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (!(x < 0))
                {
                    x -= 5;
                }
            }
            else if (e.KeyCode == Keys.W)
            {
                if (!(y < 0))
                {
                    y -= 5;
                }
            }
            else if (e.KeyCode == Keys.S)
            {
                if (!(y > (this.Parent.Size.Height - this.Size.Height - 50)))
                {
                    y += 5;
                }
            }
            else if (e.KeyCode == Keys.Space)
            {
                Form1 form = this.Parent as Form1;  // Récupérer la référence du formulaire parent
                var missile = new Missile(new Point(this.Location.X, this.Location.Y));
                form.Controls.Add(missile);
                form.missiles.Add(missile);
            }

            // Update the PictureBox location
            this.Location = new Point(x, y);
            base.OnPreviewKeyDown(e);
        }
    }
    public class Missile : PictureBox
    {

        public Point Position { get; set; }
        private int speed = 5; // Vitesse de déplacement du missile

        public Missile(Point initialPosition)
        {
            this.Image = Image.FromFile("../../../../missile.png");
            this.SizeMode = PictureBoxSizeMode.Normal;
            Position = initialPosition;
        }

        // Déplace le missile vers le haut
        public void MoveMissile()
        {
            this.Top -= speed;
        }

    }
}