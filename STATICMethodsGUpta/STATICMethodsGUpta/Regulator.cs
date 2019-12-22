using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATICMethodsGUpta
{
    public class Regulator
    {
        private int songSeeder = 1;
        private string name;
        public List<Songs> Music;
        public Users[] User;

        public Regulator(string name)
        {
            this.name = name;
        }
        public void AddSong(string singer, string title, int duration)
        {
            int id = 0;
            Songs song = new Songs(singer, title, id++, duration);
            Music[id] = song;
        }
        public Songs GetSong(int id)
        {
            return Music.Where(x => x.id == id).FirstOrDefault();
        }
        public Songs[] GetSongs()
        {
            return Music.ToArray();
        }
        public Songs[] GetSongs(string artist)
        {
            var temp = new List<Songs>();

            foreach (var song in Music)
            {
                if (song.singer == artist)
                {
                    temp.Add(song);
                }
            }

            return temp.ToArray();
        }
        public void AddUser(string name, string email, string adress)
        {
            int id = 0;
            User[id] = new Users(name, email, adress);
            id++;
        }
        public Users GetUser(string email)
        {
            foreach (Users user in User)
            {
                if(user.email == email)
                {
                    return user;
                }
            }
            return null;
        }
        public Users[] GetUsers()
        {
            return User;
        }
        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({Music.Count} songs & {User.Length})";
        }
    }
}
