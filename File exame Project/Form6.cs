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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void UpdatPlyer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] playerarr = File.ReadAllLines("d:\\Players");
            string[]x= new string[playerarr.Length-1];
            int j = 0;
            for(int i=0;i<playerarr.Length;i++)
            {
                if(i==ListBefor.SelectedIndex)
                {
                    continue;
                }
                x[j++] = playerarr[i];
            }
            File.WriteAllLines("d:\\Players", x);

            MessageBox.Show("player deleted", "inofrmation");

            listAfter.Items.Clear();
            listAfter.Items.AddRange(File.ReadAllLines("d:\\Players"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.ReadAllLines("d:\\Players") == null)
                MessageBox.Show("Ther's No Player to delete", "information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            ListBefor.Items.Clear();
            ListBefor.Items.AddRange(File.ReadAllLines("d:\\Players"));
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listAfter.Items.Clear();
            listAfter.Items.AddRange(File.ReadAllLines("d:\\Players"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmChoose frmChoose = new frmChoose();
            frmChoose.Show();
            this.Hide();
        }

        private void listAfter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBefor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ListBefor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string c = ListBefor.SelectedItem.ToString();
            string[] arr = c.Split(',');
            txtNamePlay.Text = arr[0];
            txtAgePlayer.Text = arr[1];
            txtnumplayer.Text = arr[2];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
