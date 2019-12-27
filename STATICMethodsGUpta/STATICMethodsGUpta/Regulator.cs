using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace STATICMethodsGUpta
{
    public class Regulator
    {
        private string name;
        public List<Songs> Music = new List<Songs>();
        public List<Members> Users = new List<Members>();

        public Regulator(string name)
        {
            this.name = name;
        }
        public void AddSong(string singer, string title, int duration)
        {
            var rang = new Random();
            var randNum = rang.Next(0, 100);
            Songs song = new Songs(singer, title, randNum, duration);
            Music.Add(song);
        }
        public Songs GetSong(int id)
        {
            return Music.Where(x => x.GetId() == id).FirstOrDefault();
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
                if (song.GetSinger() == artist)
                {
                    temp.Add(song);
                }
            }

            return temp.ToArray();
        }
        public void AddUser(string name, string email, string adress)
        {
            var curUser = new Members(name, email, adress);
            Users.Add(curUser);
        }
        public Members GetUser(string email)
        {
            foreach (Members user in Users)
            {
                if(user.CheckEmail(email))
                {
                    return user;
                }
            }
            return null;
        }
        public Members[] GetUsers()
        {
            return Users.ToArray();
        }
        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({Music.Count} songs & {Users.Count})";
        }
    }
}
