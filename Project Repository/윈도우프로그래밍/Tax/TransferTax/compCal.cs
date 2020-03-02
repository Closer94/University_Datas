using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferTax
{
    class compCal
    {
        long pub, stand, result, minus1, minus2;
        double per1, per2, per3;

        public compCal()
        {
            pub = 0;
            stand = 0;
            result = 0;
            minus1 = 0;
            minus2 = 0;
            per1 = 0.0;
            per2 = 0.0;
            per3 = 0.0;
        }

        public void setPub(long pub)
        {
            this.pub = pub;
        }

        public void setStand(long s)
        {
            stand = s;
        }

        public void setPer1(double p)
        {
            per1 = p;
        }

        public void setPer2(double p)
        {
            per2 = p;
            minus1 = (long)(result * per2); //1세대1주택자의 연령별에 따른 공제액
        }

        public void setPer3(double p)
        {
            per3 = p;
            minus2 = (long)(result * per3); //1세대1주택자의 보유기간별에 따른 공제액
        }

        public long totalResult()
        {
            result = (long)(stand * per1);
            result = result - minus1 - minus2;

            return result;
        }

    }
}
