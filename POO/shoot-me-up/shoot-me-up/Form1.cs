using Microsoft.VisualBasic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

//TODO: click droit sur la classe > envoyer sur classe.cs

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
        public int shipSpeed = 6;
        public int score = 0;
        public int bestScore = 0;

        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            missiles = new List<Missile>();
            ennemies = new List<Ennemy>();
            SpawnEnnemies();
            // Création et configuration du timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5; // 0,1 seconde = 100 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        public void SpawnEnnemies()
        {
            Form1 form = this as Form1;  // Récupérer la référence du formulaire parent
            int positionX = 25;//position de base du premiere ennemi
            int positionY = 10;
            //2 ligne
            for (int i = 0; i < 2; i++)
            {
                //19 ennemis par ligne
                // Ajouter 10 ennemis a la lyiste
                for (int j = 0; j < 15; j++)
                {
                    var ennemy = new Ennemy(new Point(positionX, positionY));
                    form.Controls.Add(ennemy);
                    form.ennemies.Add(ennemy);
                    positionX += 75;
                }
                positionX = 25;
                positionY -= 100;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Form1 form = this as Form1;
            foreach (var missile in missiles.ToList())
            {
                missile.MoveMissile();
                //remove missile if they go out of the form
                if (missile.Top < 0)
                {
                    missiles.Remove(missile);
                    form.Controls.Remove(missile);
                }
            }
            foreach (var ennemy in ennemies)
            {
                ennemy.MoveEnnemy();
            }

            foreach(var missile in missiles.ToList())
            {
                foreach (var ennemy in ennemies.ToList())
                {
                    //regarde si le missile a touché l'ennemi
                    if (missile.Bounds.IntersectsWith(ennemy.Bounds))
                    {
                        missiles.Remove(missile);
                        ennemies.Remove(ennemy);
                        form.Controls.Remove(missile);
                        form.Controls.Remove(ennemy);
                    }
                }
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
}