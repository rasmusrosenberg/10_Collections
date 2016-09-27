using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Collections
{
    class StockValueComparator : IComparer<Asset>
    {

        public int Compare(Asset y, Asset x)
        {
            return x.GetValue().CompareTo(y.GetValue());
        }

    }
}
