using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    abstract class Item : Tile
    {           
        protected Item(int x, int y, char symbol) : base(x, y, symbol)
        {

        }
        
        //ToString method
        public abstract override string ToString();
    }
}
