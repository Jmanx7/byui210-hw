using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        //Contains orders
        List<Order> ordersList = new List<Order>();

        //create orders
        ordersList.Add(new Order("John Doe","123 Flower Street","Dallas","TX","USA"));
        ordersList[0].AddProduct(new Product("Soap Bar", 4.99, 4001, 5));
        ordersList[0].AddProduct(new Product("12\" Waffle Iron", 32.99, 3121, 2));
        ordersList[0].AddProduct(new Product("Depleted Uranium", 759.50, 7187, 12));

        ordersList.Add(new Order("George Washington", "3200 Mount Vernon Memorial Highway", "Arlington", "VA", "USA"));
        ordersList[1].AddProduct(new Product("Millstone", 125.99, 3601, 1));
        ordersList[1].AddProduct(new Product("Cherry Tree", 206.00, 2981, 20));
        ordersList[1].AddProduct(new Product("Powdered Wig", 12.99, 126, 4));
        ordersList[1].AddProduct(new Product("Pen & Quill Ink 12oz", 42.99, 42, 9));

        ordersList.Add(new Order("Mr. Bean", "Mr. Bean Road", "London", "England", "UK"));
        ordersList[2].AddProduct(new Product("Carrot", 1.00, 1, 1));

        ordersList.Add(new Order("Man McMan", "345 Street Road", "Beijing", "Hebei", "CN"));
        ordersList[3].AddProduct(new Product("Concrete Mix", 59.99, 784, 140));
        ordersList[3].AddProduct(new Product("Left Handed Hammer", 17.99, 8128, 10));
        ordersList[3].AddProduct(new Product("Blinker Fluid", 4.99, 9783, 5));

        //Display order information
        for (int i = 0; i < ordersList.Count(); i++)
        {
            //Display Order Number
            Console.Write("Order #");
            Console.WriteLine(i);

            //Display Labels
            ordersList[i].DisplayShippingLabel();
            ordersList[i].DisplayPackingLabel();
            
            //Get Total Order Cost
            Console.Write("Total Cost: $");
            Console.WriteLine(ordersList[i].GetTotalCost());

            //spacing
            Console.WriteLine("");
        }
    }
}