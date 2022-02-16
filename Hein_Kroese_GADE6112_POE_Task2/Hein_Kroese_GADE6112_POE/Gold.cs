using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hein_Kroese_GADE6112_POE
{
    class Gold : Item
    {
        private int goldAmount;
        
        Random RanDum = new Random();

        public int MaxGold { set { goldAmount = value; } get { return goldAmount; } }
        
        public Gold(int x, int y) : base(x, y, '$')
        {
            goldAmount = RanDum.Next(1, 6);
        }

        public override string ToString()
        {
            string Info = "\n";
            return Info;
        }

    }
}
