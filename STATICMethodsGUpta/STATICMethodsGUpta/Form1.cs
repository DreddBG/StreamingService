using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using STATICMethodsGUpta;

namespace STATICMethodsGUpta
{
    public partial class Form1 : Form
    {
        Regulator Test;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string name = tbAddName.Text;
            string email = tbEmail.Text;
            string address = tbBoxAdress.Text;

            Test.AddUser(name, email, address);
            UpdateList(lbUsers);
        }

        private void tbAddName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test = new Regulator("Test");
        }

        private void UpdateList(ListBox current)
        {
            current.Items.Clear();
            if (current == lbSongs)
            {
                foreach (var song in Test.Music)
                {
                    current.Items.Add(song.GetInfo());
                }
            }
            else if (current == lbUsers)
            {
                foreach (var user in Test.Users)
                {
                    current.Items.Add(user.GetInfo());
                }
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            int songId = int.Parse(tbFavorite.Text);
            var curSong = Test.Music.Where(x => x.GetId() == songId).FirstOrDefault();
            int selectedUser = lbUsers.SelectedIndex;
            Test.Users[selectedUser].AddSongToFavorites(curSong);

            var favSong = Test.Users[selectedUser].GetFavoriteSongs();
            lbUsers.Items.Add(favSong);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = tbSName.Text;
            string singer = textBox2.Text;
            int duration = int.Parse(tbLength.Text);

            Test.AddSong(singer, title, duration);
        }

        private void tbLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowS_Click(object sender, EventArgs e)
        {
            UpdateList(lbSongs);
        }

        private void btnRemoveS_Click(object sender, EventArgs e)
        {
            var curSong = lbSongs.SelectedIndex;
            Test.Music.RemoveAt(curSong);
            UpdateList(lbSongs);
        }

        private void btnRemoveU_Click(object sender, EventArgs e)
        {

        }
    }
}
