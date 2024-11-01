using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoot_me_up
{
    /// <summary>
    /// class for the home screen
    /// </summary>
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.StartPosition = 0;
            BestScoresTitle.Hide();
            BestScoresLabel.Hide();
            HideScores.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// play button click method. Show the level selector form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
            this.Show();
        }
        /// <summary>
        /// exit button click method. close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// score button click method. Show scores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            showScores();
        }
        /// <summary>
        /// show scores, hide home screen buttons
        /// </summary>
        public void showScores()
        {
            string[] bestScores = File.ReadAllLines("../../../Ressources/score.txt");
            string tab = "          ";//10 spaces
            for (int i = 0; i < Config.NUMBER_OF_LEVELS; i++)
            {
                BestScoresLabel.Text += ("Level " + i + tab + bestScores[i] + "\n");
            }
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            BestScoresTitle.Show();
            BestScoresLabel.Show();
            HideScores.Show();
        }
        /// <summary>
        /// hide the scores and show the home screen button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideScores_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            BestScoresTitle.Hide();
            BestScoresLabel.Hide();
            HideScores.Hide();
            BestScoresLabel.Text = "";
        }
    }
}
