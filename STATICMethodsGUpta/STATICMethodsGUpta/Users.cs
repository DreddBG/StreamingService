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
        public List<Songs> FavoriteSongs;

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
        public void AddSongToFavorites(Songs song)
        {
            FavoriteSongs.Add(song);
        }
        public void RemoveSongFromFavorites(int index)
        {
            FavoriteSongs.RemoveAt(index);
        }
        public string GetFavoriteSongs()
        {
            return string.Join(" ,", FavoriteSongs);
        }
    }
}
