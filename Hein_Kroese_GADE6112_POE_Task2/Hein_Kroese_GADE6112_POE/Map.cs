using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Map
    {   //Map size
        private int mapLong;
        private int mapWide;
        
        //Amount of bad peoples
        private int enemynumber;
        
        //Accessors cause yeah, real helpful
        public Hero Player { set{ player = value; } get{ return player; } } 
        public Goblin Gobolobolin { set { Gob = value; } get { return Gob; } }
        public int NumEnemies { set{ enemynumber = value; } get{ return enemynumber; } }
        public int Width { set { mapWide = value; } get { return mapWide; } }
        public int Height { set { mapLong = value; } get { return mapLong; } }
        public Tile[,] Tilemappy { set { theMap = value; } get { return theMap; } }
                
        //Arry things
        public Tile[,] theMap;
        public Enemy[] arrayofenemies;
        public Item[] Itemythings;
        public Weapon[] weapons;
        
        //Player Variable
        private Hero player;
        private Goblin Gob;
               
        //Random number generator
        private Random RanDumb = new Random();

        //Shop
        public Shop shop;

        public Map(int MinHeight, int MinWidth, int MaxHeight, int MaxWidth, int NumEnemies, int NumGold)
        {   
            Random RanDum = new Random();
            
            mapLong = RanDum.Next(MinHeight,MaxHeight + 1);
            mapWide = RanDum.Next(MinWidth, MaxWidth + 1);

            this.NumEnemies = NumEnemies;

            theMap = new Tile[mapWide,mapLong];
           
            //Declare length of arrays
            arrayofenemies = new Enemy[NumEnemies];
            Itemythings = new Item[NumGold];

            FillMap();
            
            //Player created and added
            Player = (Hero)create(Tile.TileType.Hero);
            PlaceTile(Player);

            /*Shop
            shop = new Shop(Player);*/

            //Adding enemies
            for (int i = 0; i < arrayofenemies.Length; i++)
            {
                arrayofenemies[i] = (Enemy)create(Tile.TileType.Enemy);
                PlaceTile(arrayofenemies[i]);
            }
            //Adding gold
            for (int i = 0; i < Itemythings.Length; i++)
            {
                Itemythings[i] = (Item)create(Tile.TileType.Gold);
                Itemythings[i].PickUp = false;
                PlaceTile(Itemythings[i]);
            }

            // Weapons // replace gold in item array here
            for (int i = 0; i < Itemythings.Length; i++)
            {
                bool Changeable;

                // more or less 1/3 chance it gets replaced 
                switch (RanDum.Next(0, 3))
                {
                    case 0:
                        Changeable = true;
                        break;
                    case 1:
                        Changeable = false;
                        break;
                    case 2:
                        Changeable = false;
                        break;
                    default:
                        Changeable = false;
                        break;
                }

                if (Changeable)
                {
                    switch (RanDum.Next(0, 4))
                    {
                        case 0:
                            Itemythings[i] = new MeleeWeapon(MeleeWeapon.MeleeTypes.Dagger, Itemythings[i].getx, Itemythings[i].gety);
                            break;
                        case 1:
                            Itemythings[i] = new MeleeWeapon(MeleeWeapon.MeleeTypes.Longsword, Itemythings[i].getx, Itemythings[i].gety);
                            break;
                        case 2:
                            Itemythings[i] = new RangedWeapon(RangedWeapon.RangedTypes.Longbow, Itemythings[i].getx, Itemythings[i].gety);
                            break;
                        case 3:
                            Itemythings[i] = new RangedWeapon(RangedWeapon.RangedTypes.Rifle, Itemythings[i].getx, Itemythings[i].gety);
                            break;
                        default:
                            break;
                    }
                }

                PlaceTile(Itemythings[i]);
            }

            UpdateVision();
        }
        //Update the map dumbo
        public void updateMap()
        {
            FillMap();

            PlaceTile(Player);

            for (int i = 0; i < arrayofenemies.Length; i++)
            {
                int count = i;

                if (arrayofenemies[i].isDead())
                {
                    arrayofenemies = arrayofenemies.Where((source, index) => index != i).ToArray();
                }
           
            }
            
            for (int i = 0; i < Itemythings.Length; i++)
            {
                    Mappymap[Itemythings[i].getx, Itemythings[i].gety] = Itemythings[i];
            }

            for (int i = 0; i < arrayofenemies.Length; i++)
            {
                PlaceTile(arrayofenemies[i]);
            }

            GetItemAtPosition(Player);
            PlaceTile(Player);

            foreach (var enemy in arrayofenemies)
            {
                if (enemy.CheckRange(player))
                {
                    enemy.Attack(player);
                }

                GetItemAtPosition(enemy);
            }

            foreach (var enemy in arrayofenemies)
            {
                if (enemy.GetType() == typeof(Mage))
                {
                    for (int i = 0; i < arrayofenemies.Length; i++)
                    {
                        if (enemy.CheckRange(arrayofenemies[i]))
                        {
                            enemy.Attack(arrayofenemies[i]);
                        }
                    }
                }
            }

            UpdateVision();
        }
        
        public Tile[,] Mappymap { set { theMap = value; } get { return theMap; } }
       
        //Create the tiles
        private Tile create(Tile.TileType MakingOfTile)
        {
            Random RanDum = new Random();
            int RNGX;
            int RNGY;

            bool IsTileOpen(int x, int y)
            {
                if (theMap[x,y].GetType() != typeof(EmptyTile))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            switch(MakingOfTile)
            {
                case Tile.TileType.Hero:
                    do
                    {
                        RNGX = RanDum.Next(1, theMap.GetLength(0));
                        RNGY = RanDum.Next(1, theMap.GetLength(1));
                    } while (IsTileOpen(RNGX,RNGY));

                    return new Hero(RNGX, RNGY);

                case Tile.TileType.Enemy:
                    do
                    {
                        RNGX = RanDum.Next(1, Tilemappy.GetLength(0));
                        RNGY = RanDum.Next(1, Tilemappy.GetLength(1));
                    } while (IsTileOpen(RNGX, RNGY));

                    int EnemyType = RanDum.Next(0, 2);

                    switch (EnemyType)
                    {
                        case 0:
                            return new Goblin(RNGX, RNGY);
                        case 1:
                            return new Mage(RNGX, RNGY);
                        default:
                            return null;
                    }

                case Tile.TileType.Gold:
                    do
                    {
                        RNGX = RanDum.Next(1, theMap.GetLength(0));
                        RNGY = RanDum.Next(1, theMap.GetLength(1));
                    } while (IsTileOpen(RNGX, RNGY));

                    return new Gold(RNGX,RNGY);

                case Tile.TileType.Weapon:
                    do
                    {
                        RNGX = RanDum.Next(1, theMap.GetLength(0));
                        RNGY = RanDum.Next(1, theMap.GetLength(1));
                    } while (IsTileOpen(RNGX, RNGY));

                    switch (RanDum.Next(0, 4))
                    {
                        case 0:
                            return new MeleeWeapon(MeleeWeapon.MeleeTypes.Dagger, RNGX, RNGY);
                        case 1:
                            return new MeleeWeapon(MeleeWeapon.MeleeTypes.Longsword, RNGX, RNGY);
                        case 2:
                            return new RangedWeapon(RangedWeapon.RangedTypes.Longbow, RNGX, RNGY);
                        case 3:
                            return new RangedWeapon(RangedWeapon.RangedTypes.Rifle, RNGX, RNGY);
                        default:
                            return null;
                    }

                 case Tile.TileType.Empty:
                    do
                    {
                        RNGX = RanDum.Next(1, Tilemappy.GetLength(0));
                        RNGY = RanDum.Next(1, Tilemappy.GetLength(1));
                    } while (IsTileOpen(RNGX, RNGY));

                    return new EmptyTile(RNGX, RNGY, '.');

                 default:
                    return null;
            }
        
        }

        //Updates the vision of player and enemies
       
        //Creates blank map with borders to be filled in later
        public void FillMap()
        {
            for (int i = 0; i < theMap.GetLength(0); i++)
            {
                for (int j = 0; j < theMap.GetLength(1); j++)
                {
                    theMap[i, j] = new EmptyTile(i, j, '.');
                }
            }

            for (int i = 0; i < theMap.GetLength(0); i++)
            {
                for (int j = 0; j < theMap.GetLength(1); j++)
                {
                   if (i == 0 || j == 0|| i == mapWide - 1 || j == mapLong - 1)
                   {
                        theMap[i, j] = new Obstacle(i,j);
                   }
                }
            }

        }

        public void GetItemAtPosition(Character character)
        {
            for (int i = 0; i < Itemythings.Length; i++)
            {
                if (Itemythings[i].getx == character.getx && Itemythings[i].gety == character.gety)
                {
                   if (Itemythings[i].GetType() == typeof(Gold))
                    {
                        character.Pickup((Gold)Itemythings[i]);
                        if (Itemythings[i].PickUp)
                        {
                            Itemythings = Itemythings.Where((source, index) => index != i).ToArray();
                        }
                    }
                   else if (Itemythings[i].GetType() == typeof(MeleeWeapon))
                    {
                        character.Pickup((MeleeWeapon)Itemythings[i]);
                        character.Equip((MeleeWeapon)Itemythings[i]);

                        Itemythings = Itemythings.Where((source, index) => index != i).ToArray();
                    }
                    else if (Itemythings[i].GetType() == typeof(RangedWeapon))
                    {
                        character.Pickup((RangedWeapon)Itemythings[i]);
                        character.Equip((RangedWeapon)Itemythings[i]);

                        Itemythings = Itemythings.Where((source, index) => index != i).ToArray();
                    }
                }
            }
        }
        public string redraw()
        {
            string output = "";
            for (int y = 0; y < theMap.GetLength(1); y++)
            {
                for (int x = 0; x < theMap.GetLength(0); x++)
                {
                    output += theMap[x, y].getsymbol;
                }
                output += '\n';
            }
            return output;
        }

        public void PlaceTile(Tile tile)
        {
            theMap[tile.getx, tile.gety] = tile;
        }
        //Allows movement for enemies
        public void MoveBaddies()
        {
            Random num = new Random();
            int directionIndicator;

            for (int i = 0; i < arrayofenemies.Length; i++)
            {
                
                    directionIndicator = num.Next(0, 5); 
                    arrayofenemies[i].Move(arrayofenemies[i].ReturnMove((Character.MovementEnum)directionIndicator));
                
            }

        }
        public void UpdateVision()
        {   
           Player.VisionArray[0] = theMap[Player.getx - 1, Player.gety];
           Player.VisionArray[1] = theMap[Player.getx + 1, Player.gety];
           Player.VisionArray[2] = theMap[Player.getx, Player.gety - 1];
           Player.VisionArray[3] = theMap[Player.getx, Player.gety + 1];
            
          foreach (Enemy enemy in arrayofenemies)
          {
            enemy.VisionArray[0] = theMap[enemy.getx - 1, enemy.gety];
            enemy.VisionArray[1] = theMap[enemy.getx + 1, enemy.gety];
            enemy.VisionArray[2] = theMap[enemy.getx, enemy.gety - 1];
            enemy.VisionArray[3] = theMap[enemy.getx, enemy.gety + 1];
          }

        }
    }
}
