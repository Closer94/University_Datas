using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferTax
{
    class transCal
    {
        int total, longTotal;
        int trns, acqu, need; //양도가액, 취득가액, 필요경비
        double per1, per2;
        public transCal() {
            total = 0;
            trns = 0;
            acqu = 0;
            need = 0;
            per1 = 0.0;
        }
        
        public void setTrns(int t)
        {
            trns = t;
        }

        public void setAcqu(int a)
        {
            acqu = a;
        }

        public void setNeed(int n)
        {
            need = n;
        }

        public int minuCal()
        {
            total = trns - acqu - need;

            return total;

        }

        public void setPer1(double p1)
        {
            per1 = p1;
        }

        public int longCal()
        {
            longTotal = (int)(total * per1);

            return longTotal;
        }

        public int achCal()
        {
            total = total - longTotal;
            if (total < 0) //세액감면 받아서 양도소득세가 0원일 경우
            {
                total = 0;
            }
            return total;
        }

        public int stndCal()
        {
            total = total - 2500000;
            if (total < 0) //세액감면 받아서 양도소득세가 0원일 경우
            {
                total = 0;
            }
            return total;
        }

        public void setPer2(double p)
        {
            per2 = p;
        }

        public int rsltCal()
        {
            total = (int)(total * per2);

            return total;
        }

    }
}
