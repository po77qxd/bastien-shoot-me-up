using System.ComponentModel;
using System.Windows.Forms;

namespace shoot_me_up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customPictureBox1_Click(object sender, EventArgs e)
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

    public class CustomPictureBox : PictureBox
    {
        public CustomPictureBox(IContainer container)
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

            if (e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
                if (!(x > (this.Parent.Size.Width - this.Size.Width - 10)))
                {
                    x += 5;
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (!(x < -10))
                {
                    x -= 5;
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (!(y < 10))
                {
                    y -= 5;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (!(y > (this.Parent.Size.Height - this.Size.Height - 50)))
                {
                    y += 5;
                }
            }
            else if (e.KeyCode != Keys.Space) {
                // tirer un missile
                Missile missile = new Missile();
            }

            // Update the PictureBox location
            this.Location = new Point(x, y);
            base.OnPreviewKeyDown(e);
        }
    }

    class Missile { 

        public Missile() {
            int x = 20;
            int y = 10;
            while (true)
            {
                x += 1;
            }
        }
    }
}