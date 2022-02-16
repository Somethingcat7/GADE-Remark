using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    abstract class Tile
    {   //Variables
        protected int x;
        protected int y;
        protected char symbol;
       
        //Accessors for x, y and symbol
        public int getx { set { x = value; } get { return x; } }
        public int gety { set { y = value; } get { return y; } }
        public char getsymbol { set { symbol = value; } get { return symbol; } }
              
        protected Tile(int X, int Y, char Symbol)
        {
            x = X;
            y = Y;
            symbol = Symbol;
        }

        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            Empty,
            Leader
        }

        public bool PickUp
        {
            get;
            internal set;
        }
             
    }
}
    

   
