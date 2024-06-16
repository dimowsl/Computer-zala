using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Zala
{
    public class CompareDVD: IComparer<Data>
    {
        //тва е компаратор, сравнява най-дългото време
        public int Compare(Data x, Data y)
        {
            if (x.Duration > y.Duration)
            {
                return 1;
            }
            else if (x.Duration < y.Duration)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
