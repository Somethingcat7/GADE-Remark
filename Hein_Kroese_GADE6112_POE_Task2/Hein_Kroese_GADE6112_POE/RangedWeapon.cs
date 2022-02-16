using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class RangedWeapon : Weapon
    {   public enum RangedTypes { Rifle, Longbow}

        public override int getRange { get { return 1; } }



        public RangedWeapon(RangedTypes types,int x = 0, int y = 0) : base(x, y, 'W')
        {
            if (types == RangedTypes.Rifle)
            {
                Damage = 5;
                Durability = 3;
                Cost = 7;
                Range = 5;
            }
            else
            {
                Damage = 4;
                Durability = 4;
                Cost = 6;
                Range = 2;
            }
        }

        public override string ToString()
        {
            return $"{this.Type}";
        }
    }
}
