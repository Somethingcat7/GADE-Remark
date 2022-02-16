using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Shop
    {
        public enum ShopWeapons
        {
            Melee,
            Ranged
        }

        public Weapon[] weaponarray = new Weapon[3];
        public Character Buyer;

        private readonly int amount = 5;
        private readonly int weapontypes = Enum.GetNames(typeof(ShopWeapons)).Length;

        public Weapon[] WeaponArray { set { weaponarray = value; } get { return weaponarray; } }

        

        public Shop(Character Player)
        {
            Buyer = Player;

            for (int i = 0; i < weaponarray.Length; i++)
            {
                while (i != 0 && weaponarray[i] == weaponarray[i - 1])
                {
                    weaponarray[i] = RandomWeapon();
                }
            }
        }

        public Weapon RandomWeapon()
        {
            Item weapon;

            switch (RandomWeaponType())
            {
                case ShopWeapons.Melee:
                    switch (random.Next(0, Enum.GetNames(typeof(MeleeWeapon)).Length))
                    {
                        case (int)MeleeWeapon.MeleeTypes.Dagger: // 0           //casting
                            weapon = new MeleeWeapon(MeleeWeapon.MeleeTypes.Dagger);
                            break;

                        case (int)MeleeWeapon.MeleeTypes.Longsword: // 1
                            weapon = new MeleeWeapon(MeleeWeapon.MeleeTypes.Longsword);
                            break;

                        default:
                            weapon = new MeleeWeapon(MeleeWeapon.MeleeTypes.Dagger);
                            break;
                    }
                    break;
                case ShopWeapons.Ranged:
                    switch (random.Next(0, Enum.GetNames(typeof(RangedWeapon)).Length))
                    {
                        case (int)RangedWeapon.RangedTypes.Rifle:
                            weapon = new RangedWeapon(RangedWeapon.RangedTypes.Rifle);
                            break;

                        case (int)RangedWeapon.RangedTypes.Longbow:
                            weapon = new RangedWeapon(RangedWeapon.RangedTypes.Longbow);
                            break;

                        default:
                            weapon = new RangedWeapon(RangedWeapon.RangedTypes.Rifle);
                            break;
                    }
                    break;
                default:
                    return null;

            }

            return (Weapon)weapon;
        }

        public ShopWeapons RandomWeaponType()
        {
            random = new Random();
            int num = random.Next(0, weapontypes);

            if (num == (int)ShopWeapons.Melee)
            {
                return ShopWeapons.Melee;
            }
            else if (num == (int)ShopWeapons.Ranged)
            {
                return ShopWeapons.Ranged;
            }
            else
            {
                return default;
            }
        }

        Random random = new Random();
        public void Buy(int num)
        {
            Buyer.getGoldAmount-= num;

            for (int i = 0; i < weaponarray.Length; i++)
            {
                if (num == weaponarray[i].getCost)
                {
                    Buyer.Pickup(weaponarray[i]);
                    Buyer.Equip(weaponarray[i]);
                    weaponarray[i] = RandomWeapon();
                    break;
                }
            }
        }

        public bool CanBuy(int num)
        {
            if (Buyer.getGoldAmount >= num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string DisplayWeapon(int num)
        {
            return "Buy Weapon type " + num.ToString();
        }

        public string FillShop(int num)
        {
            switch (num)
            {
                case 3:
                    return $"Buy Dagger for {num}$";
                case 4:
                    return $"Buy Longsword for {num}$";
                case 5:
                    return $"Buy Longbow for {num}$";
                case 6:
                    return $"Buy Rifle for {num}$";
                default:
                    return $"";
            }
        }

    } 

}     



