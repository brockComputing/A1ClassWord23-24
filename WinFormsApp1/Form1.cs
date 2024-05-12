using System.Numerics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Vector2 location = new Vector2();
        Vector2 velocoty = new Vector2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            timer1.Enabled = true;
            timer1.Interval = 20;
            location.X = this.Width / 2;
            location.Y = this.Height / 2;
            velocoty.X = 1;
            velocoty.Y = 4;
            this.DoubleBuffered = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aquamarine;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            location = location + velocoty;
            e.Graphics.FillEllipse(Brushes.BlueViolet, location.X, location.Y, 120, 120);
        }
    }
}
