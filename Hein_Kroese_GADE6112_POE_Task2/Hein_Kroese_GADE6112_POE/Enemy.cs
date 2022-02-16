using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    //Subclass Enemy to class Character
    abstract class Enemy : Character
    {
        protected Random RanNum = new Random();

        protected Enemy(int x, int y, char symbol, int maxHP, int damage) : base(x, y, symbol, maxHP, damage)
        {
            
        }

        public int Coords(int min, int max)
        {
            return RanNum.Next(min, max);
        }

       

        public override void Attack(Character target)
        {
            target.gethealth = target.gethealth - 5;
        }

        public override string ToString()
        {
            string equipState;
            bool isEquipped;

            if (this.weapon == null)
            {
                equipState = "Barehanded:";
                isEquipped = false;
            }

            else
            {
                equipState = "Equipped:";
                isEquipped = true;
            }

            if (isEquipped)
            {
                // Equipped: Leader (20/20HP) at [6, 1] with Longsword
                return $"{equipState} {this.GetType().Name}\n at [{this.x}, {this.y}] with {this.weapon.ToString()}\n({this.weapon.getDurability * this.weapon.getDamage})";
            }

            else
            {
                // Barehanded: Mage (5/5HP) at [6, 6] (5 DMG)
                return $"{equipState} {this.GetType().Name}\n at [{this.x}, {this.y}] ({this.getDamage} DMG)";
            }
        }

    }
}