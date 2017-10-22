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
        private int hp = 10;
        private BodyParts blocked;

        public delegate void eventHandler(object sender);

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
                hp -= 10;
                Wound?.Invoke(this);

                if (hp <= 0)
                {
                    hp = 0;
                    Death?.Invoke(this);
                }
            }
            else {
                Block?.Invoke(this);
            }
        }
    }
}
