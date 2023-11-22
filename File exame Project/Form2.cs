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
    public partial class frmChoose : Form
    {
        public frmChoose()
        {
            InitializeComponent();
        }

        private void btnFootball_Click(object sender, EventArgs e)
        {
            frmfootball frmfootball = new frmfootball();
            frmfootball.Show();
            this.Hide();
        }

        private void btnTenneis_Click(object sender, EventArgs e)
        {
            frmUpdate obj = new frmUpdate();
            obj.Show();
            this.Hide();

        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            frmDelete form6 = new frmDelete();
            form6.Show();
            this.Hide();
        }

        private void btnVolley_Click(object sender, EventArgs e)
        {
            FrmCreation frmCreation = new FrmCreation();
            frmCreation.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
