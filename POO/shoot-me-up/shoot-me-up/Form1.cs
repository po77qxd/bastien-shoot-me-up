using Microsoft.VisualBasic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

//TODO: sound, powerups, cdc, levels, add a text when you obtain a powerup

namespace shoot_me_up
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.Timer timer;
        public List<Missile> missiles;
        public List<Ennemy> ennemies;
        public List<EnnemyMissile> ennemiesMissiles;
        public List<Obstacle> obstacles;
        public List<Explosion> explosions;
        public bool goRight = false;
        public bool goLeft = false;
        public bool goTop = false;
        public bool goDown = false;
        public int shipSpeed = 6;
        public int score = 0;
        public int shipLife = 3;
        public int nbrObstacles = 3;
        public bool canShoot = true;
        private bool canMoveRight = true;
        private bool canMoveLeft = true;
        private bool canMoveUp = true;
        private bool canMoveDown = true;
        //the number of time the timerTick() was called. Use to know when canShoot is true or false
        private int numberOfTimerIteration = 20;
        public bool cooldownEnabled = true;
        public int cooldownDuration = 600;//600 * 5 = 3000 = 3sec

        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            missiles = new List<Missile>();
            ennemies = new List<Ennemy>();
            ennemiesMissiles = new List<EnnemyMissile>();
            obstacles = new List<Obstacle>();
            explosions = new List<Explosion>();
            gameOver.Hide();
            gameOverScore.Hide();
            homeButton.Hide();
            spawnObstacle();
            SpawnEnnemies();
            // Création et configuration du timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5; // 0,1 seconde = 100 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        public void spawnObstacle()
        {
            Form1 form = this as Form1;  // Récupérer la référence du formulaire parent
            int x = 75;//position du premier obstacle
            int y = 650;
            for (int i = 0; i < nbrObstacles; i++)
            {
                var obstacle = new Obstacle(new Point(x, y));
                form.Controls.Add(obstacle);
                form.obstacles.Add(obstacle);
                x += 450;
            }
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
                // Ajouter 10 ennemis a la liste
                for (int j = 0; j < 15; j++)
                {
                    Random random = new Random();
                    int rnd = random.Next(1, 5);// 1/5 chance that ennemies don't spawn
                    if (rnd != 1)
                    {
                        var ennemy = new Ennemy(new Point(positionX, positionY));
                        form.Controls.Add(ennemy);
                        form.ennemies.Add(ennemy);
                    }
                    
                    positionX += 75;
                }
                positionX = 25;
                positionY -= 100;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Form1 form = this as Form1;
            //Move all missiles
            foreach (var missile in missiles.ToList())
            {
                missile.MoveMissile();
                //remove missile if they go out of the form (30 is the size of the missile)
                if (missile.Top < -30)
                {
                    missiles.Remove(missile);
                    form.Controls.Remove(missile);
                }
            }
            //Move all ennemies
            foreach (var ennemy in ennemies)
            {
                ennemy.MoveEnnemy();
            }
            //Check collision between ennemies and missiles
            foreach (var missile in missiles.ToList())
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
                        var explosion = new Explosion(ennemy.Location);
                        form.Controls.Add(explosion);
                        explosions.Add(explosion);
                        DropPowerUp();
                        score++;
                        scoreCounter.Text = score.ToString();
                    }
                }
            }
            //Check collision between ship and ennemies
            foreach (var ennemy in ennemies.ToList())
            {
                if (ennemy.Bounds.IntersectsWith(Ship1.Bounds))
                {
                    ennemies.Remove(ennemy);
                    form.Controls.Remove(ennemy);
                    var explosion = new Explosion(ennemy.Location);
                    form.Controls.Add(explosion);
                    explosions.Add(explosion);
                    DropPowerUp();
                    shipLife--;
                    switch (shipLife)
                    {
                        case 2:
                            heart3.Hide();
                            break;
                        case 1:
                            heart2.Hide();
                            break;
                        case 0:
                            GameOver();
                            break;
                    }
                    score++;
                    scoreCounter.Text = score.ToString();
                }
            }
            //Make ennemies shoot
            foreach (var ennemy in ennemies)
            {
                //ennemies have a 1/1000 chance to shoot
                Random random = new Random();
                int rndNumber = random.Next(0, 1000);
                if (rndNumber == 1)
                {
                    var ennemyMissile = new EnnemyMissile(ennemy.Location);
                    form.Controls.Add(ennemyMissile);
                    form.ennemiesMissiles.Add(ennemyMissile);
                }
            }
            //Move all ennemies missiles
            foreach (var ennemyMissile in ennemiesMissiles.ToList())
            {
                ennemyMissile.MoveEnnemyMissile();
                //Check collision between ship and ennemies missiles
                //delete ennemy missile if they collide with the ship
                if (ennemyMissile.Bounds.IntersectsWith(Ship1.Bounds))
                {
                    ennemiesMissiles.Remove(ennemyMissile);
                    form.Controls.Remove(ennemyMissile);
                    shipLife--;
                    switch (shipLife)
                    {
                        case 2:
                            heart3.Hide();
                            break;
                        case 1:
                            heart2.Hide();
                            break;
                        case 0:
                            GameOver();
                            break;
                    }
                }
            }
            //Check collision between obstacle and missiles and ennemies
            foreach (var obstacle in obstacles.ToList()) 
            {
                //Check between missile and obstacle
                foreach (var missile in missiles.ToList())
                {
                    if (missile.Bounds.IntersectsWith(obstacle.Bounds))
                    {
                        missiles.Remove(missile);
                        form.Controls.Remove(missile);
                        obstacle.life--;
                        if (obstacle.life == 0)
                        {
                            obstacles.Remove(obstacle);
                            form.Controls.Remove(obstacle);
                        }
                    }
                }
                //Check between ennemy missile and obstacle
                foreach (var ennemyMissile in ennemiesMissiles.ToList())
                {
                    if (ennemyMissile.Bounds.IntersectsWith(obstacle.Bounds))
                    {
                        ennemiesMissiles.Remove(ennemyMissile);
                        form.Controls.Remove(ennemyMissile);
                        obstacle.life--;
                        if (obstacle.life == 0)
                        {
                            obstacles.Remove(obstacle);
                            form.Controls.Remove(obstacle);
                        }
                    }
                }
                //Check between ennemy and obstacle
                //Ennemies instantly destroy obstacles
                foreach (var ennemy in ennemies.ToList())
                {
                    if (ennemy.Bounds.IntersectsWith(obstacle.Bounds))
                    {
                        ennemies.Remove(ennemy);
                        form.Controls.Remove(ennemy);
                        var explosion = new Explosion(ennemy.Location);
                        form.Controls.Add(explosion);
                        explosions.Add(explosion);
                        obstacle.life = 0;
                        if (obstacle.life == 0)
                        {
                            obstacles.Remove(obstacle);
                            form.Controls.Remove(obstacle);
                        }

                    }
                }
            }
            //Check if an explosion needs to be removed
            foreach (var explosion in explosions.ToList())
            {
                explosion.timeBeforeDestruction--;
                if (explosion.timeBeforeDestruction == 0)
                {
                    explosions.Remove(explosion);
                    form.Controls.Remove(explosion);
                }
            }

            if (goRight)
            {
                if (!(this.Ship1.Left > 1110))//1200 = form width - 90 ship width
                {
                    canMoveRight = true;
                    foreach (var obstacle in obstacles)
                    {
                        if (obstacle.Bounds.IntersectsWith(Ship1.Bounds))
                        {
                            canMoveRight = false;
                            this.Ship1.Left -= shipSpeed;
                            break;
                        }
                    }
                    if (canMoveRight)
                    {
                        this.Ship1.Left += shipSpeed;
                    }
                }
            }
            if (goLeft)
            {
                if (!(this.Ship1.Left < 0))
                {
                    canMoveLeft = true;
                    foreach (var obstacle in obstacles)
                    {
                        if (obstacle.Bounds.IntersectsWith(Ship1.Bounds))
                        {
                            canMoveLeft = false;
                            this.Ship1.Left += shipSpeed;
                            break;
                        }
                    }
                    if (canMoveLeft)
                    {
                        this.Ship1.Left -= shipSpeed;
                    }
                }
            }
            if (goTop)
            {
                if (!(this.Ship1.Top < 0))
                {
                    canMoveUp = true;
                    foreach (var obstacle in obstacles)
                    {
                        if (obstacle.Bounds.IntersectsWith(Ship1.Bounds))
                        {
                            canMoveUp = false;
                            this.Ship1.Top += shipSpeed;
                            break;
                        }
                    }
                    if (canMoveUp)
                    {
                        this.Ship1.Top -= shipSpeed;
                    }
                }
            }
            if (goDown)
            {
                if (!(this.Ship1.Top > 760))//
                {
                    canMoveDown = true;
                    foreach (var obstacle in obstacles)
                    {
                        if (obstacle.Bounds.IntersectsWith(Ship1.Bounds))
                        {
                            canMoveDown = false;
                            this.Ship1.Top -= shipSpeed;
                            break;
                        }
                    }
                    if (canMoveDown)
                    {
                        this.Ship1.Top += shipSpeed;
                    }
                }
            }
            //Use to solve the noclip bug.
            //recheck the ship position. If the ship is in an obstacle, move it out.
            //goRight
            foreach (var obstacle in obstacles)
            {
                if (obstacle.Bounds.IntersectsWith(Ship1.Bounds) && goRight)
                {
                    this.Ship1.Left -= shipSpeed;
                }
            }
            //goLeft
            foreach (var obstacle in obstacles)
            {
                if (obstacle.Bounds.IntersectsWith(Ship1.Bounds) && goLeft)
                {
                    this.Ship1.Left += shipSpeed;
                }
            }
            //goTop
            foreach (var obstacle in obstacles)
            {
                if (obstacle.Bounds.IntersectsWith(Ship1.Bounds) && goTop)
                {
                    this.Ship1.Top += shipSpeed;
                }
            }
            //goDown
            foreach (var obstacle in obstacles)
            {
                if (obstacle.Bounds.IntersectsWith(Ship1.Bounds) && goDown)
                {
                    this.Ship1.Top -= shipSpeed;
                }
            }
            //the shoot cooldown is 100ms (20iteration, 5ms timer tick)
            if (numberOfTimerIteration == 0 && cooldownEnabled)
            {
                canShoot = true;
                numberOfTimerIteration = 20;
            }
            if (!cooldownEnabled)
            {
                canShoot = true;
                CheckPowerUpEnd();
            }
            numberOfTimerIteration--;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GameOver()
        {
            //show game over screen and stop game
            heart1.Hide();
            gameOver.Show();
            gameOverScore.Show();
            gameOverScore.Text += score.ToString();
            homeButton.Show();
            timer.Stop();
        }
        public void DropPowerUp()
        {
            Random random = new Random();
            int rnd = random.Next(0, 20);// 1/20 chance to drop power up
            if (rnd == 0)
            {
                cooldownEnabled = false;
            }
        }
        public void CheckPowerUpEnd()
        {
            if (cooldownDuration == 0)
            {
                cooldownEnabled = true;
                cooldownDuration = 600;
                canShoot = true;
                numberOfTimerIteration = 20;
            }
            cooldownDuration--;
        }
    }
}