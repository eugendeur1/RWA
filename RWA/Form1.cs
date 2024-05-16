using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == user && txtPassword.Text == pasword)
            {
                MessageBox.Show("welcome");

            }
            else if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("wrong");
            }
            else if (txtUser.Text != user || txtPassword.Text != pasword)
            {
                MessageBox.Show("Wrong pasword");
            }
            if (txtUser.Text == user && txtPassword.Text == pasword)
            {
                Pass frmStudents = new Pass();
                Hide();
                frmStudents.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
