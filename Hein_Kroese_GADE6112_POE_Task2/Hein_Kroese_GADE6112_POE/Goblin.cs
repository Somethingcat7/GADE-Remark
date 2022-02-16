using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    //Subclass Goblin to class Enemy
    class Goblin : Enemy
    {
        public Goblin(int x, int y) : base(x, y, 'G', 10, 2)
        {
            this.Purse = 1;
            //this.weapon = new MeleeWeapon(MeleeWeapon.MeleeTypes.Dagger);
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            MovementEnum moveDirect = MovementEnum.Idle;

            switch (move)
            {
                case MovementEnum.Right:
                    if (VisionArray[2].GetType() == typeof(EmptyTile) || VisionArray[2].GetType() == typeof(Gold) || VisionArray[2].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[2].GetType() != typeof(Hero))
                        {
                            moveDirect = MovementEnum.Right;
                        }
                    }
                    break;
                case MovementEnum.Left:
                    if (VisionArray[3].GetType() == typeof(EmptyTile) || VisionArray[3].GetType() == typeof(Gold) || VisionArray[3].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[3].GetType() != typeof(Hero))
                        {
                            moveDirect = MovementEnum.Left;
                        }
                    }
                    break;
                case MovementEnum.Down:
                    if (VisionArray[1].GetType() == typeof(EmptyTile) || VisionArray[1].GetType() == typeof(Gold) || VisionArray[1].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[1].GetType() != typeof(Hero))
                        {
                            moveDirect = MovementEnum.Down;
                        }
                    }
                    break;
                case MovementEnum.Up:
                    if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold) || VisionArray[0].GetType() == typeof(Weapon))
                    {
                        if (VisionArray[0].GetType() != typeof(Hero))
                        {
                            moveDirect = MovementEnum.Up;
                        }
                    }
                    break;
            }

            return moveDirect;
        }

        /*public override string ToString()
        {
            return "Goblin at: [" + x.ToString() + ", " + y.ToString() + "] " +  Damage.ToString();
        }*/

    }
}
