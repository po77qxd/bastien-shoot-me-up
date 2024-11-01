using Microsoft.VisualBasic;
using shoot_me_up.Properties;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace shoot_me_up
{
    /// <summary>
    /// class game
    /// </summary>
    public partial class Game : Form
    {
        public System.Windows.Forms.Timer timer;
        public List<Missile> missiles;
        private List<Ennemy> ennemies;
        //for the test
        public List<Ennemy> ennemiesPublic { get => ennemies; }
        private List<EnnemyMissile> ennemiesMissiles;
        private List<Obstacle> obstacles;
        //used for the test
        public List<Obstacle> obstaclesPublic { get => obstacles; }
        private List<Explosion> explosions;
        public bool goRight = false;
        public bool goLeft = false;
        public bool goTop = false;
        public bool goDown = false;
        private int shipSpeed = 6;
        private int score = 0;
        private int shipLife = 3;
        //for the test
        public int shipLifePublic { get => shipLife; }
        public bool canShoot = true;
        private bool canMoveRight = true;
        private bool canMoveLeft = true;
        private bool canMoveUp = true;
        private bool canMoveDown = true;
        //the number of time the timerTick() was called. Use to know when canShoot is true or false
        private int numberOfTimerIteration = 20;
        private bool cooldownEnabled = true;
        private int cooldownDuration = 600;//600 * 5 = 3000ms = 3sec
        private bool transpiercingShootEnabled = false;
        private int transpiercingShootDuration = 600;//600 * 5 = 3000ms = 3sec
        private int powerUpMessageDuration = 150;
        private int numberOfPowerUps = 2;
        private int _numberOfEnnemies;
        private int _numberOfObstacles;
        private int _levelId;
        private string[] bestScores;
        private int timeBeforeNewWave = 600;//3sec, time before ennemies spawn in level0
        private int numberOfEnnemiesInWave = 10;
        private System.Media.SoundPlayer powerUpSound = new System.Media.SoundPlayer("../../../Ressources/sounds/powerup.wav");
        /// <summary>
        /// Game constructor
        /// </summary>
        /// <param name="numberOfEnnemies">The number of ennemies in the level. Set to 0 for infinite ennemies</param>
        /// <param name="numberOfObstacles">The number of obstacle in the level</param>
        /// <param name="levelId">the level id.</param>
        public Game(int numberOfEnnemies, int numberOfObstacles, int levelId)
        {
            _numberOfEnnemies = numberOfEnnemies;
            _numberOfObstacles = numberOfObstacles;
            _levelId = levelId;
            InitializeComponent();
            this.StartPosition = 0;
            this.Size = new Size(1200, Screen.PrimaryScreen.WorkingArea.Height);
            InitGame();
        }
        /// <summary>
        /// Create the save file if it doesnt exists, create the list, hide the gameOver/wni screen elements, spawn the ennemies and obstacle
        /// </summary>
        private void InitGame()
        {
            //create the save file if it doesnt exists
            if (!File.Exists("../../../Ressources/score.txt"))
            {
                bestScores = new string[Config.NUMBER_OF_LEVELS];
                //replace the default null creation value by 0
                for (int i = 0; i < Config.NUMBER_OF_LEVELS; i++)
                {
                    if (bestScores[i] == null)
                    {
                        bestScores[i] = "0";
                    }
                }
                File.AppendAllLines("../../../Ressources/score.txt", bestScores);
            }
            bestScores = File.ReadAllLines("../../../Ressources/score.txt");
            missiles = new List<Missile>();
            ennemies = new List<Ennemy>();
            ennemiesMissiles = new List<EnnemyMissile>();
            obstacles = new List<Obstacle>();
            explosions = new List<Explosion>();
            winLabel.Hide();
            gameOver.Hide();
            gameOverScore.Hide();
            levelButton.Hide();
            powerUpLabel.Hide();
            newBestScoreLabel.Hide();
            spawnObstacle();
            SpawnEnnemies();
            // crreation and config of the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5; // 5ms = 0,005 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        /// <summary>
        /// spawn the obstacle.
        /// </summary>
        public void spawnObstacle()
        {
            Game form = this as Game;// get the form
            //the obstacle width is 150px
            //(form width - obstacle width * number obstacle) / (nbr obstacle + 1) = size between obstacle
            int spaceBetweenObstacle = (this.Width - 150 * _numberOfObstacles) / (_numberOfObstacles + 1);
            int x = spaceBetweenObstacle;//position of the first obstacle
            int y = 750;
            for (int i = 0; i < _numberOfObstacles; i++)
            {
                var obstacle = new Obstacle(new Point(x, y));
                form.Controls.Add(obstacle);
                form.obstacles.Add(obstacle);
                x += spaceBetweenObstacle + obstacle.Width;
            }
        }
        /// <summary>
        /// spawn the ennemies
        /// </summary>
        public void SpawnEnnemies()
        {
            Game form = this as Game;// get the form
            int positionX = 25;//position of the first ennemy
            int positionY = 10;
            if (_levelId == 0)
            {
                _numberOfEnnemies = numberOfEnnemiesInWave;
            }
            for (int i = 0; i < _numberOfEnnemies; i++)
            {
                Random random = new Random();
                int rndX = random.Next(75, 125);
                int rndY = random.Next(0, 25);
                positionY += rndY;
                var ennemy = new Ennemy(new Point(positionX, positionY));
                positionY -= rndY;//reset positionY to original value
                positionX += rndX;
                form.Controls.Add(ennemy);
                form.ennemies.Add(ennemy);
                //if ennemies are outside of the form, make another line
                if (positionX > this.Width - ennemy.Width)
                {
                    positionX = 25;
                    positionY -= 100;
                }
            }

        }
        /// <summary>
        /// move the missiles, ennemies, check collisions, make ennemies shoot, check if explosion need to be removed.
        /// Move the ship, check if the ship can shoot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Timer_Tick(object sender, EventArgs e)
        {
            Game form = this as Game;
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
            foreach (var ennemy in ennemies.ToList())
            {
                ennemy.MoveEnnemy();
                //Remove ennemies and remove one life when they go out of the form
                if (ennemy.Top > this.Height)
                {
                    ennemies.Remove(ennemy);
                    form.Controls.Remove(ennemy);
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
            //Check collision between ennemies and missiles
            foreach (var missile in missiles.ToList())
            {
                foreach (var ennemy in ennemies.ToList())
                {
                    //regarde si le missile a touché l'ennemi
                    if (missile.Bounds.IntersectsWith(ennemy.Bounds))
                    {
                        if (!transpiercingShootEnabled)
                        {
                            missiles.Remove(missile);
                            form.Controls.Remove(missile);
                        }
                        ennemies.Remove(ennemy);
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
                    score++;
                    scoreCounter.Text = score.ToString();
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
            //Move all ennemies missiles + Check collision between ship and ennemies missiles 
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
                if (!(this.Ship1.Left > this.Width - Ship1.Width))
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
                if (!(this.Ship1.Top > this.Height - Ship1.Height))//
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
            //if a powerup is enabled
            if (!cooldownEnabled || transpiercingShootEnabled)
            {
                if (!cooldownEnabled)
                {
                    canShoot = true;
                }
                CheckPowerUpEnd();
            }
            numberOfTimerIteration--;
            if (_levelId == 0)
            {
                if (timeBeforeNewWave == 0)
                {
                    SpawnEnnemies();
                    timeBeforeNewWave = 600;
                    numberOfEnnemiesInWave++;
                }
                else
                {
                    timeBeforeNewWave--;
                }
            }
            HidePowerUp();
            CheckWin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// close the game form and show the level selector form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// show the game over elements
        /// </summary>
        public void GameOver()
        {
            //show game over screen and stop game
            heart1.Hide();
            gameOver.Show();
            gameOverScore.Show();
            gameOverScore.Text += score.ToString();
            WriteBestScore();
            levelButton.Show();
            timer.Stop();
        }
        /// <summary>
        /// give a power up to the player
        /// </summary>
        public void DropPowerUp()
        {
            Random random = new Random();
            int rnd = random.Next(0, 20);// 1/20 chance to drop power up
            //only 1 powerup can be enabled at the same time
            if (rnd == 0 && cooldownEnabled && !transpiercingShootEnabled)
            {
                int rndPowerUp = random.Next(numberOfPowerUps);
                if (rndPowerUp == 0)
                {
                    cooldownEnabled = false;
                    ShowPowerUp("NO COOLDOWN");
                }
                else
                {
                    transpiercingShootEnabled = true;
                    ShowPowerUp("TRANSPIERCING SHOOT");
                }
                powerUpSound.Play();
            }
        }
        /// <summary>
        /// Check for the power up end
        /// </summary>
        public void CheckPowerUpEnd()
        {
            if (!cooldownEnabled)
            {
                if (cooldownDuration == 0)
                {
                    cooldownEnabled = true;
                    cooldownDuration = 600;
                    canShoot = true;
                    numberOfTimerIteration = 20;
                    ShowPowerUpEnd();
                }
                cooldownDuration--;
            }
            if (transpiercingShootEnabled)
            {
                if (transpiercingShootDuration == 0)
                {
                    transpiercingShootEnabled = false;
                    transpiercingShootDuration = 600;
                    canShoot = true;
                    numberOfTimerIteration = 20;
                    ShowPowerUpEnd();
                }
                transpiercingShootDuration--;
            }
        }
        /// <summary>
        /// show what power up is enabled
        /// </summary>
        /// <param name="powerUpName">the powerup name</param>
        public void ShowPowerUp(string powerUpName)
        {
            powerUpLabel.Text += powerUpName;
            powerUpLabel.Show();
        }
        /// <summary>
        /// hide the po^wer up message
        /// </summary>
        public void HidePowerUp()
        {
            if (powerUpMessageDuration == 0)
            {
                powerUpLabel.Hide();
                powerUpLabel.ResetText();
                powerUpLabel.Text = "POWER UP ENABLED : ";
                powerUpMessageDuration = 150;
            }
            else
            {
                powerUpMessageDuration--;
            }
        }
        /// <summary>
        /// Show the "poer up ended" message
        /// </summary>
        public void ShowPowerUpEnd()
        {
            powerUpLabel.ResetText();
            powerUpLabel.Text = "POWER UP ENDED";
            powerUpLabel.Show();
        }
        /// <summary>
        /// check if the player won
        /// </summary>
        public void CheckWin()
        {
            if (_levelId != 0)
            {
                if (ennemies.Count == 0 && shipLife != 0)
                {
                    Win();
                }
            }
        }
        /// <summary>
        /// Show the win elements
        /// </summary>
        public void Win()
        {
            winLabel.Show();
            gameOverScore.Show();
            gameOverScore.Text += score.ToString();
            WriteBestScore();
            levelButton.Show();
            timer.Stop();
        }
        /// <summary>
        /// If the previous best score has been beaten, show the "new best score" message and write the best score into the save file.
        /// </summary>
        public void WriteBestScore()
        {
            if (score > int.Parse(bestScores[_levelId]))
            {
                //show new best score message
                newBestScoreLabel.Show();
                bestScores[_levelId] = string.Concat(score);
                File.WriteAllLines("../../../Ressources/score.txt", bestScores);
            }
        }
    }
}