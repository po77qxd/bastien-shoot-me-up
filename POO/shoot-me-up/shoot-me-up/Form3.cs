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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = 0;
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void level1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(Config.NUMBER_ENNEMIES_LEVEL1, Config.NUMBER_OBSTACLES_LEVEL1, 1).ShowDialog();
            this.Show();
        }

        private void level2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(Config.NUMBER_ENNEMIES_LEVEL2, Config.NUMBER_OBSTACLES_LEVEL2, 2).ShowDialog();
            this.Show();
        }

        private void level0_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game(Config.NUMBER_ENNEMIES_LEVEL0, Config.NUMBER_OBSTACLES_LEVEL0, 0).ShowDialog();
            this.Show();
        }
    }
}
