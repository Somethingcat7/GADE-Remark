using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    abstract class Weapon : Item
    {
        protected Weapon(int x, int y, char symbol) : base(x, y, symbol)
        {

        }

        protected int Damage;
        protected int Range;
        protected int Durability;
        protected int Cost;
        protected string Type;

        public int getDamage { set { Damage = value; } get { return Damage; } }
        public virtual int getRange { set { Range = value; } get { return Range; } }
        public int getCost { set { Cost = value; } get { return Cost; } }
        public string getType { set { Type = value; } get { return Type; } }
        public int getDurability { set { Durability = value; } get { return Durability; } }
    }
}
