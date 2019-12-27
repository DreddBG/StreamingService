using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATICMethodsGUpta
{
    public class Members
    {

        private string name;
        private string email;
        private string adress;
        private List<Songs> FavoriteSongs = new List<Songs>();

        public Members (string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public Members(string name, string email, string adress)
        {
            this.name = name;
            this.email = email;
            this.adress = adress;
        }

        public bool CheckEmail(string email)
        {
            if (email == this.email) return true;
            else return false;
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
            var output = new List<string>();
            FavoriteSongs.ForEach(x => output.Add(x.GetName()));

            return $"{this.name} => {string.Join(", ", output)}";
        }
        public string GetInfo()
        {
            return $"{name}, {email}, {adress}";
        }
    }
}
