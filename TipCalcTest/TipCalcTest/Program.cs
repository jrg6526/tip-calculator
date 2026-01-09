using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalcTest
{
    public class Price
    {
        public static double GetTip(double price, double qos)
        {
            return price * (qos / 100);
        }
        public static double GetTotalPrice(double price, double tip)
        {
            return price + tip;
        }
        static void Main()
        {
        }
    }
}
