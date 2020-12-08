using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKBasicTracker.Calculations
{
    public class AttributeCalculator
    {
        Retainer _ret;
        Temple _temp;
        Confidant _con;

        public Retainer Ret { get => _ret; set => _ret = value; }
        public Confidant Con { get => _con; set => _con = value; }
        internal Temple Temp { get => _temp; set => _temp = value; }

        public AttributeCalculator(Retainer ret, Temple temp, Confidant con)
        {
            _ret = ret;
            _temp = temp;
            _con = con;
        }
    }
}
