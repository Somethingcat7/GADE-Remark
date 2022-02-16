using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class MeleeWeapon : Weapon
    { public enum MeleeTypes { Dagger, Longsword }

        public override int getRange { get { return 1; } }
        Random Randumb = new Random();

        public MeleeWeapon(MeleeTypes types, int x = 0, int y = 0) : base(x, y, 'W')
        {

            if (types == MeleeTypes.Dagger)
            {
                Damage = 3;
                Durability = 10;
                Cost = 3;
            }
            else
            {
                Damage = 4;
                Durability = 6;
                Cost = 5;
            }
        }
        
        public override string ToString()
        {
            return $"{this.Type}";
        }

        
    }
}
