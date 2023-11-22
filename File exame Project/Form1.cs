using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_exame_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "1";
            string emal = "2";
            string phone = "3";
            string pass = "4";
            if (txtName.Text ==name&&txtPassword.Text==emal )
            {
                frmChoose obj = new frmChoose();
                obj.Show();
                this.Hide();
            }
            else if(txtName.Text == phone && txtPassword.Text == pass)
            {
                FrmCreation obj = new FrmCreation();
                this.Hide();
                obj.Show();
            }
            else MessageBox.Show("not valid pass", "information");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
