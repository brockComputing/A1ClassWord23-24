namespace WinFormsD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double thesalary;
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.BlueViolet;
            button1.Text = "heloo";
            string thename = txtName.Text;
            string newString = "lsdkfj";
            thename = thename + "s";
            newString = "";
            label1.Text = thename;

            thesalary = Convert.ToDouble(txtSalary.Text);
            button1.Text = thesalary.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.RebeccaPurple;
            thesalary = 0;
      

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEx2 ex2 = new frmEx2();
            ex2.ShowDialog();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 44, 44);
            Invalidate();
        }
        SolidBrush sb = new SolidBrush(Color.Black);
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            sb.Color = Color.FromArgb(100, 100, 100);
            e.Graphics.FillEllipse(sb, 100, 100, 50,50);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                MessageBox.Show("A");
            }
        }
    }
}