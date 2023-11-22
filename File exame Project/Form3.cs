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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }
        void Show()
        {
            ListShowPlayer.Items.Clear();
            ListShowPlayer.Items.AddRange(File.ReadAllLines("d:\\Players"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtNamePlay.Text;
            string age = txtAgePlayer.Text;
            string num = txtnumplayer.Text;

            string player = name +"," + age+"," + num ;
            string[] playerarr = File.ReadAllLines("d:\\Players");
            playerarr[ListShowPlayer.SelectedIndex]=player;
            File.WriteAllLines("d:\\Players", playerarr);

            MessageBox.Show("player Updated", "inofrmation");

            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListShowPlayer.Items.Clear();
            ListShowPlayer.Items.AddRange(File.ReadAllLines("d:\\Players"));
        }

        private void ListShowPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = ListShowPlayer.SelectedItem.ToString();
            string[] y = x.Split(',');
            txtNamePlay.Text = y[0];
            txtAgePlayer.Text = y[1];
            txtnumplayer.Text = y[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDelete form6 = new frmDelete();
            form6.Show();
            this.Hide();
        }

        private void frmvolley_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] arr = File.ReadAllLines("d:\\Players");
            if (txtSearch.Text == "")
                MessageBox.Show("Enter what you want to searsh for", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string search = txtSearch.Text;
                ListShowPlayer.Items.Clear();
                bool f = false;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Contains(search))
                    {
                        f = true;
                        ListShowPlayer.Items.Add(arr[i]);
                    }

                }
                if (!f)
                { 
                    MessageBox.Show("No player like this", "information");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
