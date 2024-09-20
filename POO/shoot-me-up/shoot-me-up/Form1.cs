using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace shoot_me_up
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        public List<Missile> missiles;
        public List<Ennemy> ennemies;
        public bool goRight = false;
        public bool goLeft = false;
        public bool goTop = false;
        public bool goDown = false;
        public int shipSpeed = 5;

        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            missiles = new List<Missile>();
            // TODO : créer une liste d'aliens
            ennemies = new List<Ennemy>();
            // Création et configuration du timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5; // 0,1 seconde = 100 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var missile in missiles)
            {
                missile.MoveMissile();
            }
            if (goRight)
            {
                if (!(this.Ship1.Left > 1110))//1200 = form width - 90 ship width
                {
                    this.Ship1.Left += shipSpeed;
                }
            }
            if (goLeft)
            {
                if (!(this.Ship1.Left < 0))
                {
                    this.Ship1.Left -= shipSpeed;
                }
            }
            if (goTop)
            {
                if (!(this.Ship1.Top < 0))//1200 = form width - 90 ship width
                {
                    this.Ship1.Top -= shipSpeed;
                }
            }
            if (goDown)
            {
                if (!(this.Ship1.Top > 700))
                {
                    this.Ship1.Top += shipSpeed;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
    }

    public class Ship : PictureBox
    {
        
        public Ship(IContainer container)
        {
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.UserMouse, true);
            TabStop = true;//permet de prendre le controle le vaisseau au début du jeu
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
                    var missile = new Missile(new Point(this.Location.X, this.Location.Y));
                    form.Controls.Add(missile);
                    form.missiles.Add(missile);
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
    public class Missile : PictureBox
    {
        // Vitesse de déplacement du missile. Correspond au nombre de pixels dont le missile sera déplacera à chaque fois que le timer appelle MoveMissile.
        private int speed = 5;

        public Missile(Point initialPosition)
        {
            this.Image = Image.FromFile("../../../Ressources/missile.png");
            this.SizeMode = PictureBoxSizeMode.Normal;
            //45 = la moitié de la largeur du vaisseau, 3 = la moitié de la largeur du missile. Est utilisé pour centrer le missile
            this.Location = initialPosition + new Size(45, 0) - new Size(3,0);
        }

        // Déplace le missile vers le haut
        public void MoveMissile()
        {
            this.Top -= speed;
        }

    }

    public class Ennemy : PictureBox
    {
        public Ennemy() {
            this.Image = Image.FromFile("../../../Ressources/missile.png");
            this.Location = new Point(10, 10);
        }

    }
}