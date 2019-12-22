using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATICMethodsGUpta
{
    public class Users
    {

        private string name;
        private string email;
        private string adress;

        public Users (string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public Users(string name, string email, string adress)
        {
            this.name = name;
            this.email = email;
            this.adress = adress;
        }
        public void AddSongToFavorites(string song)
        {

        }
        public void RemoveSongFromFavorites(int index)
        {

        }
        public string GetFavoriteSongs()
        {
            return;
        }
    }
}
