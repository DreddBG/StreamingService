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
        public Songs[] Music;
        public Users[] User;



        public Regulator(string name)
        {
            this.name = name;
        }
        public void AddSong(string singer, string title, int duration)
        {
            int id = 0;
            Music = new Songs[100];
            Music[id] = new Songs(singer, title, id++, duration);

        }
        public Songs GetSong(int id)
        {
            return Music[id].GetInfo();
        }
        public Songs[] GetSongs()
        {

        }
        public Songs[] GetSongs(string artist)
        {

        }
        public void AddUser(string name, string email, string adress)
        {
            int id = 0;
            User[id] = new Users(name, email, adress);
            id++;
        }
        public Users GetUser(string email)
        {
            foreach(Users user in User)
            {
               return user;
            }
           
            //for (int i = 0; i < User.Length; i++)
            //{
            //    if (User[i].Equals(email))
            //    {
            //        return User[i];
            //    }
            //}

        }
        public Users[] GetUsers()
        {
                      foreach(Users user in User)
            {
               return user;
            }
        }
        public string GetInfo()
        {
           return 
        }
    }
}
