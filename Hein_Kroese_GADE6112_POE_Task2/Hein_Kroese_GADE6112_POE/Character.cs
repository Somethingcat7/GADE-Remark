using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    abstract class Character : Tile
    {   //Variables
        protected int Health;
        protected int MaxHealth;
        protected int Damage;
        protected int Purse = 0;

        protected Weapon weapon;
               
        //Accessor for variables Health, MaxHealth, Damage, Tile Type, Vision and Movement
        public int gethealth { set { Health = value; } get { return Health; } }
        public int getMaxHealth { set { MaxHealth = value; } get { return MaxHealth; } }
        public int getDamage { set { Damage = value; } get { return Damage; } }
        public int getGoldAmount { set{ Purse = value; } get{ return Purse; } }
        public Weapon Weapon { get { return weapon; } }
        
        //Movement Enums
        public enum MovementEnum
        {
            Idle,
            Up,
            Down,
            Left,
            Right
        }
        
        //Set values for variables
        public Character(int x, int y, char symbol, int maxHealth, int damage) : base(x, y, symbol)
        {
            Health = maxHealth;
            MaxHealth = maxHealth;
            Damage = damage;                      
        }
       
        public int distanceTo(Character character) 
        {
            int calcDistance(int first, int last)
            {
                int distance = last - first;
                return Math.Abs(distance);
            }

            return calcDistance(x, character.x) + calcDistance(y, character.y);
        }
        public int distanceTo(Tile item)
        {
            int calcDistance(int first, int last)
            {
                int distance = last - first;
                return Math.Abs(distance);
            }

            return calcDistance(x, item.getx) + calcDistance(y, item.gety);
        }

        //Method for character attack
        public virtual void Attack(Character target)
        {
            target.Health -= Damage;
        }
        //Check if player is dead
        public bool isDead() 
        {           
            if (this.Health <= 0) 
            {
              return true;
            } 
            else
            {
              return false;
            }
 
        }
       //Check range between player and target
        public virtual bool CheckRange(Character Target)
        {
            bool Able = false;

            if (weapon == null)
            {
                if (distanceTo(Target) == 1 || distanceTo(Target) == 0)
                {
                    Able = true;
                }
            }
            else if(weapon.GetType() == typeof(MeleeWeapon))
            {
                if (distanceTo(Target) == 1 || distanceTo(Target) == 0)
                {
                    Able = true;
                }
            }
            else if (weapon.GetType() == typeof(RangedWeapon))
            {
                bool diaganal(Character target, int range)
                {
                    bool inRange = true;

                    if (Math.Abs(y - target.y) == range + 1 || Math.Abs(x = target.x) == range + 1)
                    {
                        inRange = false;
                    }

                    return inRange;
                }

                if (weapon.getRange == 2)
                {
                    if (distanceTo(Target) <= 2)
                    {
                        Able = true;
                    }
                    else if (distanceTo(Target) == 3)
                    {
                        if (diaganal(Target, weapon.getRange + 1))
                        {
                            Able = true;
                        }
                        else
                        {
                            Able = false;
                        }
                    }
                    else if (distanceTo(Target) == 4)
                    {
                        if (diaganal(Target, weapon.getRange + 2))
                        {
                            Able = true;
                        }
                        else
                        {
                            Able = false;
                        }
                    }
                    else
                    {
                        Able = false;
                    }
                }
                else if (weapon.getRange == 3)
                {
                    if (distanceTo(Target) <= weapon.getRange)
                    {
                        Able = true;
                    }
                    else if (distanceTo(Target) == 4)
                    {
                        if (diaganal(Target, weapon.getRange + 1))
                        {
                            Able = true;
                        }
                        else
                        {
                            Able = false;
                        }
                    }
                    else if (distanceTo(Target) == 5)
                    {
                        if (diaganal(Target, weapon.getRange + 2))
                        {
                            Able = true;
                        }
                        else
                        {
                            Able = false;
                        }
                    }
                    else if (distanceTo(Target) == 6)
                    {
                        if (diaganal(Target, weapon.getRange + 2))
                        {
                            Able = true;
                        }
                        else
                        {
                            Able = false;
                        }
                    }
                    else
                    {
                        Able = false;
                    }
                }


            }
            else
            {
                Able = false;
            }

            return Able;
        }

        public virtual bool CheckRange(Gold Target)
        {
            bool ableToPickup;

            if (distanceTo(Target) == 1)
            {
                ableToPickup = true;
            }
            else
            {
                ableToPickup = false;
            }

            return ableToPickup;
        }

        //Hero vision array
        public Tile[] VisionArray { set { visionArray = value; } get { return visionArray; } }
        private Tile[] visionArray = new Tile[4];
        //Gold pickup
        public void Pickup(Gold i)
        {
            if (i.GetType() == typeof(Gold))
            {
                Random random = new Random();
                Purse += random.Next(1, i.MaxGold + 1);
                i.PickUp = true;
            }
        }
        //Weapon pickup
        public void Pickup(Weapon i)
        {
            if (i.GetType() == typeof(Weapon))
            {
                i.PickUp = true;
            }
        }
        //Equip weapon
        public void Equip(Weapon i)
        {
            this.weapon = i;
        }
        public void Move(MovementEnum move)
        {
            switch (move)
            {
                case MovementEnum.Up:
                    x -= 1;
                    break;
                case MovementEnum.Down:
                    x += 1;
                    break;
                case MovementEnum.Left:
                    y -= 1;
                    break;
                case MovementEnum.Right:
                    y += 1;
                    break;
                case MovementEnum.Idle:
                    break;
            }
        }
        
        public abstract MovementEnum ReturnMove(MovementEnum move = MovementEnum.Idle);

        public abstract override string ToString();
    }
}
