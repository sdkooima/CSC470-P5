using System;
using System.Windows.Forms;

namespace P3_code
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FakeAppUserRepository loginRepo = new FakeAppUserRepository();
            bool madeIt = loginRepo.Login(UsernameTextbox.Text, PasswordTextbox.Text);
            if (madeIt) Close();
            DialogResult = DialogResult.OK;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
