using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatoriskOpgave1;

namespace ObligatoriskOpgave4.Managers
{
    public class FootballPlayersManager
    {
        private static int _nextId = 1;
        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>()
        {
            new FootballPlayer() { Id = _nextId++,Name = "Mads", Price = 1, ShirtNumber = 99},
            new FootballPlayer() {Id = _nextId++, Name = "Hans", Price = 20, ShirtNumber = 5}
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }

        public FootballPlayer GetById(int id)
        {
            return Data.Find(fp => fp.Id == id);
        }

        public FootballPlayer Add(FootballPlayer fp)
        {
            fp.Id = _nextId++;
            Data.Add(fp);
            return fp;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer fp = Data.Find(fp1 => fp1.Id == id);
            if (fp == null) return null;
            Data.Remove(fp);
            return fp;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer fp = Data.Find(fp1 => fp1.Id == id);
            if (fp == null) return null;
            fp.Name = updates.Name;
            fp.Price = updates.Price;
            fp.ShirtNumber = updates.ShirtNumber;
            return fp;
        }
    }
}
