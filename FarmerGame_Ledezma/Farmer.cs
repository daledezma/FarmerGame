using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerGame_Ledezma
{
    class Farmer
    {
        private List<string> northBank = new List<string>();
        private List<string> southBank = new List<string>();

        public List<string> NorthBank
        {
            get 
            { 
                return northBank; 
            }
            set
            {
                northBank = value;
            }
        }

        public List<string> SouthBank
        {
            get
            {
                return southBank;
            }
            set
            {
                southBank = value;
            }
        }
 
    }
}
