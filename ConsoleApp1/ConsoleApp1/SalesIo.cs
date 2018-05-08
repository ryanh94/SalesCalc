using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SalesIo
    {
        public void ChooseProduct(string saleperson)
        {

            List<Product> productCatalog = new List<Product>();

            productCatalog.Add(new Product("Broadband", 8.5m));
            productCatalog.Add(new Product("NGN", 0m));
            productCatalog.Add(new Product("Cloud PBX", 15m));
            productCatalog.Add(new Product("Bundle", 20m));

            ConsoleKeyInfo keyPress;
            do
            {
                Console.WriteLine($"Choose the product {saleperson} sold");

                foreach (var prod in productCatalog)
                {
                    Console.WriteLine("press " + (productCatalog.IndexOf(prod) + 1).ToString() + " for " + prod.name);
                }

                keyPress = Console.ReadKey(true);

            } while (keyPress.Key != ConsoleKey.D1 && keyPress.Key != ConsoleKey.D2 && keyPress.Key != ConsoleKey.D3 && keyPress.Key != ConsoleKey.D4);

            int indexfromkey = 0;

            if (keyPress.Key == ConsoleKey.D1)
            {
                indexfromkey = 1;
            }
            else if (keyPress.Key == ConsoleKey.D2)
            {
                indexfromkey = 2;
            }
            else if (keyPress.Key == ConsoleKey.D3)
            {
                indexfromkey = 3;
            }
            else
            {
                indexfromkey = 4;
            }

            var myprod = productCatalog[indexfromkey - 1];

            Console.Clear();

            Console.WriteLine($"You selected { myprod.name} which has a cost price of {myprod.costPrice}");

            SaleCalculations calc = new SaleCalculations();

            decimal sellPrice = GetSellPrice();


            if (sellPrice < myprod.costPrice)
            {
                do
                {
                    Console.WriteLine("Please remake the sale as this sale will lose us money");

                } while (sellPrice < myprod.costPrice);
            }
            else
            {             
                int termTime = GetTermOfSale();

                decimal GrossProfit = calc.TotalTermGP(sellPrice, termTime, myprod.costPrice);
                Console.WriteLine($"The Gross Profit from this sale is: {GrossProfit}");
            }
        }

        public string GetSalesperson()
        {
            string salesperson;
            do
            {

                Console.WriteLine("Hello please enter a salesperson");
                salesperson = Console.ReadLine();

            } while (salesperson.Any(c => char.IsDigit(c)));

            return salesperson;
        }

        public decimal GetSellPrice()
        {
            decimal sellPrice;
            do
            {
                Console.WriteLine("Enter the sell price");

            } while (!decimal.TryParse(Console.ReadLine(), out sellPrice));

            return sellPrice;
        }

        public int GetTermOfSale()
        {
            int term;
            do
            {
                Console.WriteLine("Enter the term of the sale");

            } while (!int.TryParse(Console.ReadLine(), out term));

            return term;
        }
    }
}
