using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class Player
    {
        private string name;
        private int hp = 100;
        private BodyParts blocked;
        private int power = 20;

        public delegate void eventHandler(object sender, PlayerEventArgs args);

        public event eventHandler Block;
        public event eventHandler Wound;
        public event eventHandler Death;

        public string Name { get { return name; } }
        public int Hp { get { return hp; } }
        public BodyParts Blocked { get { return blocked; } }

        public Player(string name) {
            this.name = name;
        }

        public void SetBlock(BodyParts part) {
            blocked = part;
        }

        public void GetHit(BodyParts part) {
            if (part != Blocked)
            {
                hp -= power;
                Wound?.Invoke(this, new PlayerEventArgs(Name, hp, power));

                if (hp <= 0)
                {
                    hp = 0;
                    Death?.Invoke(this, new PlayerEventArgs(Name, hp, 0));
                }
            }
            else {
                Block?.Invoke(this, new PlayerEventArgs(Name, hp, 0));
            }
        }
    }
}
