using Microsoft.VisualBasic.ApplicationServices;

namespace RWA
{
    public partial class Form1 : Form
    {
        string user = "eugen";
        string pasword = "deur";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == user && txtPassword.Text == pasword)
            {
                MessageBox.Show("welcome");

            }
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("wrong");
            }
            if (txtUser.Text != user || txtPassword.Text != pasword)
            {
                MessageBox.Show("Wrong password");
            }
        }
    }
}
