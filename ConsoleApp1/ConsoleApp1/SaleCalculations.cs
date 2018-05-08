using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SaleCalculations
    {
        public decimal TotalTermGP(decimal sellPrice, int termTime, decimal costPrice)
        {
            
            decimal totalGP = (sellPrice - costPrice) * termTime;

            return totalGP;
        }
    }
}
