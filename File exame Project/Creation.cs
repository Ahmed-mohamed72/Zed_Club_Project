using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_exame_Project
{
    public partial class FrmCreation : Form
    {
        public FrmCreation()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // string to get path 
            string s =txtCreat.Text;
            // object form class dirctory  
            DirectoryInfo directoryInfo = new DirectoryInfo(s);
            if (directoryInfo.Exists)
            {
                // if the folder id exist so cout<< "folder exsist"
                MessageBox.Show("floder exsist", "infomation");

            }
            else
            {
                directoryInfo.Create();
                MessageBox.Show("floder Crated", "infomation");
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] s = Directory.GetDirectories(txtCreat.Text);
            ShowFolderAndFile.Items.Clear();
            ShowFolderAndFile.Items.AddRange(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] s = Directory.GetFiles(txtCreat.Text);
            ShowFolderAndFile.Items.Clear();
            ShowFolderAndFile.Items.AddRange(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {// we use to string to convert form object to string
         // // rich box because we need to show content 
            richShowContent.Text = File.ReadAllText(ShowFolderAndFile.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmChoose frmChoose = new frmChoose();
            this.Hide();
            frmChoose.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmCreation_Load(object sender, EventArgs e)
        {

        }
    }
}
