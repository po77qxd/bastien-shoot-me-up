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
        //play button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().ShowDialog();
            this.Show();
        }
        //exit button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //score button
        private void button2_Click(object sender, EventArgs e)
        {
            showScores();
        }
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
