using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public class PlayerEventArgs : EventArgs
    {
        public string name;
        public int hp;
        public int power;

        public PlayerEventArgs(string Name, int Hp, int Power) {
            name = Name;
            hp = Hp;
            power = Power;
        }
    }
}
