namespace WinFormsF
{
    public partial class Form1 : Form
    {
        string thename;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text  = "click this please";
            
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            thename = txtName.Text;
            int theAge = Convert.ToInt32(txtage.Text);
            bool hasHair = chkHasHair.Checked;
            thename = "prof " + thename;
            lblAnswer.Text = thename;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEx2 ex2 = new frmEx2();
            ex2.ShowDialog();
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
        Random rnd = new Random();  
        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }
}