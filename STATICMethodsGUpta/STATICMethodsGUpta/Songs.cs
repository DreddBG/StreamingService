using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STATICMethodsGUpta
{
    public class Songs
    {
        public string name;
        public string singer;
        public int id;
        public int duration;

        public Songs(string name, string singer, int id, int duration)
        {
            this.name = name;
            this.singer = singer;
            this.id = id;
            this.duration = duration;
        }
        public int GetId()
        {
            return id;
        }
        public string GetSinger()
        {
            return singer;
        }
        public string GetInfo()
        {
            return $"ID {this.id}: {this.singer} - {this.name} ({this.duration}) seconds";      
        }
    }
}
