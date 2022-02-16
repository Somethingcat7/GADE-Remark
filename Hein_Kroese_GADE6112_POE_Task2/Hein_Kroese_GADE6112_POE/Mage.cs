using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Mage : Enemy 
    {   //Mage constructor
        public Mage(int x, int y) : base(x, y, 'M', 5, 5)
        {
            this.Purse = 3;
        }

        public override MovementEnum ReturnMove(MovementEnum move = MovementEnum.Idle)
        {
           return MovementEnum.Idle;
        }

        public override bool CheckRange(Character target)
        {
            bool canAttack;

            bool checkDiagonal(Character Target)
            {
                bool isInRange = true; 

               
                if (Math.Abs(this.gety - Target.gety) == 2 || Math.Abs(this.getx - Target.getx) == 2)
                {
                    isInRange = false;
                }

                return isInRange;
            }

            if (distanceTo(target) == 1) // I.E up, down, left, right is fine
            {
                canAttack = true;
            }

            else if (distanceTo(target) == 2) // need to cancel out if distance is 2 horizontally or vertically
            {
                //check if distance is 2 horizontally and vertically
                if (checkDiagonal(target))
                {
                    canAttack = true;
                }

                else
                {
                    canAttack = false;
                }
            }
            else
            {
                canAttack = false;
            }
            return canAttack;
        }

    }
}
