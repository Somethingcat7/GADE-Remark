using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Leader : Enemy
    {

        Hero hero = new Hero(1,1);

        public Leader(int x, int y) : base(x, y, 'L', 20, 2)
        {
            this.Purse = 2;
            this.weapon = new MeleeWeapon(MeleeWeapon.MeleeTypes.Longsword);
        }
        

        public bool CheckValidMove(MovementEnum Charactermove)
        {
            {
                bool valid = false;

                switch (Charactermove)
                {
                    case MovementEnum.Right:
                        if (VisionArray[2].GetType() == typeof(EmptyTile) || VisionArray[2].GetType() == typeof(Gold))
                        {
                            valid = true;
                            break;
                        }
                        break;
                    case MovementEnum.Left:
                        if (VisionArray[3].GetType() == typeof(EmptyTile) || VisionArray[3].GetType() == typeof(Gold))
                        {
                            valid = true;
                            break;
                        }
                        break;
                    case MovementEnum.Down:
                        if (VisionArray[1].GetType() == typeof(EmptyTile) || VisionArray[1].GetType() == typeof(Gold))
                        {
                            valid = true;
                            break;
                        }
                        break;
                    case MovementEnum.Up:
                        if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold))
                        {
                            valid = true;
                            break;
                        }
                        break;
                }
                return valid;
            }
        }
        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.Idle)
        {
            if (CheckValidMove(move))
            {
                if (x > hero.getx)
                {
                    return MovementEnum.Left;
                }

            else if (x < hero.getx)
            {
                return MovementEnum.Right;
            }
            else if (y > hero.gety)
            {
                return MovementEnum.Up;
            }
            else if (y < hero.gety)
            {
                return MovementEnum.Down;
            }
            else
            {
                return MovementEnum.Idle;
            }   
           
            }
           else return MovementEnum.Idle;
 
        }

    }
}
