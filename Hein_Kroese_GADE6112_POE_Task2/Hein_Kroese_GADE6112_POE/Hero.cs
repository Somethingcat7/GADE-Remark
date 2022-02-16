using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    //Subclass Player to class Character
    class Hero : Character
    {

        public Hero(int x, int y) : base(x, y, 'H', 10, 0)
        {

        }
        public int getX {set { x = value; } get{ return x; } }
        public override void Attack(Character target)
        {
            target.gethealth = target.gethealth - 5;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            MovementEnum movement = MovementEnum.Idle;

            switch (move)
            {
                //move up
                case Character.MovementEnum.Up:
                    if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold) || VisionArray[0].GetType() == typeof(MeleeWeapon) || VisionArray[0].GetType() == typeof(RangedWeapon))
                    {
                        movement = MovementEnum.Up;
                    }
                    break;

                //move down
                case Character.MovementEnum.Down:
                    if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold) || VisionArray[0].GetType() == typeof(MeleeWeapon) || VisionArray[0].GetType() == typeof(RangedWeapon))
                    {
                        movement = MovementEnum.Down;
                    }
                    break;

                //move left
                case Character.MovementEnum.Left:
                    if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold) || VisionArray[0].GetType() == typeof(MeleeWeapon) || VisionArray[0].GetType() == typeof(RangedWeapon))
                    {
                        movement = MovementEnum.Left;
                    }
                    break;

                //move right
                case Character.MovementEnum.Right:
                    if (VisionArray[0].GetType() == typeof(EmptyTile) || VisionArray[0].GetType() == typeof(Gold) || VisionArray[0].GetType() == typeof(MeleeWeapon) || VisionArray[0].GetType() == typeof(RangedWeapon))
                    {
                        movement = MovementEnum.Right;
                    }
                    break;

                default:
                    movement = MovementEnum.Idle;
                    break;
            }

            return movement;
        }

        public override string ToString()
        {
            string Info = "Player Stats: \n";
            Info += "Hp: " + Health.ToString() + "/" + MaxHealth.ToString() + "\n";
            Info += "Damage: " + Damage.ToString() + "\n";
            Info += "Gold: " + Purse.ToString() + "\n";
            Info += "[" + x.ToString() + "," + y.ToString() + "]";
            return Info;
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
    }
}
