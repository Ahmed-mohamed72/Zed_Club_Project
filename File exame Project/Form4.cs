using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_exame_Project
{
    public partial class frmfootball : Form
    {
        public frmfootball()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            File.AppendAllLines("d:\\Archive.txt", File.ReadAllLines("D:\\ coach.txt"));
            if (txtnamecoach.Text == "")
            {
                MessageBox.Show("pleas enter the Name of Coach", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                File.WriteAllText("D:\\ coach.txt", txtnamecoach.Text + "\n");
                MessageBox.Show("Coach Changed", "information");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtNamePlay.Text;
            string age = txtAgePlayer.Text;
            string num = txtnumplayer.Text;
            string player = name + "," + age + "," + num + "\n";
            if (name == "" || age == "" || num == "")
            {
                MessageBox.Show("pleas complet your information", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                File.AppendAllText("d:\\Players", player);
                MessageBox.Show("player is added", "information");
                if (File.ReadAllLines("d:\\injPlayer") != null)
                {
                    if (ListShowInjPlayer.SelectedIndex >= 0)
                    {
                        string[] s = File.ReadAllLines("d:\\injPlayer");
                        string[] h = new string[s.Length - 1];
                        int j = 0;
                        bool f = false;

                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i == ListShowInjPlayer.SelectedIndex)
                            {
                                continue; f = true;
                            }
                            h[j++] = s[i];
                        }
                        File.WriteAllLines("d:\\injPlayer", h);
                    }
                }
            }
        }

        private void btnAddInj_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListShowFullTeam.Items.Clear();
            ListShowFullTeam.Items.AddRange(File.ReadAllLines("d:\\Players"));
        }

        private void sohwCoach_Click(object sender, EventArgs e)
        {
            ListShowFullTeam.Items.Clear();
            ListShowFullTeam.Items.Add(File.ReadAllText("D:\\ coach.txt"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtnameinj.Text;
            string age = txtaginj.Text;
            string num = txtnuminj.Text;
            string player = name + "," + age + "," + num + "\n";
            if (name == "" || age == "" || num == "")
            {
                MessageBox.Show("pleas complet your information", "information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                File.AppendAllText("d:\\injPlayer", player);
                MessageBox.Show("player is added", "information");
                if (File.ReadAllLines("d:\\Players") != null)
                {
                    if (ListShowFullTeam.SelectedIndex >= 0)
                    {
                        string[] s = File.ReadAllLines("d:\\Players");
                        string[] h = new string[s.Length - 1];
                        int j = 0;
                        bool d = false;
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (i == ListShowFullTeam.SelectedIndex)
                            {
                                continue; d = true;
                            }
                            h[j++] = s[i];
                        }
                        File.WriteAllLines("d:\\Players", h);
                    }

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmUpdate obj = new frmUpdate();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListShowInjPlayer.Items.Clear();
            ListShowInjPlayer.Items.AddRange(File.ReadAllLines("d:\\injPlayer"));

        }

        private void ListShowInjPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = ListShowInjPlayer.SelectedItem.ToString();
            string[] y = x.Split(',');
            txtNamePlay.Text = y[0];
            txtAgePlayer.Text = y[1];
            txtnumplayer.Text = y[2];
        }

        private void ListShowFullTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = ListShowFullTeam.SelectedItem.ToString();
            string[] y = x.Split(',');
            txtnameinj.Text = y[0];
            txtaginj.Text = y[1];
            txtnuminj.Text = y[2];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListShowInjPlayer.Items.Clear();
            ListShowInjPlayer.Items.AddRange(File.ReadAllLines("d:\\Archive.txt")) ;
        }
    }
}
