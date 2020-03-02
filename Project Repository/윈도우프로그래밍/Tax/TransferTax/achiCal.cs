using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferTax
{
    class achiCal
    {
        int achi;
        double per;
        int result;

        public achiCal()
        {
            achi = 0;
            result = 0;
            per = 0.0;
        }

        public void setAchi(int achi)
        {
            this.achi = achi;
        }

        public void setPer(double per)
        {
            this.per = per;
        }

        public int achiResult()
        {          

            result = (int)(achi * per);
           
            return result;
        }
    }
}
