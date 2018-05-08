using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public string name = "";
        public decimal costPrice = 0;

        public Product(string name, decimal costPrice)
        {
            this.name = name;
            this.costPrice = costPrice;
        }
    }
}
