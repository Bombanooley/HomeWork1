using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    struct Total
    {
        private string sOut;
        private int sum;

        public string SOUT
        {
            get { return sOut; }
            set { sOut = value; }
        }
        public int SUM
        {
            get { return sum; }
            set { sum = value; }
        }
        public Total (string a, int b)
        {
            sOut = a;
            sum = b;
        }

    }


}
