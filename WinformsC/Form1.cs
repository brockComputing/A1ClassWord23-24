namespace WinformsC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int age;
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
            button1.Text = "bye";
            string theName = txtName.Text;
            age =Convert.ToInt32(txtAge.Text);
            if (age > 100)
            {
                label1.Text = $"{theName} you are old";
            }
            else
            {
                label1.Text = " you are not old";
            }
            button1.Text = theName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "hi ya";
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEx2 frm = new frmEx2();
            frm.ShowDialog();
        }
        Brush brush = new SolidBrush(Color.Red);
        SolidBrush solidBrush = new SolidBrush(Color.Red);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(solidBrush, 100, 100, 100, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            solidBrush.Color = Color.Green;
            Invalidate ();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}