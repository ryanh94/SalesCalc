using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesIo sales = new SalesIo();
            
            string saleperson = sales.GetSalesperson();
            
            sales.ChooseProduct(saleperson);

            Console.ReadLine();
        }
    }
}
