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

        //public event  Block;

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
            if (part != blocked)
                hp -= 10;
        }
    }
}
